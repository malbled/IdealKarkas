using IdealKarkas.Context;
using IdealKarkas.Context.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IdealKarkas.WinForms.Forms
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            Init();
            dgvClient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        public void Init()
        {
            dgvClient.AutoGenerateColumns = false;
            using (var db = new IKContext())
            dgvClient.DataSource = db.Clients.ToList();
            voidCount();
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
                    dgvClient.DataSource = db.Clients.Where(p => p.LastName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
                else
                    Init();
            }
            voidCount();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormClientModel();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var db = new IKContext())
                {
                    db.Clients.Add(form.Client);
                    db.SaveChanges();
                }
                Init();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvClient.Rows.Count > 0)
            {
                var item = (Client)dgvClient.SelectedRows[0].DataBoundItem;
                if (item == null) return;
                using (var db = new IKContext())
                {
                    var item1 = db.Clients.FirstOrDefault(x => x.Id == item.Id);
                    var form = new FormClientModel(item1);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        db.SaveChanges();
                        Init();
                    }
                }
            }
            
        }

        private void dgvClient_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvClient.Columns[e.ColumnIndex].Name == "Column1")
            {
                if (e.Value != null)
                {
                    using (var db = new IKContext())
                    {
                        int myInt = Convert.ToInt32(e.Value);
                        var user = db.Clients.FirstOrDefault(x => x.Id == myInt);
                        e.Value = user.ToString();
                    }
                }
            }
            if (dgvClient.Columns[e.ColumnIndex].Name == "Column2")
            {
                if (e.Value != null)
                {
                    using (var db = new IKContext())
                    {
                        int myInt = Convert.ToInt32(e.Value);
                        var user = db.Clients.FirstOrDefault(x => x.Id == myInt);
                        e.Value = user.Email+ "\n" + user.PhoneNumber;
                    }
                }
            }
            if (dgvClient.Columns[e.ColumnIndex].Name == "Column4")
            {
                if (e.Value != null)
                {
                    using (var db = new IKContext())
                    {
                        int myInt = Convert.ToInt32(e.Value);
                        var user = db.Clients.FirstOrDefault(x => x.Id == myInt);
                        if(user.TypeClient == Context.Enums.TypeClient.Business)
                            e.Value = user.CompanyName + "\n" + user.INN + $" ({user.CityCompany})";
                        else
                            e.Value = string.Empty;
                    }
                }
            }
        }

        private void выбратьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvClient.Rows.Count > 0)
            {
                var item = (Client)dgvClient.SelectedRows[0].DataBoundItem;

                if (item != null)
                    WorkToClient.Client = item;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
        public void voidCount()
        {
            if (dgvClient.Rows.Count >= 0)
            {
                var dop = dgvClient.Rows.Count;
                labelAllCount.Text = $"Количество записей : {dop}";
            }
        }
    }
}
