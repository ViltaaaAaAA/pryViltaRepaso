using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryViltaRepaso
{
    public partial class CargadeDatos : Form
    {
        public CargadeDatos()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string dato;
            dato = txtCodigo.Text;
            MessageBox.Show(dato);
        }
    }
}
