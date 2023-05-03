namespace JetFighter
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Jet = new PictureBox();
            Building1 = new PictureBox();
            Building2 = new PictureBox();
            Building3 = new PictureBox();
            gameover = new Label();
            coin3 = new PictureBox();
            coin4 = new PictureBox();
            coin1 = new PictureBox();
            coin2 = new PictureBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Jet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Building1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Building2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Building3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin2).BeginInit();
            SuspendLayout();
            // 
            // Jet
            // 
            Jet.Image = (Image)resources.GetObject("Jet.Image");
            Jet.Location = new Point(30, 330);
            Jet.Name = "Jet";
            Jet.Size = new Size(53, 57);
            Jet.SizeMode = PictureBoxSizeMode.StretchImage;
            Jet.TabIndex = 0;
            Jet.TabStop = false;
            Jet.KeyDown += Form1_KeyDown;
            Jet.Click += Jet_Click;
            // 
            // Building1
            // 
            Building1.Image = (Image)resources.GetObject("Building1.Image");
            Building1.Location = new Point(30, 109);
            Building1.Name = "Building1";
            Building1.Size = new Size(53, 57);
            Building1.SizeMode = PictureBoxSizeMode.StretchImage;
            Building1.TabIndex = 0;
            Building1.TabStop = false;
            Building1.KeyDown += Form1_KeyDown;
            Building1.Click += Jet_Click;
            // 
            // Building2
            // 
            Building2.Image = (Image)resources.GetObject("Building2.Image");
            Building2.Location = new Point(239, 53);
            Building2.Name = "Building2";
            Building2.Size = new Size(53, 57);
            Building2.SizeMode = PictureBoxSizeMode.StretchImage;
            Building2.TabIndex = 0;
            Building2.TabStop = false;
            Building2.KeyDown += Form1_KeyDown;
            Building2.Click += Jet_Click;
            // 
            // Building3
            // 
            Building3.Image = (Image)resources.GetObject("Building3.Image");
            Building3.Location = new Point(254, 203);
            Building3.Name = "Building3";
            Building3.Size = new Size(53, 57);
            Building3.SizeMode = PictureBoxSizeMode.StretchImage;
            Building3.TabIndex = 0;
            Building3.TabStop = false;
            Building3.KeyDown += Form1_KeyDown;
            Building3.Click += Jet_Click;
            // 
            // gameover
            // 
            gameover.AutoSize = true;
            gameover.BackColor = Color.Black;
            gameover.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            gameover.ForeColor = Color.Crimson;
            gameover.Location = new Point(91, 133);
            gameover.Name = "gameover";
            gameover.Size = new Size(207, 46);
            gameover.TabIndex = 1;
            gameover.Text = "Game Over!";
            // 
            // coin3
            // 
            coin3.Image = (Image)resources.GetObject("coin3.Image");
            coin3.Location = new Point(91, 208);
            coin3.Name = "coin3";
            coin3.Size = new Size(28, 28);
            coin3.SizeMode = PictureBoxSizeMode.StretchImage;
            coin3.TabIndex = 0;
            coin3.TabStop = false;
            coin3.KeyDown += Form1_KeyDown;
            coin3.Click += Jet_Click;
            // 
            // coin4
            // 
            coin4.Image = (Image)resources.GetObject("coin4.Image");
            coin4.Location = new Point(331, 297);
            coin4.Name = "coin4";
            coin4.Size = new Size(28, 28);
            coin4.SizeMode = PictureBoxSizeMode.StretchImage;
            coin4.TabIndex = 0;
            coin4.TabStop = false;
            coin4.KeyDown += Form1_KeyDown;
            coin4.Click += Jet_Click;
            // 
            // coin1
            // 
            coin1.Image = (Image)resources.GetObject("coin1.Image");
            coin1.Location = new Point(91, 79);
            coin1.Name = "coin1";
            coin1.Size = new Size(28, 28);
            coin1.SizeMode = PictureBoxSizeMode.StretchImage;
            coin1.TabIndex = 0;
            coin1.TabStop = false;
            coin1.KeyDown += Form1_KeyDown;
            coin1.Click += Jet_Click;
            // 
            // coin2
            // 
            coin2.Image = (Image)resources.GetObject("coin2.Image");
            coin2.Location = new Point(321, 141);
            coin2.Name = "coin2";
            coin2.Size = new Size(28, 28);
            coin2.SizeMode = PictureBoxSizeMode.StretchImage;
            coin2.TabIndex = 0;
            coin2.TabStop = false;
            coin2.KeyDown += Form1_KeyDown;
            coin2.Click += Jet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(-2, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 2;
            label1.Text = "Coins = 0";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(382, 453);
            Controls.Add(label1);
            Controls.Add(gameover);
            Controls.Add(Building3);
            Controls.Add(Building2);
            Controls.Add(coin2);
            Controls.Add(coin1);
            Controls.Add(coin4);
            Controls.Add(coin3);
            Controls.Add(Building1);
            Controls.Add(Jet);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Jet).EndInit();
            ((System.ComponentModel.ISupportInitialize)Building1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Building2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Building3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin4).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Jet;
        private PictureBox Building1;
        private PictureBox Building2;
        private PictureBox Building3;
        private Label gameover;
        private PictureBox coin3;
        private PictureBox coin4;
        private PictureBox coin1;
        private PictureBox coin2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}