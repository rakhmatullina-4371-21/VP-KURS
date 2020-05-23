namespace SMART_REST
{
    partial class ORDER_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ORDER_ADD));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.white = new System.Windows.Forms.Panel();
            this.buttonSelOrd = new System.Windows.Forms.Button();
            this.comboSelection = new System.Windows.Forms.ComboBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelSelection = new System.Windows.Forms.Label();
            this.comboBoxCount = new System.Windows.Forms.ComboBox();
            this.labelTable = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.comboTable = new System.Windows.Forms.ComboBox();
            this.selectList = new System.Windows.Forms.DataGridView();
            this.form = new System.Windows.Forms.Panel();
            this.white.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectList)).BeginInit();
            this.SuspendLayout();
            // 
            // white
            // 
            this.white.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.white.BackColor = System.Drawing.SystemColors.Window;
            this.white.Controls.Add(this.buttonSelOrd);
            this.white.Controls.Add(this.comboSelection);
            this.white.Controls.Add(this.labelCount);
            this.white.Controls.Add(this.labelSelection);
            this.white.Controls.Add(this.comboBoxCount);
            this.white.Controls.Add(this.labelTable);
            this.white.Controls.Add(this.close);
            this.white.Controls.Add(this.save);
            this.white.Controls.Add(this.comboTable);
            this.white.Controls.Add(this.selectList);
            this.white.Location = new System.Drawing.Point(84, 19);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(775, 464);
            this.white.TabIndex = 65;
            // 
            // buttonSelOrd
            // 
            this.buttonSelOrd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSelOrd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSelOrd.BackgroundImage")));
            this.buttonSelOrd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSelOrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelOrd.Font = new System.Drawing.Font("Microsoft JhengHei", 7F);
            this.buttonSelOrd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSelOrd.Location = new System.Drawing.Point(305, 411);
            this.buttonSelOrd.Name = "buttonSelOrd";
            this.buttonSelOrd.Size = new System.Drawing.Size(173, 37);
            this.buttonSelOrd.TabIndex = 70;
            this.buttonSelOrd.Text = "З А К А З";
            this.buttonSelOrd.UseVisualStyleBackColor = true;
            this.buttonSelOrd.Visible = false;
            this.buttonSelOrd.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboSelection
            // 
            this.comboSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSelection.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboSelection.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboSelection.FormattingEnabled = true;
            this.comboSelection.Location = new System.Drawing.Point(259, 20);
            this.comboSelection.Name = "comboSelection";
            this.comboSelection.Size = new System.Drawing.Size(486, 27);
            this.comboSelection.TabIndex = 68;
            this.comboSelection.Visible = false;
            this.comboSelection.SelectedIndexChanged += new System.EventHandler(this.comboSelection_SelectedIndexChanged);
            this.comboSelection.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboSelection_MouseClick);
            // 
            // labelCount
            // 
            this.labelCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCount.Image = global::SMART_REST.Properties.Resources.Image_1;
            this.labelCount.Location = new System.Drawing.Point(271, 178);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(255, 20);
            this.labelCount.TabIndex = 66;
            this.labelCount.Text = "В Ы Б Е Р И Т Е   К О Л И Ч Е С Т В О";
            this.labelCount.Visible = false;
            // 
            // labelSelection
            // 
            this.labelSelection.AutoSize = true;
            this.labelSelection.BackColor = System.Drawing.SystemColors.Window;
            this.labelSelection.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.labelSelection.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSelection.Image = global::SMART_REST.Properties.Resources.Image_1;
            this.labelSelection.Location = new System.Drawing.Point(31, 21);
            this.labelSelection.Name = "labelSelection";
            this.labelSelection.Size = new System.Drawing.Size(210, 19);
            this.labelSelection.TabIndex = 8;
            this.labelSelection.Text = "В Ы Б Е Р И Т Е  Р А З Д Е Л";
            this.labelSelection.Visible = false;
            // 
            // comboBoxCount
            // 
            this.comboBoxCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCount.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxCount.FormattingEnabled = true;
            this.comboBoxCount.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxCount.Location = new System.Drawing.Point(340, 215);
            this.comboBoxCount.Name = "comboBoxCount";
            this.comboBoxCount.Size = new System.Drawing.Size(121, 27);
            this.comboBoxCount.TabIndex = 65;
            this.comboBoxCount.Visible = false;
            this.comboBoxCount.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelTable
            // 
            this.labelTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTable.AutoSize = true;
            this.labelTable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTable.Font = new System.Drawing.Font("Microsoft JhengHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTable.Image = global::SMART_REST.Properties.Resources.Image_1;
            this.labelTable.Location = new System.Drawing.Point(174, 155);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(415, 42);
            this.labelTable.TabIndex = 1;
            this.labelTable.Text = "В Ы Б Е Р И Т Е  С Т О Л";
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft JhengHei", 7F);
            this.close.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.close.Location = new System.Drawing.Point(35, 411);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(173, 37);
            this.close.TabIndex = 60;
            this.close.Text = "О Т М Е Н А";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft JhengHei", 7F);
            this.save.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.save.Location = new System.Drawing.Point(572, 411);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(173, 37);
            this.save.TabIndex = 59;
            this.save.Text = "С О Х Р А Н И Т Ь";
            this.save.UseVisualStyleBackColor = true;
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // comboTable
            // 
            this.comboTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTable.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboTable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboTable.FormattingEnabled = true;
            this.comboTable.Location = new System.Drawing.Point(129, 215);
            this.comboTable.Name = "comboTable";
            this.comboTable.Size = new System.Drawing.Size(540, 27);
            this.comboTable.TabIndex = 69;
            this.comboTable.SelectedIndexChanged += new System.EventHandler(this.comboTable_SelectedIndexChanged);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.selectList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.selectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.selectList.DefaultCellStyle = dataGridViewCellStyle2;
            this.selectList.EnableHeadersVisualStyles = false;
            this.selectList.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectList.Location = new System.Drawing.Point(35, 69);
            this.selectList.Name = "selectList";
            this.selectList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.selectList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.selectList.RowHeadersVisible = false;
            this.selectList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.selectList.RowTemplate.Height = 24;
            this.selectList.Size = new System.Drawing.Size(710, 320);
            this.selectList.TabIndex = 64;
            this.selectList.Visible = false;
            this.selectList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectList_MouseClick);
            // 
            // form
            // 
            this.form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form.Location = new System.Drawing.Point(0, 0);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(942, 503);
            this.form.TabIndex = 66;
            // 
            // ORDER_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 503);
            this.Controls.Add(this.white);
            this.Controls.Add(this.form);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 550);
            this.Name = "ORDER_ADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMART REST";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ORDER_ADD_FormClosed);
            this.white.ResumeLayout(false);
            this.white.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel white;
        private System.Windows.Forms.DataGridView selectList;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.Label labelSelection;
        private System.Windows.Forms.ComboBox comboSelection;
        private System.Windows.Forms.ComboBox comboTable;
        private System.Windows.Forms.Panel form;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.ComboBox comboBoxCount;
        private System.Windows.Forms.Button buttonSelOrd;
    }
}