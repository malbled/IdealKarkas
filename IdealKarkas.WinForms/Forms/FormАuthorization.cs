using IdealKarkas.Context;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IdealKarkas.WinForms.Forms
{
    public partial class FormАuthorization : Form
    {
        public FormАuthorization()
        {
            InitializeComponent();
            txtLogin.Text = "Введите логин";
            txtLogin.ForeColor = Color.Gray;
            txtPassword.Text = "Введите пароль";
            txtPassword.ForeColor = Color.Gray;
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                txtLogin.Text = "Введите логин";
                txtLogin.ForeColor = Color.Gray;
            }
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Введите логин")
            {
                txtLogin.Clear();
                txtLogin.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Введите пароль")
            {
                txtPassword.Clear();
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Введите пароль";
                txtPassword.ForeColor = Color.Gray;
                checkBoxPassword.Checked = false;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private Point MouseHook;
        private void FormАuthorization_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var context = new IKContext();
            //var list = context.Staffs.ToList();

                var user = context.Staffs.ToList().FirstOrDefault(x => x.Login == txtLogin.Text && SecurePasswordHasher.Verify(txtPassword.Text.ToString(), x.Password));
                if (user == null || user.IsActual != null)
                    MessageBox.Show("Пользователь не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    WorkToUser.Staff = user;
                    var form = new FormMenu();
                    form.Show();
                    this.Hide();
                }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            btnEnter.Enabled = !string.IsNullOrWhiteSpace(txtLogin.Text)
                && txtLogin.ForeColor != Color.Gray 
                && !string.IsNullOrWhiteSpace(txtPassword.Text)
                && txtPassword.ForeColor != Color.Gray;
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked == true && txtPassword.ForeColor == Color.Black)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else if (checkBoxPassword.Checked == false && txtPassword.ForeColor == Color.Black)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
