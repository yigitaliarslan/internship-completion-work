namespace taskApp
{
    partial class adminLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtAdminName = new TextBox();
            txtAdminPass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnAdminGiris = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(238, 42);
            label1.Name = "label1";
            label1.Size = new Size(141, 30);
            label1.TabIndex = 0;
            label1.Text = "Admin Login";
            // 
            // txtAdminName
            // 
            txtAdminName.Location = new Point(220, 118);
            txtAdminName.Name = "txtAdminName";
            txtAdminName.Size = new Size(159, 23);
            txtAdminName.TabIndex = 1;
            // 
            // txtAdminPass
            // 
            txtAdminPass.Location = new Point(220, 167);
            txtAdminPass.Name = "txtAdminPass";
            txtAdminPass.Size = new Size(159, 23);
            txtAdminPass.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(119, 116);
            label2.Name = "label2";
            label2.Size = new Size(39, 21);
            label2.TabIndex = 3;
            label2.Text = "Ad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(119, 165);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 4;
            label3.Text = "Sifre :";
            // 
            // btnAdminGiris
            // 
            btnAdminGiris.Location = new Point(238, 210);
            btnAdminGiris.Name = "btnAdminGiris";
            btnAdminGiris.Size = new Size(126, 37);
            btnAdminGiris.TabIndex = 5;
            btnAdminGiris.Text = "Giris Yap";
            btnAdminGiris.UseVisualStyleBackColor = true;
            btnAdminGiris.Click += btnAdminGiris_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 314);
            Controls.Add(btnAdminGiris);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAdminPass);
            Controls.Add(txtAdminName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAdminName;
        private TextBox txtAdminPass;
        private Label label2;
        private Label label3;
        private Button btnAdminGiris;
    }
}