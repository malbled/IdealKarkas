using IdealKarkas.Context;
using IdealKarkas.Context.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdealKarkas.WinForms.Forms
{
    public partial class FormAddTask : Form
    {
        Dictionary<Staff, int> staffs = new Dictionary<Staff, int>();
        Dictionary<Hardware, int> hardwares = new Dictionary<Hardware, int>();
        public int Ids;
        public FormAddTask()
        {
            InitializeComponent();
            txtStaff.Text = "Поиск сотрудника";
            txtStaff.ForeColor = Color.Gray;
            txtHardware.Text = "Поиск оборудования";
            txtHardware.ForeColor = Color.Gray;
        }
        public FormAddTask(Order order) : this()
        {
            Ids = order.Id;
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            //listBoxHardware.Items.Clear();
            using (var db = new IKContext())
            {
                dgvStaff.AutoGenerateColumns = false;
                dgvStaff.AllowUserToResizeRows = false;
                if (!string.IsNullOrEmpty(txtStaff.Text))
                    dgvStaff.DataSource = db.Staffs.Where(p => p.LastName.ToLower().Contains(txtStaff.Text.ToLower()) && p.TypeUser == Context.Enums.TypeUser.Member && p.IsActual == null).ToList();
            }
        }

        private void btnSearchHarware_Click(object sender, EventArgs e)
        {
           //listBoxHardware.Items.Clear();
            using (var db = new IKContext())
            {
                dgvHardware.AutoGenerateColumns = false;
                dgvHardware.AllowUserToResizeRows = false;
                dgvHardware.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                if (!string.IsNullOrEmpty(txtHardware.Text))
                    dgvHardware.DataSource = db.Hardwares.Where(p => p.Title.ToLower().Contains(txtHardware.Text.ToLower()) && p.IsActual == null).ToList();
            }
        }

        private void dgvClient_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var item = (Staff)dgvStaff.SelectedRows[0].DataBoundItem;
            if (item == null) return;
            using (var db = new IKContext())
            {
                var item1 = db.Staffs.FirstOrDefault(x => x.Id == item.Id);
                staffs.Add(item1, 0);
                listBoxStaff.Items.Add(item1.ToString());   
            }
            enableButton();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var item = (Hardware)dgvHardware.SelectedRows[0].DataBoundItem;
            if (item == null) return;
            using (var db = new IKContext())
            {
                var item1 = db.Hardwares.FirstOrDefault(x => x.Id == item.Id);
                hardwares.Add(item1, 0);
                listBoxHardware.Items.Add(item1.ToString());
            }
            enableButton();
        }

        private void dgvStaff_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvStaff.Columns[e.ColumnIndex].Name == "Column1")
            {
                if (e.Value != null)
                {
                    using (var db = new IKContext())
                    {
                        int myInt = Convert.ToInt32(e.Value);
                        var user = db.Staffs.FirstOrDefault(x => x.Id == myInt);
                        e.Value = user.ToString();
                    }
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            
            var task = new Context.Models.Task
            {
                Title = txtTitle.Text,
                Description = txtDesc.Text,
                AdminFIO = WorkToUser.Staff.ToString(),
                DateAdd = DateTimeOffset.Now,
            };
            using (var db = new IKContext())
            {
                var Idss = staffs.Keys.Select(x => x.Id).ToList();
                var tours = db.Staffs.Where(x => Idss.Contains(x.Id)).ToList();
                var Idsss = hardwares.Keys.Select(x => x.Id).ToList();
                var tourss = db.Hardwares.Where(x => Idsss.Contains(x.Id)).ToList();
                task.Staffs = tours;
                task.Hardwares = tourss;
                db.Tasks.Add(task);
                db.SaveChanges();
                var id = task.Id;
                var order = db.Orders.FirstOrDefault(x => x.Id == Ids);
                var item = db.Tasks.Where(x => x.Id == id).ToList();

                order.Tasks = item;
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void txtStaff_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStaff.Text))
            {
                txtStaff.Text = "Поиск сотрудника";
                txtStaff.ForeColor = Color.Gray;
            }
        }

        private void txtStaff_Enter(object sender, EventArgs e)
        {
            if (txtStaff.Text == "Поиск сотрудника")
            {
                txtStaff.Clear();
                txtStaff.ForeColor = Color.Black;
            }
        }

        private void txtHardware_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHardware.Text))
            {
                txtHardware.Text = "Поиск оборудования";
                txtHardware.ForeColor = Color.Gray;
            }
        }

        private void txtHardware_Enter(object sender, EventArgs e)
        {
            if (txtHardware.Text == "Поиск оборудования")
            {
                txtHardware.Clear();
                txtHardware.ForeColor = Color.Black;
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }
        public void enableButton()
        {
            btnSaveChanges.Enabled = !string.IsNullOrWhiteSpace(txtTitle.Text)
                && !string.IsNullOrWhiteSpace(txtDesc.Text)
                && listBoxHardware.Items.Count > 0
                && listBoxStaff.Items.Count > 0;
        }
    }
}
