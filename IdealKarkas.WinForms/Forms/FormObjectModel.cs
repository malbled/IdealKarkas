using IdealKarkas.Context;
using IdealKarkas.Context.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace IdealKarkas.WinForms.Forms
{
    public partial class FormObjectModel : Form
    {
        public ObjectMod ObjectMod { get; set; }
        public TypeObject TypeObject { get; set; }
        byte[] image;
        public FormObjectModel()
        {
            InitializeComponent();
            ObjectMod = new ObjectMod();
            TypeObject = new TypeObject();
            using (var db = new IKContext())
            {
                cmbTypeObject.Items.AddRange(db.TypeObjects.ToArray());
                cmbTypeObject.DisplayMember = nameof(TypeObject.Title);
            }
        }

        public FormObjectModel(ObjectMod objectMod) : this()
        {
            ObjectMod = objectMod;
            txtTitle.Text = objectMod.Title;
            cmbTypeObject.SelectedItem = cmbTypeObject.Items.Cast<TypeObject>().FirstOrDefault(x => x.Id == ObjectMod.TypeObjectId);
            txtArea.Text = objectMod.Area.ToString();
            numFloor.Value = objectMod.Floor;
            numBathRoom.Value = objectMod.CountBathroom;
            numBedRoom.Value = objectMod.CountBedroom;
            txtMinPeriod.Text = objectMod.MinPeriod.ToString();
            txtPrice.Text = objectMod.Price.ToString();
            txtDesc.Text = objectMod.Description;
            if (objectMod.ImagePreview != null)
            {
                var image1 = System.Drawing.Image.FromStream(new MemoryStream(objectMod.ImagePreview));
                picBox.Image = image1;
                using (var ms = new MemoryStream())
                {
                    image1.Save(ms, image1.RawFormat);
                    image = ms.ToArray();
                }
            }
        }

        private void btnLoadPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файлы изображений (*.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image = File.ReadAllBytes(openFileDialog1.FileName);
                picBox.Image = System.Drawing.Image.FromStream(new MemoryStream(image));
            }
        }

        private void btnDeletePhoto_Click(object sender, EventArgs e)
        {
            picBox.Image = null;
            image = null;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            ObjectMod.Title = txtTitle.Text;
            ObjectMod.Area = Convert.ToDecimal(txtArea.Text);
            ObjectMod.Floor = Convert.ToInt32(numFloor.Value);
            ObjectMod.CountBathroom = Convert.ToInt32(numBathRoom.Value);
            ObjectMod.CountBedroom = Convert.ToInt32(numBedRoom.Value);
            ObjectMod.MinPeriod = Convert.ToInt32(txtMinPeriod.Text);
            ObjectMod.Price = Convert.ToDecimal(txtPrice.Text);
            ObjectMod.Description = txtDesc.Text;
            ObjectMod.ImagePreview = image;
                if (cmbTypeObject.SelectedIndex > -1)
                    ObjectMod.TypeObjectId = ((TypeObject)cmbTypeObject.SelectedItem).Id;
                else
                {
                    TypeObject.Title = cmbTypeObject.Text;
                    using (var db = new IKContext())
                    {
                        db.TypeObjects.Add(TypeObject);
                        db.SaveChanges();
                        var dop = db.TypeObjects.OrderByDescending(x => x.Id).FirstOrDefault();
                        ObjectMod.TypeObjectId = dop.Id;
                    }
                }
            DialogResult = DialogResult.OK;
        }

        private void txtArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & (e.KeyChar != ',') & (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void txtMinPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = !string.IsNullOrWhiteSpace(txtTitle.Text)
            && !string.IsNullOrWhiteSpace(txtArea.Text)
            && !string.IsNullOrWhiteSpace(txtMinPeriod.Text)
            && !string.IsNullOrWhiteSpace(txtPrice.Text)
            && !string.IsNullOrWhiteSpace(cmbTypeObject.Text);
        }
    }
}
