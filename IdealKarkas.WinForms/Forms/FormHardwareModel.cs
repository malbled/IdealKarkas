using IdealKarkas.Context;
using IdealKarkas.Context.Enums;
using IdealKarkas.Context.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IdealKarkas.WinForms.Forms
{
    public partial class FormHardwareModel : Form
    {
        public Hardware Hardware { get; set; }
        public Manufacturer Manufacturer { get; set; }
        int inty;
        public FormHardwareModel()
        {
            InitializeComponent();
            Hardware = new Hardware();
            Manufacturer = new Manufacturer();
            cmbTypeOverShip.Items.AddRange(Enum.GetNames(typeof(TypeOvership)));
            var context = new IKContext();
            cmbManu.Items.AddRange(context.Manufacturers.ToArray());
            cmbManu.DisplayMember = nameof(Manufacturer.Title);
            var dop = context.Hardwares.OrderByDescending(x => x.SerialNumber).FirstOrDefault();
            if (dop != null)
            {
                inty = Convert.ToInt32( dop.SerialNumber) + 1;
            }
            else
            {
                inty = 2100;
            }
            if (txtNumber.Text == string.Empty)
            {
                txtNumber.Text = inty.ToString();
            }
        }

        public FormHardwareModel(Hardware hardware) : this()
        {
            Hardware = hardware;
            txtTitle.Text = hardware.Title;
            txtNumber.Text = hardware.SerialNumber;
            cmbManu.SelectedItem = cmbManu.Items.Cast<Manufacturer>().FirstOrDefault(x => x.Id == hardware.ManufacrureId);
            txtDescription.Text = hardware.Description;
            cmbTypeOverShip.SelectedItem = hardware.TypeOvership.ToString();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            using (var db = new IKContext())
            {
                Hardware.Title = txtTitle.Text;
                Hardware.SerialNumber = txtNumber.Text;
                Hardware.Description = txtDescription.Text;
                if (cmbManu.SelectedIndex > -1)
                    Hardware.ManufacrureId = ((Manufacturer)cmbManu.SelectedItem).Id;
                else
                {
                    Manufacturer.Title = cmbManu.Text;
                        db.Manufacturers.Add(Manufacturer);
                        db.SaveChanges();
                        var dop = db.Manufacturers.OrderByDescending(x => x.Id).FirstOrDefault();
                        Hardware.ManufacrureId = dop.Id;
                }
                Hardware.TypeOvership = (TypeOvership)cmbTypeOverShip.SelectedIndex;
                DialogResult = DialogResult.OK;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = !string.IsNullOrWhiteSpace(txtTitle.Text)
            && !string.IsNullOrWhiteSpace(txtNumber.Text)
            && !string.IsNullOrWhiteSpace(txtDescription.Text)
            && !string.IsNullOrWhiteSpace(cmbManu.Text)
            && cmbTypeOverShip.SelectedIndex > -1;
        }
    }
}
