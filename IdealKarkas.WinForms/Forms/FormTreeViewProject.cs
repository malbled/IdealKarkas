using IdealKarkas.Context;
using System.Data.Entity;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Xml.Linq;
using System.IO;
using IdealKarkas.Context.Models;

namespace IdealKarkas.WinForms.Forms
{
    public partial class FormTreeViewProject : Form
    {
        public FormTreeViewProject()
        {
            InitializeComponent();
            Init();
            cmbType.SelectedIndex = 0;
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
                if(treeView1.Nodes != null)
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
                
            }
            Init();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new IKContext())
            {
                if (treeView1.Nodes != null)
                {
                    var number = db.Tasks.FirstOrDefault(x => x.Title == treeView1.SelectedNode.Text);
                    if (number != null)
                    {
                        var user = number.Orders.FirstOrDefault();
                        Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                        File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Задача" + " " + number.DateAdd.UtcDateTime.ToShortDateString() + ".docx", "");
                        Document doc = app.Documents.Open("C:\\Users\\leksa\\Desktop\\Задача" + " " + number.DateAdd.UtcDateTime.ToShortDateString() + ".docx");
                        object missing = null;
                        doc.Content.Text = "\t\t\t\t   ИдеалКаркас\n" +
                            "Заказ: " + user.NumberProject + " \n" +
                            "Название задачи: " + number.Title + " \n" +
                            "Ответственный за выполнение: " + number.AdminFIO + " \n" +
                            " \n" +
                            "Использованное оборудование: \n" + string.Join(";\n", number.Hardwares) + " \n\n" +
                            "Задействованные сотрудники: \n" + string.Join(";\n", number.Staffs) + " \n" +
                            " \n" +
                            "Описание проделанных работ: \n" + number.Description + " \n" +
                            " \n" +
                            " \n" +
                            " \n" +
                            " \n" +
                            "Подпись ____________\t\n" +
                            number.AdminFIO + "\t       \n\n\n" +
                            "Дата создания задачи: " + number.DateAdd.UtcDateTime.ToShortDateString() + " \n" +
                            " \n";
                        doc.Save();
                        doc.Close(ref missing);
                        app.Quit(ref missing);
                    }
                }       
            }     
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbType.SelectedIndex == 0)
            {
                Init(); 
            }
            if(cmbType.SelectedIndex == 1)
            {
                treeView1.Nodes.Clear();
                using (var db = new IKContext())
                {
                    var list = db.Orders.Where(x => x.DateEndFact == null).ToList();

                    foreach (var item in list)
                    {
                        var ttt = treeView1.Nodes.Add(item.NumberProject);
                        if (item.DateEndFact != null)
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
            if(cmbType.SelectedIndex == 2)
            {
                treeView1.Nodes.Clear();
                using (var db = new IKContext())
                {
                    var list = db.Orders.Where(x => x.DateEndFact != null).ToList();

                    foreach (var item in list)
                    {
                        var ttt = treeView1.Nodes.Add(item.NumberProject);
                        if (item.DateEndFact != null)
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
        }
    }
}
