namespace IdealKarkas.WinForms.Forms
{
    partial class FormObjectModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormObjectModel));
            this.btnLoadPhoto = new System.Windows.Forms.Button();
            this.btnDeletePhoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.cmbTypeObject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMinPeriod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numFloor = new System.Windows.Forms.NumericUpDown();
            this.numBedRoom = new System.Windows.Forms.NumericUpDown();
            this.numBathRoom = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBedRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBathRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadPhoto
            // 
            this.btnLoadPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.btnLoadPhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(113)))), ((int)(((byte)(235)))));
            this.btnLoadPhoto.FlatAppearance.BorderSize = 0;
            this.btnLoadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPhoto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadPhoto.ForeColor = System.Drawing.Color.White;
            this.btnLoadPhoto.Location = new System.Drawing.Point(48, 246);
            this.btnLoadPhoto.Name = "btnLoadPhoto";
            this.btnLoadPhoto.Size = new System.Drawing.Size(160, 35);
            this.btnLoadPhoto.TabIndex = 11;
            this.btnLoadPhoto.Text = "Загрузить фото";
            this.btnLoadPhoto.UseVisualStyleBackColor = false;
            this.btnLoadPhoto.Click += new System.EventHandler(this.btnLoadPhoto_Click);
            // 
            // btnDeletePhoto
            // 
            this.btnDeletePhoto.BackColor = System.Drawing.Color.Silver;
            this.btnDeletePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePhoto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeletePhoto.ForeColor = System.Drawing.Color.White;
            this.btnDeletePhoto.Location = new System.Drawing.Point(75, 285);
            this.btnDeletePhoto.Name = "btnDeletePhoto";
            this.btnDeletePhoto.Size = new System.Drawing.Size(100, 30);
            this.btnDeletePhoto.TabIndex = 2;
            this.btnDeletePhoto.Text = "Удалить";
            this.btnDeletePhoto.UseVisualStyleBackColor = false;
            this.btnDeletePhoto.Click += new System.EventHandler(this.btnDeletePhoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(263, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTitle.Location = new System.Drawing.Point(339, 46);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(347, 23);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(263, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtArea.Location = new System.Drawing.Point(365, 140);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(95, 23);
            this.txtArea.TabIndex = 3;
            this.txtArea.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            this.txtArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArea_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(263, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Площадь";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDesc.Location = new System.Drawing.Point(365, 292);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(321, 102);
            this.txtDesc.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(263, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Особенности";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(113)))), ((int)(((byte)(235)))));
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(494, 405);
            this.btnSaveChanges.MaximumSize = new System.Drawing.Size(392, 35);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(192, 35);
            this.btnSaveChanges.TabIndex = 12;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(44, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 30);
            this.label11.TabIndex = 25;
            this.label11.Text = "Проект";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(48, 79);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(160, 160);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // cmbTypeObject
            // 
            this.cmbTypeObject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTypeObject.FormattingEnabled = true;
            this.cmbTypeObject.Location = new System.Drawing.Point(339, 93);
            this.cmbTypeObject.Name = "cmbTypeObject";
            this.cmbTypeObject.Size = new System.Drawing.Size(347, 23);
            this.cmbTypeObject.TabIndex = 37;
            this.cmbTypeObject.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(476, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Этажность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(476, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Кол-во санузлов";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(263, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Кол-во спален";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice.Location = new System.Drawing.Point(521, 234);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(165, 23);
            this.txtPrice.TabIndex = 46;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArea_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(476, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Цена";
            // 
            // txtMinPeriod
            // 
            this.txtMinPeriod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMinPeriod.Location = new System.Drawing.Point(365, 233);
            this.txtMinPeriod.Name = "txtMinPeriod";
            this.txtMinPeriod.Size = new System.Drawing.Size(95, 23);
            this.txtMinPeriod.TabIndex = 44;
            this.txtMinPeriod.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            this.txtMinPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinPeriod_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(263, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 34);
            this.label9.TabIndex = 45;
            this.label9.Text = "Мин. период\r\nпостройки";
            // 
            // numFloor
            // 
            this.numFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numFloor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numFloor.Location = new System.Drawing.Point(592, 141);
            this.numFloor.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numFloor.Name = "numFloor";
            this.numFloor.ReadOnly = true;
            this.numFloor.Size = new System.Drawing.Size(94, 23);
            this.numFloor.TabIndex = 48;
            this.numFloor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numBedRoom
            // 
            this.numBedRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numBedRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numBedRoom.Location = new System.Drawing.Point(365, 192);
            this.numBedRoom.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numBedRoom.Name = "numBedRoom";
            this.numBedRoom.ReadOnly = true;
            this.numBedRoom.Size = new System.Drawing.Size(94, 23);
            this.numBedRoom.TabIndex = 49;
            this.numBedRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numBathRoom
            // 
            this.numBathRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numBathRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numBathRoom.Location = new System.Drawing.Point(591, 192);
            this.numBathRoom.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numBathRoom.Name = "numBathRoom";
            this.numBathRoom.ReadOnly = true;
            this.numBathRoom.Size = new System.Drawing.Size(94, 23);
            this.numBathRoom.TabIndex = 50;
            this.numBathRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormObjectModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 447);
            this.Controls.Add(this.numBathRoom);
            this.Controls.Add(this.numBedRoom);
            this.Controls.Add(this.numFloor);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMinPeriod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTypeObject);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletePhoto);
            this.Controls.Add(this.btnLoadPhoto);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormObjectModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IdealKarkas";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBedRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBathRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnLoadPhoto;
        private System.Windows.Forms.Button btnDeletePhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbTypeObject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMinPeriod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numFloor;
        private System.Windows.Forms.NumericUpDown numBedRoom;
        private System.Windows.Forms.NumericUpDown numBathRoom;
    }
}