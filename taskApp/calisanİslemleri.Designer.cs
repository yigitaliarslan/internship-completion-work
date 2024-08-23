namespace taskApp
{
    partial class calisanİslemleri
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
            dataGridView1 = new DataGridView();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            txtGorev = new RichTextBox();
            label5 = new Label();
            txtİd = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ImeMode = ImeMode.Off;
            dataGridView1.Location = new Point(2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(798, 298);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(74, 329);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(160, 23);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(91, 367);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(160, 23);
            txtSoyad.TabIndex = 2;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(202, 400);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(160, 23);
            txtTC.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 403);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 4;
            label1.Text = "T.C. Kimlik Numarası :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 327);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 5;
            label2.Text = "Ad : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 369);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 6;
            label3.Text = "Soyad : ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(455, 316);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 180);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "İslemler";
            // 
            // button3
            // 
            button3.Location = new Point(23, 116);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(150, 54);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Sil ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(23, 54);
            button1.Name = "button1";
            button1.Size = new Size(110, 34);
            button1.TabIndex = 0;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 484);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 9;
            label4.Text = "Görev :";
            // 
            // txtGorev
            // 
            txtGorev.Location = new Point(121, 450);
            txtGorev.Name = "txtGorev";
            txtGorev.Size = new Size(283, 122);
            txtGorev.TabIndex = 10;
            txtGorev.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(637, 591);
            label5.Name = "label5";
            label5.Size = new Size(39, 21);
            label5.TabIndex = 12;
            label5.Text = "İD : ";
            // 
            // txtİd
            // 
            txtİd.Location = new Point(695, 593);
            txtİd.Name = "txtİd";
            txtİd.ReadOnly = true;
            txtİd.Size = new Size(82, 23);
            txtİd.TabIndex = 11;
            // 
            // button4
            // 
            button4.Location = new Point(150, 116);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 13;
            button4.Text = "Menüye Geri Dön";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // calisanİslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 628);
            Controls.Add(label5);
            Controls.Add(txtİd);
            Controls.Add(txtGorev);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTC);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(dataGridView1);
            Name = "calisanİslemleri";
            Text = "v";
            Load += calisanİslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTC;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label4;
        private RichTextBox txtGorev;
        private Label label5;
        private TextBox txtİd;
        private Button button4;
    }
}