namespace IdealKarkas.WinForms.Forms
{
    partial class FormAddTask
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddTask));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxStaff = new System.Windows.Forms.ListBox();
            this.listBoxHardware = new System.Windows.Forms.ListBox();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.txtHardware = new System.Windows.Forms.TextBox();
            this.btnSearchHarware = new System.Windows.Forms.Button();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHardware = new System.Windows.Forms.DataGridView();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHardware)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitle.Location = new System.Drawing.Point(83, 93);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(354, 70);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDesc.Location = new System.Drawing.Point(470, 371);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(408, 198);
            this.txtDesc.TabIndex = 33;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(467, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Описание";
            // 
            // listBoxStaff
            // 
            this.listBoxStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listBoxStaff.FormattingEnabled = true;
            this.listBoxStaff.ItemHeight = 15;
            this.listBoxStaff.Location = new System.Drawing.Point(12, 235);
            this.listBoxStaff.Name = "listBoxStaff";
            this.listBoxStaff.Size = new System.Drawing.Size(198, 334);
            this.listBoxStaff.TabIndex = 35;
            // 
            // listBoxHardware
            // 
            this.listBoxHardware.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listBoxHardware.FormattingEnabled = true;
            this.listBoxHardware.ItemHeight = 15;
            this.listBoxHardware.Location = new System.Drawing.Point(239, 235);
            this.listBoxHardware.Name = "listBoxHardware";
            this.listBoxHardware.Size = new System.Drawing.Size(198, 334);
            this.listBoxHardware.TabIndex = 36;
            // 
            // txtStaff
            // 
            this.txtStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStaff.Location = new System.Drawing.Point(470, 12);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(377, 23);
            this.txtStaff.TabIndex = 37;
            this.txtStaff.Enter += new System.EventHandler(this.txtStaff_Enter);
            this.txtStaff.Leave += new System.EventHandler(this.txtStaff_Leave);
            // 
            // txtHardware
            // 
            this.txtHardware.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHardware.Location = new System.Drawing.Point(470, 180);
            this.txtHardware.Name = "txtHardware";
            this.txtHardware.Size = new System.Drawing.Size(377, 23);
            this.txtHardware.TabIndex = 39;
            this.txtHardware.Enter += new System.EventHandler(this.txtHardware_Enter);
            this.txtHardware.Leave += new System.EventHandler(this.txtHardware_Leave);
            // 
            // btnSearchHarware
            // 
            this.btnSearchHarware.FlatAppearance.BorderSize = 0;
            this.btnSearchHarware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchHarware.Image = global::IdealKarkas.WinForms.Properties.Resources.icon_search__2_;
            this.btnSearchHarware.Location = new System.Drawing.Point(850, 179);
            this.btnSearchHarware.Name = "btnSearchHarware";
            this.btnSearchHarware.Size = new System.Drawing.Size(25, 23);
            this.btnSearchHarware.TabIndex = 41;
            this.btnSearchHarware.UseVisualStyleBackColor = true;
            this.btnSearchHarware.Click += new System.EventHandler(this.btnSearchHarware_Click);
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.FlatAppearance.BorderSize = 0;
            this.btnSearchStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStaff.Image = global::IdealKarkas.WinForms.Properties.Resources.icon_search__2_;
            this.btnSearchStaff.Location = new System.Drawing.Point(850, 12);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(25, 23);
            this.btnSearchStaff.TabIndex = 40;
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.ColumnHeadersVisible = false;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(113)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaff.EnableHeadersVisualStyles = false;
            this.dgvStaff.Location = new System.Drawing.Point(470, 42);
            this.dgvStaff.MultiSelect = false;
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(377, 121);
            this.dgvStaff.TabIndex = 42;
            this.dgvStaff.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStaff_CellFormatting);
            this.dgvStaff.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClient_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ФИО";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dgvHardware
            // 
            this.dgvHardware.AllowUserToAddRows = false;
            this.dgvHardware.AllowUserToDeleteRows = false;
            this.dgvHardware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHardware.BackgroundColor = System.Drawing.Color.White;
            this.dgvHardware.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHardware.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHardware.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHardware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHardware.ColumnHeadersVisible = false;
            this.dgvHardware.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(113)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHardware.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHardware.EnableHeadersVisualStyles = false;
            this.dgvHardware.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHardware.Location = new System.Drawing.Point(470, 215);
            this.dgvHardware.MultiSelect = false;
            this.dgvHardware.Name = "dgvHardware";
            this.dgvHardware.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHardware.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHardware.RowHeadersVisible = false;
            this.dgvHardware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHardware.Size = new System.Drawing.Size(377, 121);
            this.dgvHardware.TabIndex = 43;
            this.dgvHardware.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
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
            this.btnSaveChanges.Location = new System.Drawing.Point(683, 585);
            this.btnSaveChanges.MaximumSize = new System.Drawing.Size(392, 35);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(192, 35);
            this.btnSaveChanges.TabIndex = 44;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Работники";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(236, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Оборудование";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(7, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 30);
            this.label11.TabIndex = 47;
            this.label11.Text = "Создание задачи";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Title";
            this.Column2.HeaderText = "Id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SerialNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FormAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(887, 632);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.dgvHardware);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.btnSearchHarware);
            this.Controls.Add(this.btnSearchStaff);
            this.Controls.Add(this.txtHardware);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.listBoxHardware);
            this.Controls.Add(this.listBoxStaff);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IdealKarkas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHardware)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxStaff;
        private System.Windows.Forms.ListBox listBoxHardware;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.TextBox txtHardware;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.Button btnSearchHarware;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvHardware;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}