namespace frmCalculoIMC
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
            numPeso = new NumericUpDown();
            numAltura = new NumericUpDown();
            btnCalcular = new Button();
            lblTitulo = new Label();
            lblPeso = new Label();
            lblAltura = new Label();
            panel1 = new Panel();
            lblImc = new Label();
            txtMensagem = new TextBox();
            lblSeta = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // numPeso
            // 
            numPeso.DecimalPlaces = 2;
            numPeso.Location = new Point(22, 120);
            numPeso.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(249, 31);
            numPeso.TabIndex = 0;
            numPeso.TextAlign = HorizontalAlignment.Right;
            // 
            // numAltura
            // 
            numAltura.DecimalPlaces = 2;
            numAltura.Location = new Point(22, 232);
            numAltura.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(249, 31);
            numAltura.TabIndex = 1;
            numAltura.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(190, 309);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(101, 41);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(88, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(106, 25);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Cálculo IMC";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(22, 83);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(49, 25);
            lblPeso.TabIndex = 5;
            lblPeso.Text = "Peso";
            lblPeso.Click += label2_Click;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(22, 191);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(59, 25);
            lblAltura.TabIndex = 6;
            lblAltura.Text = "Altura";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblAltura);
            panel1.Controls.Add(lblPeso);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(btnCalcular);
            panel1.Controls.Add(numAltura);
            panel1.Controls.Add(numPeso);
            panel1.Location = new Point(10, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 447);
            panel1.TabIndex = 7;
            // 
            // lblImc
            // 
            lblImc.AutoSize = true;
            lblImc.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblImc.Location = new Point(468, 26);
            lblImc.Name = "lblImc";
            lblImc.Size = new Size(169, 89);
            lblImc.TabIndex = 8;
            lblImc.Text = "IMC";
            // 
            // txtMensagem
            // 
            txtMensagem.Location = new Point(392, 126);
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(312, 31);
            txtMensagem.TabIndex = 9;
            // 
            // lblSeta
            // 
            lblSeta.AutoSize = true;
            lblSeta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSeta.ForeColor = Color.Red;
            lblSeta.Location = new Point(356, 395);
            lblSeta.Name = "lblSeta";
            lblSeta.Size = new Size(40, 48);
            lblSeta.TabIndex = 11;
            lblSeta.Text = "⬆";
            lblSeta.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IMC1;
            pictureBox1.Location = new Point(333, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSeta);
            Controls.Add(pictureBox1);
            Controls.Add(txtMensagem);
            Controls.Add(lblImc);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numPeso;
        private NumericUpDown numAltura;
        private Button btnCalcular;
        private Label lblTitulo;
        private Label lblPeso;
        private Label lblAltura;
        private Panel panel1;
        private Label lblImc;
        private TextBox txtMensagem;
        private Label lblSeta;
        private PictureBox pictureBox1;
    }
}