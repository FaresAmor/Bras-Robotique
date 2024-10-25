namespace bras_tpe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            vScrollBar2 = new VScrollBar();
            vScrollBar1 = new VScrollBar();
            label2 = new Label();
            label1 = new Label();
            hScrollBar2 = new HScrollBar();
            hScrollBar1 = new HScrollBar();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(vScrollBar2);
            panel1.Controls.Add(vScrollBar1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(hScrollBar2);
            panel1.Controls.Add(hScrollBar1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(908, 506);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "COM1", "COM2", "COM3" });
            comboBox1.Location = new Point(609, 416);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 28);
            comboBox1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(724, 341);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(619, 239);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 6;
            // 
            // vScrollBar2
            // 
            vScrollBar2.Location = new Point(844, 239);
            vScrollBar2.Name = "vScrollBar2";
            vScrollBar2.Size = new Size(26, 125);
            vScrollBar2.TabIndex = 5;
            vScrollBar2.Scroll += vScrollBar2_Scroll;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(581, 239);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 125);
            vScrollBar1.TabIndex = 4;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(740, 52);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(581, 52);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // hScrollBar2
            // 
            hScrollBar2.Location = new Point(750, 128);
            hScrollBar2.Name = "hScrollBar2";
            hScrollBar2.Size = new Size(100, 26);
            hScrollBar2.TabIndex = 1;
            hScrollBar2.Scroll += hScrollBar2_Scroll;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(592, 128);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(100, 26);
            hScrollBar1.TabIndex = 0;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(58, 378);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 11;
            label5.Text = "crée par : Fares Amor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 507);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private HScrollBar hScrollBar2;
        private HScrollBar hScrollBar1;
        private VScrollBar vScrollBar2;
        private VScrollBar vScrollBar1;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label5;
    }
}
