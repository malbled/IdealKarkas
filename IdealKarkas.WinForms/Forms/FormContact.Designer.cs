namespace IdealKarkas.WinForms.Forms
{
    partial class FormContact
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripContact = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtFIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelAllCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.contextMenuStripContact.SuspendLayout();
            this.groupBoxMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(3, -5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaff.BackgroundColor = System.Drawing.Color.White;
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
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvStaff.ContextMenuStrip = this.contextMenuStripContact;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(113)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaff.EnableHeadersVisualStyles = false;
            this.dgvStaff.Location = new System.Drawing.Point(12, 139);
            this.dgvStaff.MultiSelect = false;
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(680, 433);
            this.dgvStaff.TabIndex = 28;
            this.dgvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellContentClick);
            this.dgvStaff.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStaff_CellFormatting);
            this.dgvStaff.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStaff_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Сотрудник";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Email";
            this.Column2.HeaderText = "Email";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Post";
            this.Column3.HeaderText = "Должность";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "PhoneNumber";
            this.Column4.HeaderText = "Телефон";
            this.Column4.MinimumWidth = 100;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // contextMenuStripContact
            // 
            this.contextMenuStripContact.BackColor = System.Drawing.Color.White;
            this.contextMenuStripContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStripContact.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПользователяToolStripMenuItem,
            this.редактироватьИнформациюToolStripMenuItem,
            this.удалитьПользователяToolStripMenuItem});
            this.contextMenuStripContact.Name = "contextMenuStripContact";
            this.contextMenuStripContact.Size = new System.Drawing.Size(249, 70);
            // 
            // добавитьПользователяToolStripMenuItem
            // 
            this.добавитьПользователяToolStripMenuItem.Image = global::IdealKarkas.WinForms.Properties.Resources.icon_add;
            this.добавитьПользователяToolStripMenuItem.Name = "добавитьПользователяToolStripMenuItem";
            this.добавитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.добавитьПользователяToolStripMenuItem.Text = "Добавить пользователя";
            this.добавитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.добавитьПользователяToolStripMenuItem_Click);
            // 
            // редактироватьИнформациюToolStripMenuItem
            // 
            this.редактироватьИнформациюToolStripMenuItem.Image = global::IdealKarkas.WinForms.Properties.Resources.icon_edit;
            this.редактироватьИнформациюToolStripMenuItem.Name = "редактироватьИнформациюToolStripMenuItem";
            this.редактироватьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.редактироватьИнформациюToolStripMenuItem.Text = "Редактировать информацию";
            this.редактироватьИнформациюToolStripMenuItem.Click += new System.EventHandler(this.редактироватьИнформациюToolStripMenuItem_Click);
            // 
            // удалитьПользователяToolStripMenuItem
            // 
            this.удалитьПользователяToolStripMenuItem.Image = global::IdealKarkas.WinForms.Properties.Resources.icon_delete;
            this.удалитьПользователяToolStripMenuItem.Name = "удалитьПользователяToolStripMenuItem";
            this.удалитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.удалитьПользователяToolStripMenuItem.Text = "Удалить пользователя";
            this.удалитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.удалитьПользователяToolStripMenuItem_Click);
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMain.Controls.Add(this.btnClean);
            this.groupBoxMain.Controls.Add(this.txtFIO);
            this.groupBoxMain.Controls.Add(this.label1);
            this.groupBoxMain.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxMain.Location = new System.Drawing.Point(12, 60);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(680, 75);
            this.groupBoxMain.TabIndex = 34;
            this.groupBoxMain.TabStop = false;
            // 
            // btnClean
            // 
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClean.BackColor = System.Drawing.Color.White;
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClean.ForeColor = System.Drawing.Color.Black;
            this.btnClean.Location = new System.Drawing.Point(654, 45);
            this.btnClean.Margin = new System.Windows.Forms.Padding(0);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(21, 22);
            this.btnClean.TabIndex = 35;
            this.btnClean.Text = "✕";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // txtFIO
            // 
            this.txtFIO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFIO.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFIO.Location = new System.Drawing.Point(6, 47);
            this.txtFIO.Name = "txtFIO";
            this.txtFIO.Size = new System.Drawing.Size(645, 22);
            this.txtFIO.TabIndex = 4;
            this.txtFIO.TextChanged += new System.EventHandler(this.txtFIO_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по фамилии";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelAllCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 575);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(698, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 42;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelAllCount
            // 
            this.labelAllCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.labelAllCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAllCount.ForeColor = System.Drawing.Color.White;
            this.labelAllCount.Name = "labelAllCount";
            this.labelAllCount.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.labelAllCount.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.labelAllCount.Size = new System.Drawing.Size(157, 17);
            this.labelAllCount.Text = "Количество записей : 0";
            // 
            // FormContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 597);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormContact";
            this.Text = "FormContact";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.contextMenuStripContact.ResumeLayout(false);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFIO;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripContact;
        private System.Windows.Forms.ToolStripMenuItem добавитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПользователяToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelAllCount;
    }
}