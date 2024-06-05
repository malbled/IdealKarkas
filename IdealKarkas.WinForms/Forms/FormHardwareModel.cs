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
        int inty;
        public FormHardwareModel()
        {
            InitializeComponent();
            Hardware = new Hardware();
            cmbTypeOverShip.Items.AddRange(Enum.GetNames(typeof(TypeOvership)));
            var context = new IKContext();
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
            txtManu.Text = hardware.Manufacturer;
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
                Hardware.Manufacturer = txtManu.Text;
                Hardware.TypeOvership = (TypeOvership)cmbTypeOverShip.SelectedIndex;
                DialogResult = DialogResult.OK;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = !string.IsNullOrWhiteSpace(txtTitle.Text)
            && !string.IsNullOrWhiteSpace(txtNumber.Text)
            && !string.IsNullOrWhiteSpace(txtDescription.Text)
            && !string.IsNullOrWhiteSpace(txtManu.Text)
            && cmbTypeOverShip.SelectedIndex > -1;
        }
    }
}
