using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
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
            int codi;
            string name;
            name = txtNombre.Text;
            codi = int .Parse(txtCodigo.Text);
            MessageBox.Show("el nombre es: " + name +  " Y el codigo es: " + codi.ToString());

           


        }
    }
}
