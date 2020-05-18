namespace SMART_REST
{
    partial class LISTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LISTS));
            this.employee = new System.Windows.Forms.Button();
            this.dishes = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employee
            // 
            this.employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.employee.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employee.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.employee.Location = new System.Drawing.Point(37, 115);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(222, 220);
            this.employee.TabIndex = 0;
            this.employee.Text = "С О Т Р У Д Н И К И";
            this.employee.UseVisualStyleBackColor = true;
            // 
            // dishes
            // 
            this.dishes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dishes.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishes.Location = new System.Drawing.Point(289, 115);
            this.dishes.Name = "dishes";
            this.dishes.Size = new System.Drawing.Size(222, 220);
            this.dishes.TabIndex = 1;
            this.dishes.Text = "Б Л Ю Д А";
            this.dishes.UseVisualStyleBackColor = true;
            // 
            // stock
            // 
            this.stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stock.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stock.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.stock.Location = new System.Drawing.Point(541, 115);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(222, 220);
            this.stock.TabIndex = 2;
            this.stock.Text = "А К Ц И И";
            this.stock.UseVisualStyleBackColor = true;
            // 
            // LISTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.dishes);
            this.Controls.Add(this.employee);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LISTS";
            this.Text = "SMART REST";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.Button dishes;
        private System.Windows.Forms.Button stock;
    }
}