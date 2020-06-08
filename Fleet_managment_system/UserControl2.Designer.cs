namespace Fleet_managment_system
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.colorbox = new System.Windows.Forms.TextBox();
            this.modelbox = new System.Windows.Forms.TextBox();
            this.brandbox = new System.Windows.Forms.TextBox();
            this.regidbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorbox
            // 
            this.colorbox.Location = new System.Drawing.Point(150, 114);
            this.colorbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(76, 20);
            this.colorbox.TabIndex = 22;
            // 
            // modelbox
            // 
            this.modelbox.Location = new System.Drawing.Point(150, 82);
            this.modelbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modelbox.Name = "modelbox";
            this.modelbox.Size = new System.Drawing.Size(76, 20);
            this.modelbox.TabIndex = 21;
            // 
            // brandbox
            // 
            this.brandbox.Location = new System.Drawing.Point(150, 50);
            this.brandbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brandbox.Name = "brandbox";
            this.brandbox.Size = new System.Drawing.Size(76, 20);
            this.brandbox.TabIndex = 20;
            // 
            // regidbox
            // 
            this.regidbox.Location = new System.Drawing.Point(150, 20);
            this.regidbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.regidbox.Name = "regidbox";
            this.regidbox.Size = new System.Drawing.Size(76, 20);
            this.regidbox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Driver Charges";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Monthly Charges";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Weekly Chrages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Daily Charges";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(77, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "Calculate";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colorbox);
            this.Controls.Add(this.modelbox);
            this.Controls.Add(this.brandbox);
            this.Controls.Add(this.regidbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(275, 205);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox colorbox;
        private System.Windows.Forms.TextBox modelbox;
        private System.Windows.Forms.TextBox brandbox;
        private System.Windows.Forms.TextBox regidbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
