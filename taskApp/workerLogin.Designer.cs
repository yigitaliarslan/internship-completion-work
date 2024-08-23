namespace taskApp
{
    partial class workerLogin
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
            label2 = new Label();
            txtTcNo = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 46);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 9;
            label2.Text = "T.C. NO :";
            // 
            // txtTcNo
            // 
            txtTcNo.Location = new Point(105, 48);
            txtTcNo.MaxLength = 11;
            txtTcNo.Name = "txtTcNo";
            txtTcNo.Size = new Size(159, 23);
            txtTcNo.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(125, 94);
            button1.Name = "button1";
            button1.Size = new Size(116, 30);
            button1.TabIndex = 10;
            button1.Text = "Giris Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // workerLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 169);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtTcNo);
            Name = "workerLogin";
            Text = "workerLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtTcNo;
        private Button button1;
    }
}