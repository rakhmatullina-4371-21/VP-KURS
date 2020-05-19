namespace SMART_REST
{
    partial class ORDER_SELECT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ORDER_SELECT));
            this.white = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.selectList = new System.Windows.Forms.DataGridView();
            this.form = new System.Windows.Forms.Panel();
            this.labelOrder = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.ToolTip(this.components);
            this.white.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectList)).BeginInit();
            this.form.SuspendLayout();
            this.SuspendLayout();
            // 
            // white
            // 
            this.white.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.white.BackColor = System.Drawing.SystemColors.Window;
            this.white.Controls.Add(this.save);
            this.white.Controls.Add(this.selectList);
            this.white.Location = new System.Drawing.Point(72, 74);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(798, 407);
            this.white.TabIndex = 65;
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.BackColor = System.Drawing.Color.White;
            this.save.BackgroundImage = global::SMART_REST.Properties.Resources.Image_1;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft JhengHei", 8F);
            this.save.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.save.Location = new System.Drawing.Point(20, 358);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(760, 30);
            this.save.TabIndex = 64;
            this.save.Text = "К   М Е Н Ю";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
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
            this.selectList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.selectList.EnableHeadersVisualStyles = false;
            this.selectList.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectList.Location = new System.Drawing.Point(57, 20);
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
            this.selectList.Size = new System.Drawing.Size(674, 332);
            this.selectList.TabIndex = 3;
            this.t.SetToolTip(this.selectList, "Дважды кликните для изменения количества блюда");
            // 
            // form
            // 
            this.form.Controls.Add(this.labelOrder);
            this.form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form.Location = new System.Drawing.Point(0, 0);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(942, 503);
            this.form.TabIndex = 66;
            // 
            // labelOrder
            // 
            this.labelOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Microsoft JhengHei", 20.2F);
            this.labelOrder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelOrder.Image = global::SMART_REST.Properties.Resources.Image_1;
            this.labelOrder.Location = new System.Drawing.Point(181, 18);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(581, 43);
            this.labelOrder.TabIndex = 1;
            this.labelOrder.Text = "С О Д Е Р Ж А Н И Е  З А К А З А";
            // 
            // t
            // 
            this.t.BackColor = System.Drawing.SystemColors.ControlDark;
            this.t.ForeColor = System.Drawing.SystemColors.Window;
            // 
            // ORDER_SELECT
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
            this.Name = "ORDER_SELECT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMART REST";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ORDER_EDIT_FormClosed);
            this.white.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectList)).EndInit();
            this.form.ResumeLayout(false);
            this.form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel white;
        private System.Windows.Forms.DataGridView selectList;
        private System.Windows.Forms.Panel form;
        private System.Windows.Forms.ToolTip t;
    }
}