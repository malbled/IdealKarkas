using IdealKarkas.Context;
using System.Data.Entity;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IdealKarkas.WinForms.Forms
{
    public partial class FormTreeViewProject : Form
    {
        public FormTreeViewProject()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            treeView1.Nodes.Clear();
            using (var db = new IKContext())
            {
                var list = db.Orders.ToList();

                foreach (var item in list)
                {
                   var ttt = treeView1.Nodes.Add(item.NumberProject);
                    if(item.DateEndFact != null)
                    {
                        ttt.ForeColor = Color.Gray;
                    }
                    
                    foreach (var o in item.Tasks)
                    {
                        var rrr = ttt.Nodes.Add(o.ToString());
                        rrr.ForeColor = Color.FromArgb(107, 113, 235);
                    } 
                }
                
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            using (var db = new IKContext())
            {
                var number = db.Orders.FirstOrDefault(x => x.NumberProject == treeView1.SelectedNode.Text);
                if (number != null && number.DateEndFact == null)
                {
                    var form = new FormAddTask(number);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        
                        Init();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            using (var db = new IKContext())
            {
                var number = db.Orders.FirstOrDefault(x => x.NumberProject == treeView1.SelectedNode.Text);
                if (number != null && number.DateEndFact == null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите закрыть работу над проектом {number.NumberProject}?", "IdealKarkas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        
                        number.DateEndFact = DateTimeOffset.Now;
                        db.Entry(number).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                else
                    MessageBox.Show($"Проект {number.NumberProject} уже закрыт ", "IdealKarkas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Init();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
