using IdealKarkas.Context;
using IdealKarkas.Context.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace IdealKarkas.WinForms.Forms
{
    public partial class FormObject : Form
    {
        public System.Collections.Generic.List<ObjectMod> list;
        public FormObject()
        {
            InitializeComponent();
            Init();
            dgvObject.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Init()
        {
            dgvObject.AutoGenerateColumns = false;
            using (var db = new IKContext())
            {
                dgvObject.DataSource = db.ObjectMods.Where(x => x.IsActual == null).ToList();
                list = db.ObjectMods.Where(x => x.IsActual == null).ToList();
            }
            using (var db = new IKContext())
            {
                cmbTypeObject.Items.Clear();
                var types = db.TypeObjects.ToArray();
                var defaultType = new TypeObject
                {
                    Id = -1,
                    Title = "Все типы"
                };

                cmbTypeObject.Items.AddRange(types);
                cmbTypeObject.Items.Insert(0, defaultType);
                cmbTypeObject.SelectedIndex = 0;
                cmbTypeObject.DisplayMember = nameof(TypeObject.Title);
            }
            voidCount();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormObjectModel();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var db = new IKContext())
                {
                    db.ObjectMods.Add(form.ObjectMod);
                    db.SaveChanges();
                }
                Init();
            }
        }

        private void dgvObject_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvObject.Columns[e.ColumnIndex].Name == "Column2")
            {
                if (e.Value != null)
                {
                    using (var db = new IKContext())
                    {
                        int myInt = Convert.ToInt32(e.Value);
                        var user = db.TypeObjects.FirstOrDefault(x => x.Id == myInt);
                        e.Value = user.Title.ToString();
                    }
                }
            }
            if (dgvObject.Columns[e.ColumnIndex].Name == "Column5")
            {
                if (e.Value != null)
                {
                    using (var db = new IKContext())
                    {
                        int myInt = Convert.ToInt32(e.Value);
                        var user = db.ObjectMods.FirstOrDefault(x => x.Id == myInt);
                        e.Value = $"Количество спален: {user.CountBedroom}\nКоличество санузлов: {user.CountBathroom}\nМинимальный период строительства: {user.MinPeriod}\n";
                    }
                }
            }
        }

        private void редактироватьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvObject.Rows.Count > 0)
            {
                var item = (ObjectMod)dgvObject.SelectedRows[0].DataBoundItem;
                if (item == null) return;
                using (var db = new IKContext())
                {
                    var item1 = db.ObjectMods.FirstOrDefault(x => x.Id == item.Id);
                    var form = new FormObjectModel(item1);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        db.SaveChanges();
                        Init();
                    }
                }
            }
            
        }

        private void удалитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvObject.Rows.Count > 0)
            {
                var item = (ObjectMod)dgvObject.SelectedRows[0].DataBoundItem;
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

        private void FormObject_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbTypeObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypeObject.SelectedItem == null)
                return;
            var selectedTypeId = ((TypeObject)cmbTypeObject.SelectedItem).Id;
            foreach (var item in list)
            {
                if (cmbTypeObject.SelectedIndex > -1)
                {
                    dgvObject.DataSource = list.Where(x => x.TypeObjectId == selectedTypeId).ToList();
                }
                if(cmbTypeObject.SelectedIndex == 0)
                {
                    dgvObject.DataSource = list;
                }
            }
            voidCount();
        }

        private void dgvObject_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var item = (ObjectMod)dgvObject.SelectedRows[0].DataBoundItem;
            if (item == null) return;
            using (var db = new IKContext())
            {
                var item1 = db.ObjectMods.FirstOrDefault(x => x.Id == item.Id);
                var form = new FormObjectModel(item1);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.SaveChanges();
                    Init();
                }
            }
        }
        public void voidCount()
        {
            if (dgvObject.Rows.Count >= 0)
            {
                var dop = dgvObject.Rows.Count;
                labelCount.Text = $"Количество записей : {dop}";
            }

        }
    }
}
