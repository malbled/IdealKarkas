using IdealKarkas.Context;
using IdealKarkas.Context.Enums;
using IdealKarkas.Context.Models;
using System;
using System.Windows.Forms;

namespace IdealKarkas.WinForms.Forms
{
    public partial class FormClientModel : Form
    {
        public Client Client { get; set; }
        public FormClientModel()
        {
            InitializeComponent();
            Client = new Client();
            cmbTypeClient.Items.AddRange(Enum.GetNames(typeof(TypeClient)));
        }

        public FormClientModel(Client client) : this()
        {
            Client = client;
            txtLastName.Text = client.LastName;
            txtFirstName.Text = client.FirstName;
            txtEmail.Text = client.Email;
            txtPatronymic.Text = client.Patronymic;
            txtName.Text = client.CompanyName;
            txtINN.Text = client.INN;
            txtPhone.Text = client.PhoneNumber;
            txtCity.Text = client.CityCompany;
            cmbTypeClient.SelectedItem = client.TypeClient.ToString();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            using (var db = new IKContext())
            {
                Client.LastName = txtLastName.Text;
                Client.Email = txtEmail.Text;
                Client.CompanyName = txtName.Text;
                Client.FirstName = txtFirstName.Text;
                Client.INN = txtINN.Text;
                Client.Patronymic = txtPatronymic.Text;
                Client.CityCompany = txtCity.Text;
                Client.PhoneNumber = txtPhone.Text;
                Client.TypeClient = (TypeClient)cmbTypeClient.SelectedIndex;
                DialogResult = DialogResult.OK;
            }
        }

        private void cmbTypeUser_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTypeClient.Text == "Individual")
            {
                label7.Visible = label12.Visible  = label10.Visible = label9.Visible = label4.Visible = txtName.Visible = txtINN.Visible = txtCity.Visible = false;
                txtName.Text = txtINN.Text = txtCity.Text =  string.Empty;
            }
            else
            {
                label7.Visible = label12.Visible = label10.Visible = label9.Visible = label4.Visible = txtName.Visible = txtINN.Visible = txtCity.Visible = true;
            }
            if (cmbTypeClient.Text == "Individual")
            {
                btnSaveChanges.Enabled = !string.IsNullOrWhiteSpace(txtLastName.Text)
                && !string.IsNullOrWhiteSpace(txtFirstName.Text)
                && !string.IsNullOrWhiteSpace(txtEmail.Text)
                && !string.IsNullOrWhiteSpace(txtPhone.Text)
                && cmbTypeClient.SelectedIndex != -1;
            }
            else
            {
                btnSaveChanges.Enabled = !string.IsNullOrWhiteSpace(txtLastName.Text)
                && !string.IsNullOrWhiteSpace(txtFirstName.Text)
                && !string.IsNullOrWhiteSpace(txtEmail.Text)
                && !string.IsNullOrWhiteSpace(txtPhone.Text)
                && !string.IsNullOrWhiteSpace(txtName.Text)
                && !string.IsNullOrWhiteSpace(txtINN.Text)
                && !string.IsNullOrWhiteSpace(txtCity.Text)
                && cmbTypeClient.SelectedIndex != -1;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if(cmbTypeClient.Text == "Individual")
            {
                btnSaveChanges.Enabled = !string.IsNullOrWhiteSpace(txtLastName.Text)
                 && !string.IsNullOrWhiteSpace(txtFirstName.Text)
                 && !string.IsNullOrWhiteSpace(txtEmail.Text)
                 && !string.IsNullOrWhiteSpace(txtPhone.Text)
                 && cmbTypeClient.SelectedIndex != -1;
            }
            else
            {
                btnSaveChanges.Enabled = !string.IsNullOrWhiteSpace(txtLastName.Text)
                && !string.IsNullOrWhiteSpace(txtFirstName.Text)
                && !string.IsNullOrWhiteSpace(txtEmail.Text)
                && !string.IsNullOrWhiteSpace(txtPhone.Text)
                && !string.IsNullOrWhiteSpace(txtName.Text)
                && !string.IsNullOrWhiteSpace(txtINN.Text)
                && !string.IsNullOrWhiteSpace(txtCity.Text)
                && cmbTypeClient.SelectedIndex != -1;
            }
        }
    }
}
