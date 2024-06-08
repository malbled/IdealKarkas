using IdealKarkas.Context;
using IdealKarkas.Context.Models;
using IdealKarkas.WinForms.UserControls;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IdealKarkas.WinForms.Forms
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            Init();
            dgvOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cmbFilter.SelectedIndex = 0;
            
        }
        public void Init()
        {
            dgvOrder.AutoGenerateColumns = false;
            using (var db = new IKContext())
            {
                dgvOrder.DataSource = db.Orders.ToList();
            }
            voidCount();
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = (Order)dgvOrder.SelectedRows[0].DataBoundItem;
            if (item == null) return;
            using (var db = new IKContext())
            {
                flowLayoutPanel1.Controls.Clear();
                _ = new ViewInfo(item)
                {
                    Parent = flowLayoutPanel1
                };
            }
            Form.ActiveForm.WindowState = FormWindowState.Maximized;
        }

        private void dgvOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOrder.Columns[e.ColumnIndex].Name == "Column3" || dgvOrder.Columns[e.ColumnIndex].Name == "Column4")
            {
                if (e.Value != null)
                {
                    DateTimeOffset myDate = (DateTimeOffset)e.Value;
                    e.Value = myDate.UtcDateTime.ToShortDateString();
                }
            }
            if (dgvOrder.Columns[e.ColumnIndex].Name == "Column6" )
            {
                if (e.Value != null)
                {
                    DateTimeOffset myDate = (DateTimeOffset)e.Value;
                    e.Value = myDate.UtcDateTime.ToShortDateString();
                }
                else
                {
                    e.Value = "Не оплачен";
                    e.CellStyle.BackColor = Color.OrangeRed;
                }    
            }
            if(dgvOrder.Columns[e.ColumnIndex].Name == "Column5")
            {
                using (var db = new IKContext())
                {
                    Order user = new Order();
                    if (e.Value != null)
                    {
                        int myInt = Convert.ToInt32(e.Value);
                        user = db.Orders.FirstOrDefault(x => x.Id == myInt);
                        if(user.DateEndFact != null)
                        {
                            var dop = user.DateEndFact;
                            e.Value = dop.Value.UtcDateTime.ToShortDateString();
                        }
                        else
                        {
                            e.Value = string.Empty;
                            if (user.DateEnd < DateTimeOffset.UtcNow)
                            {
                                e.CellStyle.BackColor = Color.OrangeRed;  
                            }
                        }
                    }
                }
                
            }
            if (dgvOrder.Columns[e.ColumnIndex].Name == "Column2")
            {
                if (e.Value != null)
                {
                    using (var db = new IKContext())
                    {
                        int myInt = Convert.ToInt32(e.Value);
                        var user = db.Staffs.FirstOrDefault(x => x.Id == myInt);
                        e.Value = $"{user}";
                    }
                }
            }
        }

        private void закрытьОплатуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvOrder.Rows.Count > 0)
            {
                var item = (Order)dgvOrder.SelectedRows[0].DataBoundItem;
                if (item == null) return;
                if (item.DatePayFact == null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите закрыть оплату {item.NumberProject}?", "IdealKarkas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        using (var db = new IKContext())
                        {
                            item.DatePayFact = DateTimeOffset.Now;
                            db.Entry(item).State = EntityState.Modified;
                            db.SaveChanges();
                            Init();
                        }
                    }
                }
                else
                    MessageBox.Show($"Оплата уже закрыта для {item.NumberProject}", "IdealKarkas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void voidCount()
        {
            if (dgvOrder.Rows.Count >= 0)
            {
                var dop = dgvOrder.Rows.Count;
                labelAllCount.Text = $"Количество записей : {dop}";
            }

        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(dgvOrder.Rows.Count >= 0)
            using(var db = new IKContext())
            {
                if (cmbFilter.SelectedIndex == 0)
                    dgvOrder.DataSource = db.Orders.ToList();
                if (cmbFilter.SelectedIndex == 1)
                    dgvOrder.DataSource = db.Orders.Where(x => x.DateEndFact != null).ToList();
                if (cmbFilter.SelectedIndex == 2)
                    dgvOrder.DataSource = db.Orders.Where(x => x.DateEndFact == null).ToList();
                if (cmbFilter.SelectedIndex == 3)
                    dgvOrder.DataSource = db.Orders.Where(x => x.DatePayFact != null).ToList();
                if (cmbFilter.SelectedIndex == 4)
                    dgvOrder.DataSource = db.Orders.Where(x => x.DatePayFact == null).ToList();
            }
            voidCount();
        }
    }
}


