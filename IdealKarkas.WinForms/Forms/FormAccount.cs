using IdealKarkas.Context;
using IdealKarkas.Context.Enums;
using IdealKarkas.Context.Models;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace IdealKarkas.WinForms.Forms
{
    public partial class FormAccount : Form
    {
        public Staff Staff { get; set; }
        byte[] image;
        public ToolTip toolTip1 = new ToolTip();
        public FormAccount()
        {
            InitializeComponent();
            Staff = new Staff();
            cmbTypeUser.Items.AddRange(Enum.GetNames(typeof(TypeUser)));
            Settings();
        }

        public void Settings()
        {
            if(WorkToUser.Staff.TypeUser == TypeUser.Admin || WorkToUser.Staff.TypeUser == TypeUser.Manager)
                cmbTypeUser.Items.RemoveAt(0);
            if(WorkToStaff.Staff == WorkToUser.Staff)
                txtFirstName.Enabled = txtLastName.Enabled = txtPatronymic.Enabled = txtPassport.Enabled = txtPost.Enabled = cmbTypeUser.Enabled = false;
        }
        public FormAccount(Staff staff) : this()
        {
            Staff = staff;
            txtLastName.Text = staff.LastName;
            txtFirstName.Text = staff.FirstName;
            txtEmail.Text = staff.Email;
            txtPatronymic.Text = staff.Patronymic;
            txtPassport.Text = staff.Passport;
            txtPassword.Text = staff.Password;
            txtPhone.Text = staff.PhoneNumber;
            txtPost.Text = staff.Post;
            txtLogin.Text = staff.Login;
            cmbTypeUser.SelectedItem = staff.TypeUser.ToString();
            if (staff.ImagePreview != null)
            {
                var image1 = System.Drawing.Image.FromStream(new MemoryStream(staff.ImagePreview));
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
            using (var db = new IKContext())
            {
                Staff.LastName = txtLastName.Text;
                Staff.Email = txtEmail.Text;
                Staff.Post = txtPost.Text;
                Staff.FirstName = txtFirstName.Text;
                Staff.Login = txtLogin.Text;    
                Staff.Patronymic = txtPatronymic.Text;  
                Staff.Passport = txtPassport.Text;
                Staff.PhoneNumber = txtPhone.Text;
                Staff.TypeUser = (TypeUser)cmbTypeUser.SelectedIndex;
                Staff.Password = txtPassword.Text;
                Staff.ImagePreview = image;
                DialogResult = DialogResult.OK;
            }
        }

        private void cmbTypeUser_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTypeUser.Text == "Member")
            {
                label10.Visible = label9.Visible = txtLogin.Visible = txtPassword.Visible  = false;
                txtLogin.Text = txtPassword.Text = string.Empty;
            }
            else
            label10.Visible = label9.Visible = txtLogin.Visible = txtPassword.Visible = true;
            if (cmbTypeUser.Text == "Member")
            btnSaveChanges.Enabled = !string.IsNullOrWhiteSpace(txtLastName.Text) && !string.IsNullOrWhiteSpace(txtFirstName.Text) && !string.IsNullOrWhiteSpace(txtPassport.Text) && !string.IsNullOrWhiteSpace(txtPassport.Text) && !string.IsNullOrWhiteSpace(txtPhone.Text) && cmbTypeUser.SelectedIndex != -1;
            else
            btnSaveChanges.Enabled = !string.IsNullOrWhiteSpace(txtLastName.Text) && !string.IsNullOrWhiteSpace(txtFirstName.Text) && !string.IsNullOrWhiteSpace(txtPassport.Text) && !string.IsNullOrWhiteSpace(txtPassport.Text) && !string.IsNullOrWhiteSpace(txtPhone.Text) && !string.IsNullOrWhiteSpace(txtLogin.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text) && IsValidPassword(txtPassword.Text) && txtPassword.TextLength >= 6 && cmbTypeUser.SelectedIndex != -1;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if(cmbTypeUser.Text == "Member")
            btnSaveChanges.Enabled = !string.IsNullOrWhiteSpace(txtLastName.Text) && !string.IsNullOrWhiteSpace(txtFirstName.Text) && !string.IsNullOrWhiteSpace(txtPassport.Text) && !string.IsNullOrWhiteSpace(txtPassport.Text) && !string.IsNullOrWhiteSpace(txtPhone.Text) && cmbTypeUser.SelectedIndex != -1;
            else
            btnSaveChanges.Enabled = !string.IsNullOrWhiteSpace(txtLastName.Text) && !string.IsNullOrWhiteSpace(txtFirstName.Text) && !string.IsNullOrWhiteSpace(txtPassport.Text) && !string.IsNullOrWhiteSpace(txtPassport.Text) && !string.IsNullOrWhiteSpace(txtPhone.Text) && !string.IsNullOrWhiteSpace(txtLogin.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text) && IsValidPassword(txtPassword.Text) && txtPassword.TextLength >= 6 && cmbTypeUser.SelectedIndex != -1;
        }
        static bool IsLetter(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }

        static bool IsDigit(char c)
        {
            return c >= '0' && c <= '9';
        }

        static bool IsSymbol(char c)
        {
            return c > 32 && c < 127 && !IsDigit(c) && !IsLetter(c);
        }

        static bool IsValidPassword(string password)
        {
            return
               password.Any(c => IsLetter(c)) &&
               password.Any(c => IsDigit(c)) &&
               password.Any(c => IsSymbol(c));
        }

        private void txtPassword_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(txtPassword, "Требования к паролю:\n- 6 и более символов\n- одна или более латинских букв\n- одна или более цифра");
        }
    }
}
