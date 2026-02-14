namespace Cofrinho
{
    partial class CaixaEletronico
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
            txtVisor = new TextBox();
            lblCaixaEletronico = new Label();
            label1 = new Label();
            btnDepositar = new Button();
            btnSaque = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtVisor
            // 
            txtVisor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVisor.Location = new Point(102, 160);
            txtVisor.Name = "txtVisor";
            txtVisor.PlaceholderText = "Digite valor";
            txtVisor.Size = new Size(190, 25);
            txtVisor.TabIndex = 0;
            txtVisor.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCaixaEletronico
            // 
            lblCaixaEletronico.AutoSize = true;
            lblCaixaEletronico.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCaixaEletronico.Location = new Point(31, 36);
            lblCaixaEletronico.Name = "lblCaixaEletronico";
            lblCaixaEletronico.Size = new Size(319, 45);
            lblCaixaEletronico.TabIndex = 1;
            lblCaixaEletronico.Text = "CAIXA ELETRONICO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 95);
            label1.Name = "label1";
            label1.Size = new Size(250, 32);
            label1.TabIndex = 1;
            label1.Text = "Operações Bancárias";
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(57, 191);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(143, 56);
            btnDepositar.TabIndex = 2;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnSaque
            // 
            btnSaque.Location = new Point(207, 191);
            btnSaque.Name = "btnSaque";
            btnSaque.Size = new Size(143, 56);
            btnSaque.TabIndex = 2;
            btnSaque.Text = "Sacar";
            btnSaque.UseVisualStyleBackColor = true;
            btnSaque.Click += btnSaque_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(162, 273);
            label2.Name = "label2";
            label2.Size = new Size(44, 32);
            label2.TabIndex = 3;
            label2.Text = "R$";
            // 
            // CaixaEletronico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 442);
            Controls.Add(label2);
            Controls.Add(btnSaque);
            Controls.Add(btnDepositar);
            Controls.Add(label1);
            Controls.Add(lblCaixaEletronico);
            Controls.Add(txtVisor);
            Name = "CaixaEletronico";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVisor;
        private Label lblCaixaEletronico;
        private Label label1;
        private Button btnDepositar;
        private Button btnSaque;
        private Label label2;
    }
}
