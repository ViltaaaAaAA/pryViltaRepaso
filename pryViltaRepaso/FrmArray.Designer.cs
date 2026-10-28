namespace pryViltaRepaso
{
    partial class FrmArray
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
            lblGrupos = new Label();
            cboplan = new ComboBox();
            lstLista = new ListBox();
            btnGrabar = new Button();
            lblDato = new Label();
            lblGrupo = new Label();
            cboGrupo = new ComboBox();
            txtDato = new TextBox();
            btnarray = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // lblGrupos
            // 
            lblGrupos.AutoSize = true;
            lblGrupos.Location = new Point(12, 22);
            lblGrupos.Name = "lblGrupos";
            lblGrupos.Size = new Size(45, 15);
            lblGrupos.TabIndex = 0;
            lblGrupos.Text = "Grupos";
            // 
            // cboplan
            // 
            cboplan.FormattingEnabled = true;
            cboplan.Location = new Point(76, 19);
            cboplan.Name = "cboplan";
            cboplan.Size = new Size(121, 23);
            cboplan.TabIndex = 2;
            cboplan.SelectedIndexChanged += cboplan_SelectedIndexChanged;
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.Location = new Point(29, 60);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(168, 94);
            lstLista.TabIndex = 3;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(155, 311);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 4;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.Location = new Point(12, 244);
            lblDato.Name = "lblDato";
            lblDato.Size = new Size(32, 15);
            lblDato.TabIndex = 5;
            lblDato.Text = "Dato";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(12, 211);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 6;
            lblGrupo.Text = "Grupo";
            // 
            // cboGrupo
            // 
            cboGrupo.FormattingEnabled = true;
            cboGrupo.Location = new Point(56, 203);
            cboGrupo.Name = "cboGrupo";
            cboGrupo.Size = new Size(141, 23);
            cboGrupo.TabIndex = 7;
            // 
            // txtDato
            // 
            txtDato.Location = new Point(56, 244);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(141, 23);
            txtDato.TabIndex = 8;
            // 
            // btnarray
            // 
            btnarray.Location = new Point(41, 160);
            btnarray.Name = "btnarray";
            btnarray.Size = new Size(140, 23);
            btnarray.TabIndex = 9;
            btnarray.Text = "Sobreescribir Array";
            btnarray.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(29, 378);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(51, 15);
            lblMensaje.TabIndex = 10;
            lblMensaje.Text = "Mensaje";
            // 
            // FrmArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 402);
            Controls.Add(lblMensaje);
            Controls.Add(btnarray);
            Controls.Add(txtDato);
            Controls.Add(cboGrupo);
            Controls.Add(lblGrupo);
            Controls.Add(lblDato);
            Controls.Add(btnGrabar);
            Controls.Add(lstLista);
            Controls.Add(cboplan);
            Controls.Add(lblGrupos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmArray";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmArray";
            Load += FrmArray_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGrupos;
        private ComboBox cboplan;
        private ListBox lstLista;
        private Button btnGrabar;
        private Label lblDato;
        private Label lblGrupo;
        private ComboBox cboGrupo;
        private TextBox txtDato;
        private Button btnarray;
        private Label lblMensaje;
    }
}