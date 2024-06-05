using IdealKarkas.Context;
using IdealKarkas.Context.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace IdealKarkas.WinForms.Forms
{
    public partial class FormHardware : Form
    {
        public FormHardware()
        {
            InitializeComponent();
            Init();
            dgvHardware.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Init()
        {
            dgvHardware.AutoGenerateColumns = false;
            using (var db = new IKContext())
            {
                dgvHardware.DataSource = db.Hardwares.Where(x => x.IsActual == null).ToList();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (var db = new IKContext())
            {
                if (!(string.IsNullOrEmpty(txtSearch.Text)))
                    dgvHardware.DataSource = db.Hardwares.Where(p => p.SerialNumber.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
                else
                    Init();
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormHardwareModel();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var db = new IKContext())
                {
                    db.Hardwares.Add(form.Hardware);
                    db.SaveChanges();
                }
                Init();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvHardware.Rows.Count != 0)
            {
                var item = (Hardware)dgvHardware.SelectedRows[0].DataBoundItem;
                if (item == null) return;
                using (var db = new IKContext())
                {
                    var item1 = db.Hardwares.FirstOrDefault(x => x.Id == item.Id);
                    var form = new FormHardwareModel(item1);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        db.SaveChanges();
                        Init();
                    }
                }
            }      
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvHardware.Rows.Count != 0)
            {
                var item = (Hardware)dgvHardware.SelectedRows[0].DataBoundItem;
                if (item == null) return;
                DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите удалить {item.Title} из системы?", "IdealKarkas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    using (var db = new IKContext())
                    {
                        item.IsActual = 0;
                        db.Entry(item).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    Init();
                }
            }
        }

        private void dgvHardware_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var item = (Hardware)dgvHardware.SelectedRows[0].DataBoundItem;
            if (item == null) return;
            using (var db = new IKContext())
            {
                var item1 = db.Hardwares.FirstOrDefault(x => x.Id == item.Id);
                var form = new FormHardwareModel(item1);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.SaveChanges();
                    Init();
                }
            }
        }
    }
}
