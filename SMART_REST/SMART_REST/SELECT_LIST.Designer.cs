namespace SMART_REST
{
    partial class SELECT_LIST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SELECT_LIST));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.labelNo = new System.Windows.Forms.Label();
            this.selectList = new System.Windows.Forms.DataGridView();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.searchh = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelWhite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.delete);
            this.panelMain.Controls.Add(this.add);
            this.panelMain.Controls.Add(this.buttonSearch);
            this.panelMain.Controls.Add(this.edit);
            this.panelMain.Controls.Add(this.update);
            this.panelMain.Controls.Add(this.save);
            this.panelMain.Controls.Add(this.panelWhite);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(942, 503);
            this.panelMain.TabIndex = 63;
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.AutoSize = true;
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft JhengHei", 8F);
            this.delete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.delete.Location = new System.Drawing.Point(782, 242);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(148, 30);
            this.delete.TabIndex = 56;
            this.delete.Text = "У Д А Л И Т Ь";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add.AutoSize = true;
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft JhengHei", 8F);
            this.add.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.add.Location = new System.Drawing.Point(782, 292);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(148, 30);
            this.add.TabIndex = 61;
            this.add.Text = "Д О Б А В И Т Ь";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft JhengHei", 8F);
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSearch.Location = new System.Drawing.Point(782, 38);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(148, 30);
            this.buttonSearch.TabIndex = 64;
            this.buttonSearch.Text = "П О И С К";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit
            // 
            this.edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edit.AutoSize = true;
            this.edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit.BackgroundImage")));
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Microsoft JhengHei", 8F);
            this.edit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.edit.Location = new System.Drawing.Point(782, 347);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(148, 30);
            this.edit.TabIndex = 57;
            this.edit.Text = "И З М Е Н И Т Ь";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // update
            // 
            this.update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.update.AutoSize = true;
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft JhengHei", 8F);
            this.update.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.update.Location = new System.Drawing.Point(782, 393);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(148, 30);
            this.update.TabIndex = 59;
            this.update.Text = "О Б Н О В И Т Ь";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxsearch.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxsearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxsearch.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.textBoxsearch.Location = new System.Drawing.Point(311, 12);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(407, 27);
            this.textBoxsearch.TabIndex = 62;
            this.textBoxsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.AutoSize = true;
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft JhengHei", 8F);
            this.save.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.save.Location = new System.Drawing.Point(782, 447);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(148, 30);
            this.save.TabIndex = 60;
            this.save.Text = "С О Х Р А Н И Т Ь";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxItem.Font = new System.Drawing.Font("Microsoft YaHei", 7.5F);
            this.comboBoxItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.comboBoxItem.Location = new System.Drawing.Point(133, 14);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(172, 25);
            this.comboBoxItem.TabIndex = 63;
            // 
            // panelWhite
            // 
            this.panelWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWhite.BackColor = System.Drawing.SystemColors.Window;
            this.panelWhite.Controls.Add(this.labelNo);
            this.panelWhite.Controls.Add(this.selectList);
            this.panelWhite.Controls.Add(this.labelSearch);
            this.panelWhite.Controls.Add(this.comboBoxItem);
            this.panelWhite.Controls.Add(this.textBoxsearch);
            this.panelWhite.Controls.Add(this.comboBoxSearch);
            this.panelWhite.Controls.Add(this.searchh);
            this.panelWhite.Location = new System.Drawing.Point(32, 29);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(735, 449);
            this.panelWhite.TabIndex = 66;
            // 
            // labelNo
            // 
            this.labelNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNo.AutoSize = true;
            this.labelNo.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelNo.Location = new System.Drawing.Point(239, 213);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(266, 22);
            this.labelNo.TabIndex = 68;
            this.labelNo.Text = "Н И Ч Е Г О   Н Е   Н А Й Д Е Н О";
            this.labelNo.Visible = false;
            // 
            // selectList
            // 
            this.selectList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selectList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.selectList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.selectList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.selectList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.selectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.selectList.DefaultCellStyle = dataGridViewCellStyle5;
            this.selectList.EnableHeadersVisualStyles = false;
            this.selectList.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectList.Location = new System.Drawing.Point(18, 55);
            this.selectList.Name = "selectList";
            this.selectList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.selectList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.selectList.RowHeadersVisible = false;
            this.selectList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.selectList.Size = new System.Drawing.Size(700, 371);
            this.selectList.TabIndex = 2;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearch.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxSearch.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.comboBoxSearch.Location = new System.Drawing.Point(274, 12);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(444, 27);
            this.comboBoxSearch.TabIndex = 67;
            this.comboBoxSearch.Visible = false;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSearch.Location = new System.Drawing.Point(14, 17);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(97, 22);
            this.labelSearch.TabIndex = 65;
            this.labelSearch.Text = "И С К А Т Ь";
            // 
            // searchh
            // 
            this.searchh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchh.AutoSize = true;
            this.searchh.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchh.Location = new System.Drawing.Point(14, 17);
            this.searchh.Name = "searchh";
            this.searchh.Size = new System.Drawing.Size(218, 22);
            this.searchh.TabIndex = 67;
            this.searchh.Text = "С О Р Т И Р О В А Т  Ь  П О";
            this.searchh.Visible = false;
            // 
            // SELECT_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 503);
            this.Controls.Add(this.panelMain);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 550);
            this.Name = "SELECT_LIST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMART REST";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SELECT_LIST_FormClosed);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelWhite.ResumeLayout(false);
            this.panelWhite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView selectList;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label searchh;
        private System.Windows.Forms.Label labelNo;
    }
}