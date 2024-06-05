using IdealKarkas.Context.Models;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IdealKarkas.WinForms.UserControls
{
    public partial class ViewObject : UserControl
    {
        public ObjectMod objectMod { get; set; }
        public event Action<ObjectMod> AddToOrder;
        public ViewObject(ObjectMod objectMod)
        {
            InitializeComponent();
            this.objectMod = objectMod;
            InitObjectMod(objectMod);
        }
        public ObjectMod ObjectMod => objectMod;
        public void InitObjectMod(ObjectMod objectMod)
        {
            label1.Text = objectMod.Title;
            label3.Text = objectMod.Area.ToString() + " м²";
            label2.Text = $"{objectMod.Price:C2}";
            if (objectMod.ImagePreview != null)
            {
                var image = Image.FromStream(new MemoryStream(objectMod.ImagePreview));
                pictureBox1.Image = image;
            }
        }

        private void добавитьКЗаказуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddToOrder?.Invoke(objectMod);
        }
    }
}
