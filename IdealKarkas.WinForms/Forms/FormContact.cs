using IdealKarkas.Context;
using IdealKarkas.Context.Enums;
using IdealKarkas.Context.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace IdealKarkas.WinForms.Forms
{
    public partial class FormContact : Form
    {
        public FormContact()
        {
            InitializeComponent();
            Init();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Init()
        {
            dgvStaff.AutoGenerateColumns = false;
            using (var db = new IKContext())
            {
                dgvStaff.DataSource = db.Staffs.Where(x => x.IsActual == null).ToList();
            }
            voidCount();
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

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStaff.Rows.Count > 0)
            {
                var item = (Staff)dgvStaff.SelectedRows[0].DataBoundItem;
                if (item == null) { return; }

                if (item != null)
                {
                    WorkToStaff.Staff = item;
                }
            }
        }

        private void dgvStaff_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Edit();
        }

        private void txtFIO_TextChanged(object sender, EventArgs e)
        {
            using (var db = new IKContext())
            {
                if (!(string.IsNullOrEmpty(txtFIO.Text)))
                    dgvStaff.DataSource = db.Staffs.Where(p => p.LastName.ToLower().Contains(txtFIO.Text.ToLower()) && p.IsActual == null).ToList();
                else
                    Init();
            }
            voidCount();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtFIO.Text = string.Empty;
        }

        private void добавитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormAccount();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var db = new IKContext())
                {
                    db.Staffs.Add(form.Staff);
                    db.SaveChanges();
                }
                Init();
            }
        }

        private void редактироватьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }
        public void ShowEdit()
        {
            var item = (Staff)dgvStaff.SelectedRows[0].DataBoundItem;
            if (item == null) return;
            using (var db = new IKContext())
            {
                var item1 = db.Staffs.FirstOrDefault(x => x.Id == item.Id);
                var form = new FormAccount(item1);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.SaveChanges();
                    Init();
                }
            }
        }
        public void Edit()
        {
            if (WorkToUser.Staff.TypeUser == TypeUser.Root)
            {
                ShowEdit();
            }
            if (WorkToUser.Staff.TypeUser == TypeUser.Admin || WorkToUser.Staff.TypeUser == TypeUser.Manager)
            {
                if (WorkToStaff.Staff.TypeUser == TypeUser.Member)
                {
                    ShowEdit();
                }
                else
                {
                    MessageBox.Show("Вы должны обладать правами ROOT, для редактирования информации о пользователе", "IdealKarkas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void удалитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = (Staff)dgvStaff.SelectedRows[0].DataBoundItem;
            if (item == null) return;
            if (WorkToUser.Staff.Id == item.Id)
            {
                MessageBox.Show("Удалить себя из системы - НЕВОЗМОЖНО\n\nЭто может сделать другой пользователь с правами ROOT", "IdealKarkas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(WorkToUser.Staff.TypeUser == TypeUser.Root)
                {
                    DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите удалить {item} из системы?", "IdealKarkas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
        }
        public void voidCount()
        {
            if (dgvStaff.Rows.Count >= 0)
            {
                var dop = dgvStaff.Rows.Count;
                labelAllCount.Text = $"Количество записей : {dop}";
            }
        }
    }
}
