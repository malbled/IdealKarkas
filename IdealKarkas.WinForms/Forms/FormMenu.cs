using System;
using System.Windows.Forms;

namespace IdealKarkas.WinForms.Forms
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        { 
            InitializeComponent();
            customizeDesign();
        }
        public void customizeDesign()
        {
            panelSubMenuProject.Visible = false;
            panelSubMenuDB.Visible = false;
        }
        public void hideSubMenu()
        {
            if(panelSubMenuProject.Visible == true)
                panelSubMenuProject.Visible = false;
            if(panelSubMenuDB.Visible == true)
                    panelSubMenuDB.Visible = false;
        }
        public void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuDB);
          
        }

        private void btnDBHardware_Click(object sender, EventArgs e)
        {
            //code
            hideSubMenu();
            openChildForm(new FormHardware());
        }

        private void btnDBObject_Click(object sender, EventArgs e)
        {
            //code
            hideSubMenu();
            openChildForm(new FormObject());
        }

        private void btnBDOrder_Click(object sender, EventArgs e)
        {
            //code
            openChildForm(new FormOrders());
            //Form.ActiveForm.WindowState = FormWindowState.Maximized;
            hideSubMenu();
        }

        private void btnDBProject_Click(object sender, EventArgs e)
        {
            //code
            hideSubMenu();
            if(WorkToUser.Staff.TypeUser == Context.Enums.TypeUser.Admin || WorkToUser.Staff.TypeUser == Context.Enums.TypeUser.Root)
            {
                openChildForm(new FormTreeViewProject());
            }
            else
            {
                MessageBox.Show("Вы должны обладать правами ROOT или ADMIN, для просмотра информации о проектах", "IdealKarkas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //code
            hideSubMenu();
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuProject);
         
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            //code
            var form = new FormNewOrder();
            form.Show();
            hideSubMenu();
        }

        public void btnDBStaff_Click_1(object sender, EventArgs e)
        {
            //code
            openChildForm(new FormContact());
            hideSubMenu();
            
        }
        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }      
    }
}
