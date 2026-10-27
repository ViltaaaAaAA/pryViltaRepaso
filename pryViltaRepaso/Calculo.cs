using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryViltaRepaso
{
    public partial class Calculo : Form
    {
        public Calculo()
        {
            InitializeComponent();
        }

        private void btncalculo_Click(object sender, EventArgs e)
        {
            float monto;
            monto = float.Parse(txtMonto.Text);
            float IVA;
            IVA = float.Parse(cboIVA.SelectedItem.ToString().Replace("%", "")) /100;
            float resultado;
            resultado = monto * IVA;
            lblbResultado.Text = "Resultado: $" + resultado;

        }
    }
}
