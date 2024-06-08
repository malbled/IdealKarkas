namespace IdealKarkas.WinForms.Forms
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDBStaff = new System.Windows.Forms.Button();
            this.panelSubMenuProject = new System.Windows.Forms.Panel();
            this.btnDBProject = new System.Windows.Forms.Button();
            this.btnProject = new System.Windows.Forms.Button();
            this.panelSubMenuDB = new System.Windows.Forms.Panel();
            this.btnBDOrder = new System.Windows.Forms.Button();
            this.btnDBObject = new System.Windows.Forms.Button();
            this.btnDBHardware = new System.Windows.Forms.Button();
            this.btnBD = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelSubMenuProject.SuspendLayout();
            this.panelSubMenuDB.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(85)))), ((int)(((byte)(102)))));
            this.panelMenu.Controls.Add(this.btnDBStaff);
            this.panelMenu.Controls.Add(this.panelSubMenuProject);
            this.panelMenu.Controls.Add(this.btnProject);
            this.panelMenu.Controls.Add(this.panelSubMenuDB);
            this.panelMenu.Controls.Add(this.btnBD);
            this.panelMenu.Controls.Add(this.btnAddOrder);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 597);
            this.panelMenu.TabIndex = 0;
            // 
            // btnDBStaff
            // 
            this.btnDBStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDBStaff.FlatAppearance.BorderSize = 0;
            this.btnDBStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(113)))), ((int)(((byte)(235)))));
            this.btnDBStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDBStaff.ForeColor = System.Drawing.Color.White;
            this.btnDBStaff.Location = new System.Drawing.Point(0, 375);
            this.btnDBStaff.Name = "btnDBStaff";
            this.btnDBStaff.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDBStaff.Size = new System.Drawing.Size(220, 45);
            this.btnDBStaff.TabIndex = 11;
            this.btnDBStaff.Text = "Команда";
            this.btnDBStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDBStaff.UseVisualStyleBackColor = true;
            this.btnDBStaff.Click += new System.EventHandler(this.btnDBStaff_Click_1);
            // 
            // panelSubMenuProject
            // 
            this.panelSubMenuProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(122)))), ((int)(((byte)(146)))));
            this.panelSubMenuProject.Controls.Add(this.btnDBProject);
            this.panelSubMenuProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuProject.Location = new System.Drawing.Point(0, 335);
            this.panelSubMenuProject.Name = "panelSubMenuProject";
            this.panelSubMenuProject.Size = new System.Drawing.Size(220, 40);
            this.panelSubMenuProject.TabIndex = 9;
            // 
            // btnDBProject
            // 
            this.btnDBProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDBProject.FlatAppearance.BorderSize = 0;
            this.btnDBProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBProject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDBProject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDBProject.Location = new System.Drawing.Point(0, 0);
            this.btnDBProject.Name = "btnDBProject";
            this.btnDBProject.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDBProject.Size = new System.Drawing.Size(220, 40);
            this.btnDBProject.TabIndex = 0;
            this.btnDBProject.Text = "Дерево проектов";
            this.btnDBProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDBProject.UseVisualStyleBackColor = true;
            this.btnDBProject.Click += new System.EventHandler(this.btnDBProject_Click);
            // 
            // btnProject
            // 
            this.btnProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProject.FlatAppearance.BorderSize = 0;
            this.btnProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(113)))), ((int)(((byte)(235)))));
            this.btnProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProject.ForeColor = System.Drawing.Color.White;
            this.btnProject.Location = new System.Drawing.Point(0, 290);
            this.btnProject.Name = "btnProject";
            this.btnProject.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProject.Size = new System.Drawing.Size(220, 45);
            this.btnProject.TabIndex = 8;
            this.btnProject.Text = "Проекты";
            this.btnProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // panelSubMenuDB
            // 
            this.panelSubMenuDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(122)))), ((int)(((byte)(146)))));
            this.panelSubMenuDB.Controls.Add(this.btnBDOrder);
            this.panelSubMenuDB.Controls.Add(this.btnDBObject);
            this.panelSubMenuDB.Controls.Add(this.btnDBHardware);
            this.panelSubMenuDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuDB.Location = new System.Drawing.Point(0, 170);
            this.panelSubMenuDB.Name = "panelSubMenuDB";
            this.panelSubMenuDB.Size = new System.Drawing.Size(220, 120);
            this.panelSubMenuDB.TabIndex = 7;
            // 
            // btnBDOrder
            // 
            this.btnBDOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBDOrder.FlatAppearance.BorderSize = 0;
            this.btnBDOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBDOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBDOrder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBDOrder.Location = new System.Drawing.Point(0, 80);
            this.btnBDOrder.Name = "btnBDOrder";
            this.btnBDOrder.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBDOrder.Size = new System.Drawing.Size(220, 40);
            this.btnBDOrder.TabIndex = 2;
            this.btnBDOrder.Text = "База заказов";
            this.btnBDOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBDOrder.UseVisualStyleBackColor = true;
            this.btnBDOrder.Click += new System.EventHandler(this.btnBDOrder_Click);
            // 
            // btnDBObject
            // 
            this.btnDBObject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDBObject.FlatAppearance.BorderSize = 0;
            this.btnDBObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBObject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDBObject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDBObject.Location = new System.Drawing.Point(0, 40);
            this.btnDBObject.Name = "btnDBObject";
            this.btnDBObject.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDBObject.Size = new System.Drawing.Size(220, 40);
            this.btnDBObject.TabIndex = 1;
            this.btnDBObject.Text = "База объектов";
            this.btnDBObject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDBObject.UseVisualStyleBackColor = true;
            this.btnDBObject.Click += new System.EventHandler(this.btnDBObject_Click);
            // 
            // btnDBHardware
            // 
            this.btnDBHardware.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDBHardware.FlatAppearance.BorderSize = 0;
            this.btnDBHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBHardware.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDBHardware.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDBHardware.Location = new System.Drawing.Point(0, 0);
            this.btnDBHardware.Name = "btnDBHardware";
            this.btnDBHardware.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDBHardware.Size = new System.Drawing.Size(220, 40);
            this.btnDBHardware.TabIndex = 0;
            this.btnDBHardware.Text = "База оборудования";
            this.btnDBHardware.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDBHardware.UseVisualStyleBackColor = true;
            this.btnDBHardware.Click += new System.EventHandler(this.btnDBHardware_Click);
            // 
            // btnBD
            // 
            this.btnBD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBD.FlatAppearance.BorderSize = 0;
            this.btnBD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(113)))), ((int)(((byte)(235)))));
            this.btnBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBD.ForeColor = System.Drawing.Color.White;
            this.btnBD.Location = new System.Drawing.Point(0, 125);
            this.btnBD.Name = "btnBD";
            this.btnBD.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBD.Size = new System.Drawing.Size(220, 45);
            this.btnBD.TabIndex = 6;
            this.btnBD.Text = "Хранилище информации";
            this.btnBD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddOrder.FlatAppearance.BorderSize = 0;
            this.btnAddOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(113)))), ((int)(((byte)(235)))));
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Location = new System.Drawing.Point(0, 80);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAddOrder.Size = new System.Drawing.Size(220, 45);
            this.btnAddOrder.TabIndex = 1;
            this.btnAddOrder.Text = "Регистрация заказа";
            this.btnAddOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(113)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(68, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "IdealKarkas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::IdealKarkas.WinForms.Properties.Resources.image2__1_;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(113)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(164, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 86);
            this.label1.TabIndex = 2;
            this.label1.Text = "IdealKarkas";
            // 
            // panelForm
            // 
            this.panelForm.AutoScroll = true;
            this.panelForm.AutoScrollMargin = new System.Drawing.Size(1000, 0);
            this.panelForm.AutoSize = true;
            this.panelForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelForm.Controls.Add(this.pictureBox1);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(220, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(698, 597);
            this.panelForm.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::IdealKarkas.WinForms.Properties.Resources.image2__1_;
            this.pictureBox1.Location = new System.Drawing.Point(244, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 597);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(934, 636);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IdealKarkas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenuProject.ResumeLayout(false);
            this.panelSubMenuDB.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSubMenuProject;
        private System.Windows.Forms.Button btnDBProject;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Panel panelSubMenuDB;
        private System.Windows.Forms.Button btnBDOrder;
        private System.Windows.Forms.Button btnDBObject;
        private System.Windows.Forms.Button btnDBHardware;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelForm;
        public System.Windows.Forms.Button btnDBStaff;
    }
}