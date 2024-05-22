namespace projek_pbo
{
    partial class kodever2
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
            label1 = new Label();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            bigTextBox1 = new ReaLTaiizor.Controls.BigTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nunito", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 439);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 1;
            label1.Text = "Kode Verifikasi";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Nunito", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(234, 609);
            button2.Name = "button2";
            button2.Size = new Size(127, 38);
            button2.TabIndex = 3;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Group;
            pictureBox2.Location = new Point(935, 400);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(318, 216);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat ExtraBold", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(1005, 632);
            label2.Name = "label2";
            label2.Size = new Size(186, 46);
            label2.TabIndex = 5;
            label2.Text = "EZBRARY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(964, 668);
            label3.Name = "label3";
            label3.Size = new Size(264, 39);
            label3.TabIndex = 6;
            label3.Text = "PERPUSTAKAAN";
            // 
            // bigTextBox1
            // 
            bigTextBox1.BackColor = Color.Transparent;
            bigTextBox1.Font = new Font("Nunito", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigTextBox1.ForeColor = Color.DimGray;
            bigTextBox1.Image = null;
            bigTextBox1.Location = new Point(182, 490);
            bigTextBox1.MaxLength = 32767;
            bigTextBox1.Multiline = false;
            bigTextBox1.Name = "bigTextBox1";
            bigTextBox1.ReadOnly = false;
            bigTextBox1.Size = new Size(244, 46);
            bigTextBox1.TabIndex = 8;
            bigTextBox1.Text = "Type the above word...";
            bigTextBox1.TextAlignment = HorizontalAlignment.Left;
            bigTextBox1.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Mask_group__4_;
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(604, 264);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // kodever2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pictureBox1);
            Controls.Add(bigTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kodever2";
            Text = "kodever2";
            Load += kodever2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox1;
        private PictureBox pictureBox1;
    }
}