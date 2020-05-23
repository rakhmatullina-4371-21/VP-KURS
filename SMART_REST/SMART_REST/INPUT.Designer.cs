namespace SMART_REST
{
    partial class INPUT
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INPUT));
            this.login = new System.Windows.Forms.TextBox();
            this.labelPas = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInp = new System.Windows.Forms.Label();
            this.NoInput = new System.Windows.Forms.Label();
            this.NoInput2 = new System.Windows.Forms.Label();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.inputt = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelWhite.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.login.Location = new System.Drawing.Point(112, 63);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(236, 25);
            this.login.TabIndex = 1;
            // 
            // labelPas
            // 
            this.labelPas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPas.AutoSize = true;
            this.labelPas.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPas.Location = new System.Drawing.Point(14, 116);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(92, 19);
            this.labelPas.TabIndex = 54;
            this.labelPas.Text = "П А Р О Л Ь";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.password.Location = new System.Drawing.Point(112, 114);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(236, 25);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(14, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Л О Г И Н";
            // 
            // labelInp
            // 
            this.labelInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInp.AutoSize = true;
            this.labelInp.Font = new System.Drawing.Font("Microsoft JhengHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelInp.Location = new System.Drawing.Point(79, 0);
            this.labelInp.Name = "labelInp";
            this.labelInp.Size = new System.Drawing.Size(208, 48);
            this.labelInp.TabIndex = 0;
            this.labelInp.Text = "  В Х О Д  ";
            // 
            // NoInput
            // 
            this.NoInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoInput.AutoSize = true;
            this.NoInput.Font = new System.Drawing.Font("Microsoft YaHei", 6F, System.Drawing.FontStyle.Bold);
            this.NoInput.ForeColor = System.Drawing.Color.DimGray;
            this.NoInput.Location = new System.Drawing.Point(93, 142);
            this.NoInput.Name = "NoInput";
            this.NoInput.Size = new System.Drawing.Size(255, 15);
            this.NoInput.TabIndex = 56;
            this.NoInput.Text = "Н Е В Е Р Н Ы Й   Л О Г И Н   И Л И   П А Р О Л Ь";
            this.NoInput.Visible = false;
            // 
            // NoInput2
            // 
            this.NoInput2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoInput2.AutoSize = true;
            this.NoInput2.Font = new System.Drawing.Font("Microsoft YaHei", 6F, System.Drawing.FontStyle.Bold);
            this.NoInput2.ForeColor = System.Drawing.Color.DimGray;
            this.NoInput2.Location = new System.Drawing.Point(93, 91);
            this.NoInput2.Name = "NoInput2";
            this.NoInput2.Size = new System.Drawing.Size(255, 15);
            this.NoInput2.TabIndex = 57;
            this.NoInput2.Text = "Н Е В Е Р Н Ы Й   Л О Г И Н   И Л И   П А Р О Л Ь";
            this.NoInput2.Visible = false;
            // 
            // panelWhite
            // 
            this.panelWhite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelWhite.BackColor = System.Drawing.SystemColors.Window;
            this.panelWhite.Controls.Add(this.labelInp);
            this.panelWhite.Controls.Add(this.NoInput2);
            this.panelWhite.Controls.Add(this.labelPas);
            this.panelWhite.Controls.Add(this.label3);
            this.panelWhite.Controls.Add(this.NoInput);
            this.panelWhite.Controls.Add(this.password);
            this.panelWhite.Controls.Add(this.inputt);
            this.panelWhite.Controls.Add(this.login);
            this.panelWhite.Location = new System.Drawing.Point(291, 143);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(362, 220);
            this.panelWhite.TabIndex = 69;
            // 
            // inputt
            // 
            this.inputt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputt.BackColor = System.Drawing.SystemColors.Window;
            this.inputt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputt.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputt.Location = new System.Drawing.Point(18, 169);
            this.inputt.Name = "inputt";
            this.inputt.Size = new System.Drawing.Size(330, 37);
            this.inputt.TabIndex = 55;
            this.inputt.Text = "В О Й Т И";
            this.inputt.UseVisualStyleBackColor = false;
            this.inputt.Click += new System.EventHandler(this.inputt_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMain.Controls.Add(this.panelWhite);
            this.panelMain.Location = new System.Drawing.Point(2, -1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(940, 509);
            this.panelMain.TabIndex = 70;
            // 
            // INPUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 503);
            this.Controls.Add(this.panelMain);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 550);
            this.Name = "INPUT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMART REST";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.INPUT_FormClosed);
            this.panelWhite.ResumeLayout(false);
            this.panelWhite.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button inputt;
        private System.Windows.Forms.Label labelInp;
        private System.Windows.Forms.Label NoInput;
        private System.Windows.Forms.Label NoInput2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelWhite;
    }
}

