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
            txtDepositar = new TextBox();
            lblCaixaEletronico = new Label();
            label1 = new Label();
            btnDepositar = new Button();
            btnSaque = new Button();
            btnSaldo = new Button();
            txtSaque = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // txtDepositar
            // 
            txtDepositar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDepositar.Location = new Point(180, 160);
            txtDepositar.Name = "txtDepositar";
            txtDepositar.PlaceholderText = "Digite o valor de Depósito";
            txtDepositar.Size = new Size(190, 25);
            txtDepositar.TabIndex = 0;
            txtDepositar.TextAlign = HorizontalAlignment.Center;
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
            btnDepositar.Location = new Point(31, 142);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(143, 56);
            btnDepositar.TabIndex = 2;
            btnDepositar.Text = "button1";
            btnDepositar.UseVisualStyleBackColor = true;
            // 
            // btnSaque
            // 
            btnSaque.Location = new Point(31, 201);
            btnSaque.Name = "btnSaque";
            btnSaque.Size = new Size(143, 56);
            btnSaque.TabIndex = 2;
            btnSaque.Text = "Sacar";
            btnSaque.UseVisualStyleBackColor = true;
            // 
            // btnSaldo
            // 
            btnSaldo.Location = new Point(31, 263);
            btnSaldo.Name = "btnSaldo";
            btnSaldo.Size = new Size(143, 56);
            btnSaldo.TabIndex = 2;
            btnSaldo.Text = "Consulta Saldo";
            btnSaldo.UseVisualStyleBackColor = true;
            // 
            // txtSaque
            // 
            txtSaque.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSaque.Location = new Point(180, 217);
            txtSaque.Name = "txtSaque";
            txtSaque.PlaceholderText = "Digite o valor de Saque";
            txtSaque.Size = new Size(190, 25);
            txtSaque.TabIndex = 0;
            txtSaque.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(180, 285);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Saldo em conta";
            textBox2.Size = new Size(190, 25);
            textBox2.TabIndex = 0;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // CaixaEletronico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 442);
            Controls.Add(btnSaldo);
            Controls.Add(btnSaque);
            Controls.Add(btnDepositar);
            Controls.Add(label1);
            Controls.Add(lblCaixaEletronico);
            Controls.Add(textBox2);
            Controls.Add(txtSaque);
            Controls.Add(txtDepositar);
            Name = "CaixaEletronico";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDepositar;
        private Label lblCaixaEletronico;
        private Label label1;
        private Button btnDepositar;
        private Button btnSaque;
        private Button btnSaldo;
        private TextBox txtSaque;
        private TextBox textBox2;
    }
}
