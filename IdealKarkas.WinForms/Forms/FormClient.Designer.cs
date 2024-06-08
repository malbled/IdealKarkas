namespace IdealKarkas.WinForms.Forms
{
    partial class FormClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripHardWare = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выбратьКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelAllCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.contextMenuStripHardWare.SuspendLayout();
            this.groupBoxMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClient.BackgroundColor = System.Drawing.Color.White;
            this.dgvClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvClient.ContextMenuStrip = this.contextMenuStripHardWare;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(113)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClient.EnableHeadersVisualStyles = false;
            this.dgvClient.Location = new System.Drawing.Point(12, 93);
            this.dgvClient.MultiSelect = false;
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(680, 479);
            this.dgvClient.TabIndex = 29;
            this.dgvClient.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvClient_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ФИО";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Id";
            this.Column2.HeaderText = "Email + телефон";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "TypeClient";
            this.Column3.HeaderText = "Тип клиента";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Id";
            this.Column4.HeaderText = "Название + ИНН (Город)";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // contextMenuStripHardWare
            // 
            this.contextMenuStripHardWare.BackColor = System.Drawing.Color.White;
            this.contextMenuStripHardWare.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStripHardWare.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьКлиентаToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.contextMenuStripHardWare.Name = "contextMenuStripContact";
            this.contextMenuStripHardWare.Size = new System.Drawing.Size(249, 70);
            // 
            // выбратьКлиентаToolStripMenuItem
            // 
            this.выбратьКлиентаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выбратьКлиентаToolStripMenuItem.Image = global::IdealKarkas.WinForms.Properties.Resources.free_icon_yes_9426997;
            this.выбратьКлиентаToolStripMenuItem.Name = "выбратьКлиентаToolStripMenuItem";
            this.выбратьКлиентаToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.выбратьКлиентаToolStripMenuItem.Text = "Выбрать клиента";
            this.выбратьКлиентаToolStripMenuItem.Click += new System.EventHandler(this.выбратьКлиентаToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Image = global::IdealKarkas.WinForms.Properties.Resources.icon_add;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить клиента";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Image = global::IdealKarkas.WinForms.Properties.Resources.icon_edit;
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать информацию";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMain.Controls.Add(this.btnClean);
            this.groupBoxMain.Controls.Add(this.txtSearch);
            this.groupBoxMain.Controls.Add(this.label1);
            this.groupBoxMain.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxMain.Location = new System.Drawing.Point(12, 14);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(680, 75);
            this.groupBoxMain.TabIndex = 38;
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
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(6, 47);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(645, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по Фамилии";
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
            this.statusStrip1.TabIndex = 41;
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
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 597);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.dgvClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(714, 636);
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IdealKarkas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.contextMenuStripHardWare.ResumeLayout(false);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripHardWare;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripMenuItem выбратьКлиентаToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelAllCount;
    }
}