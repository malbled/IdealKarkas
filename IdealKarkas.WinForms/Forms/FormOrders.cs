using IdealKarkas.Context;
using IdealKarkas.Context.Models;
using IdealKarkas.WinForms.UserControls;
using System;
using System.Data.Entity;
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
        }
        public void Init()
        {
            dgvOrder.AutoGenerateColumns = false;
            using (var db = new IKContext())
            {
                dgvOrder.DataSource = db.Orders.ToList();
            }
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
        }

        private void dgvOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOrder.Columns[e.ColumnIndex].Name == "Column3" || dgvOrder.Columns[e.ColumnIndex].Name == "Column4" || dgvOrder.Columns[e.ColumnIndex].Name == "Column5")
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
                    e.Value = "Не оплачен";
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
    }
}


