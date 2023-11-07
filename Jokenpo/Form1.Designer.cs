namespace Jokenpo
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            picResultado = new PictureBox();
            label2 = new Label();
            labelResultado = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Pedra = new Button();
            Papel = new Button();
            Tesoura = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picResultado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 16);
            label1.Name = "label1";
            label1.Size = new Size(618, 90);
            label1.TabIndex = 0;
            label1.Text = "Escolha: Pedra, Papel ou Tesoura...";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(10, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(233, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // picResultado
            // 
            picResultado.BackgroundImageLayout = ImageLayout.Stretch;
            picResultado.Location = new Point(455, 99);
            picResultado.Name = "picResultado";
            picResultado.Size = new Size(150, 150);
            picResultado.SizeMode = PictureBoxSizeMode.StretchImage;
            picResultado.TabIndex = 3;
            picResultado.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(55, 165);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 4;
            label2.Text = "Você";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelResultado.ForeColor = SystemColors.HotTrack;
            labelResultado.Location = new Point(521, 165);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(20, 25);
            labelResultado.TabIndex = 5;
            labelResultado.Text = "?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(298, 165);
            label4.Name = "label4";
            label4.Size = new Size(36, 25);
            label4.TabIndex = 6;
            label4.Text = "PC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(176, 165);
            label5.Name = "label5";
            label5.Size = new Size(36, 25);
            label5.TabIndex = 7;
            label5.Text = "VS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(412, 165);
            label6.Name = "label6";
            label6.Size = new Size(25, 25);
            label6.TabIndex = 8;
            label6.Text = "=";
            // 
            // Pedra
            // 
            Pedra.BackgroundImage = Properties.Resources.Pedra;
            Pedra.BackgroundImageLayout = ImageLayout.Stretch;
            Pedra.Location = new Point(10, 276);
            Pedra.Name = "Pedra";
            Pedra.Size = new Size(150, 150);
            Pedra.TabIndex = 9;
            Pedra.UseVisualStyleBackColor = true;
            Pedra.Click += Pedra_Click;
            // 
            // Papel
            // 
            Papel.BackgroundImage = Properties.Resources.Papel;
            Papel.BackgroundImageLayout = ImageLayout.Stretch;
            Papel.Location = new Point(233, 276);
            Papel.Name = "Papel";
            Papel.Size = new Size(150, 150);
            Papel.TabIndex = 10;
            Papel.UseVisualStyleBackColor = true;
            Papel.Click += Papel_Click;
            // 
            // Tesoura
            // 
            Tesoura.BackgroundImage = Properties.Resources.Tesoura;
            Tesoura.BackgroundImageLayout = ImageLayout.Stretch;
            Tesoura.Location = new Point(455, 276);
            Tesoura.Name = "Tesoura";
            Tesoura.Size = new Size(150, 150);
            Tesoura.TabIndex = 11;
            Tesoura.UseVisualStyleBackColor = true;
            Tesoura.Click += Tesoura_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(640, 509);
            Controls.Add(Tesoura);
            Controls.Add(Papel);
            Controls.Add(Pedra);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(labelResultado);
            Controls.Add(label2);
            Controls.Add(picResultado);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "JOKENPO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox picResultado;
        private Label label2;
        private Label labelResultado;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Pedra;
        private Button Papel;
        private Button Tesoura;
    }
}