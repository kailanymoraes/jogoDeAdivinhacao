namespace JogoDeAdivinhacao
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
            lblTitulo = new Label();
            txtDigite = new TextBox();
            lblInstrucao = new Label();
            btnSortear = new Button();
            lblTentativa = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(166, 61);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(182, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Jogo de Adivinhação";
            // 
            // txtDigite
            // 
            txtDigite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDigite.Location = new Point(203, 191);
            txtDigite.Name = "txtDigite";
            txtDigite.Size = new Size(91, 29);
            txtDigite.TabIndex = 2;
            txtDigite.TextChanged += textBox1_TextChanged;
            // 
            // lblInstrucao
            // 
            lblInstrucao.AutoSize = true;
            lblInstrucao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInstrucao.ForeColor = SystemColors.ActiveCaptionText;
            lblInstrucao.Location = new Point(145, 149);
            lblInstrucao.Name = "lblInstrucao";
            lblInstrucao.Size = new Size(214, 21);
            lblInstrucao.TabIndex = 3;
            lblInstrucao.Text = "Digite um número de 1 a 100";
            // 
            // btnSortear
            // 
            btnSortear.BackColor = Color.LightSkyBlue;
            btnSortear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSortear.Location = new Point(203, 237);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(91, 32);
            btnSortear.TabIndex = 4;
            btnSortear.Text = "sortear";
            btnSortear.UseVisualStyleBackColor = false;
            btnSortear.Click += button1_Click;
            // 
            // lblTentativa
            // 
            lblTentativa.AutoSize = true;
            lblTentativa.Location = new Point(145, 312);
            lblTentativa.Name = "lblTentativa";
            lblTentativa.Size = new Size(17, 15);
            lblTentativa.TabIndex = 5;
            lblTentativa.Text = "\"\"";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 430);
            Controls.Add(lblTentativa);
            Controls.Add(btnSortear);
            Controls.Add(lblInstrucao);
            Controls.Add(txtDigite);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtDigite;
        private Label lblInstrucao;
        private Button btnSortear;
        private Label lblTentativa;
    }
}