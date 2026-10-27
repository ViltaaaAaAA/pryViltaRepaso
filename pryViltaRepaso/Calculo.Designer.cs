namespace pryViltaRepaso
{
    partial class Calculo
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
            lblMonto = new Label();
            lblIVA = new Label();
            txtMonto = new TextBox();
            cboIVA = new ComboBox();
            btncalculo = new Button();
            lblbResultado = new Label();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(27, 24);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto";
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Location = new Point(27, 63);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(24, 15);
            lblIVA.TabIndex = 1;
            lblIVA.Text = "IVA";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(97, 21);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 3;
            // 
            // cboIVA
            // 
            cboIVA.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIVA.FormattingEnabled = true;
            cboIVA.Items.AddRange(new object[] { "10%", "20%" });
            cboIVA.Location = new Point(97, 55);
            cboIVA.Name = "cboIVA";
            cboIVA.Size = new Size(100, 23);
            cboIVA.TabIndex = 4;
            // 
            // btncalculo
            // 
            btncalculo.Location = new Point(213, 99);
            btncalculo.Name = "btncalculo";
            btncalculo.Size = new Size(75, 23);
            btncalculo.TabIndex = 5;
            btncalculo.Text = "Cálculo";
            btncalculo.UseVisualStyleBackColor = true;
            btncalculo.Click += btncalculo_Click;
            // 
            // lblbResultado
            // 
            lblbResultado.AutoSize = true;
            lblbResultado.Location = new Point(126, 153);
            lblbResultado.Name = "lblbResultado";
            lblbResultado.Size = new Size(62, 15);
            lblbResultado.TabIndex = 6;
            lblbResultado.Text = "Resultado:";
            // 
            // Calculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 188);
            Controls.Add(lblbResultado);
            Controls.Add(btncalculo);
            Controls.Add(cboIVA);
            Controls.Add(txtMonto);
            Controls.Add(lblIVA);
            Controls.Add(lblMonto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Calculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonto;
        private Label lblIVA;
        private TextBox txtMonto;
        private ComboBox cboIVA;
        private Button btncalculo;
        private Label lblbResultado;
    }
}