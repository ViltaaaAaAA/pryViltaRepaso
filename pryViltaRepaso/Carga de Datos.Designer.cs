namespace pryViltaRepaso
{
    partial class CargadeDatos
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
            lblCódigo = new Label();
            txtCodigo = new TextBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // lblCódigo
            // 
            lblCódigo.AutoSize = true;
            lblCódigo.Location = new Point(25, 30);
            lblCódigo.Name = "lblCódigo";
            lblCódigo.Size = new Size(46, 15);
            lblCódigo.TabIndex = 0;
            lblCódigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(77, 27);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(202, 66);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // CargadeDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 101);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCodigo);
            Controls.Add(lblCódigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CargadeDatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carga de Datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCódigo;
        private TextBox txtCodigo;
        private Button btnRegistrar;
    }
}