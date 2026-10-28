using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryViltaRepaso
{
    public partial class FrmArray : Form
    {
        string[] vectorGrupoA = new string[4];
        string[] vectorGrupoB = new string[3];
        string[] vectorGrupoC = new string[3];
        public FrmArray()
        {

            InitializeComponent();
        }

        private void FrmArray_Load(object sender, EventArgs e)
        {
            cboplan.Items.Add("Grupo A");
            cboplan.Items.Add("Grupo B");
            cboplan.Items.Add("Grupo C");

            vectorGrupoA[0] = "CPU";
            vectorGrupoA[1] = "MICRO";
            vectorGrupoA[2] = "PLACA";
            vectorGrupoA[3] = "MEMORIA";

            vectorGrupoB[0] = "VISUAL";
            vectorGrupoB[1] = "C#";
            vectorGrupoB[2] = "DESKTOP";

            vectorGrupoC[0] = "SERVER";
            vectorGrupoC[1] = "AWS";
            vectorGrupoC[2] = "CLOUD";



            cboplan.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cboplan_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cboplan.Text)
            {
                case "Grupo A":

                    lstLista.Items.Clear();
                    lstLista.Items.Add("CPU");
                    lstLista.Items.Add("MICRO");
                    lstLista.Items.Add("PLACA");
                    lstLista.Items.Add("MEMORIA");
                    lstLista.Items.Clear();
                    for (int indice = 0; indice < vectorGrupoA.Length; indice++)
                    {

                        lstLista.Items.Add(vectorGrupoA[indice]);
                    }
                    break;

                case "Grupo B":
                    lstLista.Items.Clear();
                    lstLista.Items.Add("VISUAL");
                    lstLista.Items.Add("C#");
                    lstLista.Items.Add("DESKTOP");
                    lstLista.Items.Clear();
                    for (int indice = 0; indice < vectorGrupoB.Length; indice++)
                    {
                        lstLista.Items.Add(vectorGrupoB[indice]);
                    }

                    break;

                case "Grupo C":
                    lstLista.Items.Clear();
                    lstLista.Items.Add("SERVER");
                    lstLista.Items.Add("AWS");
                    lstLista.Items.Add("CLOUD");
                    lstLista.Items.Clear();
                    for (int indice = 0; indice < vectorGrupoC.Length; indice++)
                    {
                        lstLista.Items.Add(vectorGrupoC[indice]);
                    }
                    break;


            }
        }
        int indiceGrabar = 0;
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (cboGrupo.Text)
            {
                case "Grupo A":
                    vectorGrupoA[indiceGrabar] = txtDato.Text;
                    indiceGrabar++;
                    lblMensaje.Text = "Almacenamiento..." + txtDato.Text;
                    txtDato.Text = "";
                    break;

                default:
                    break;

                case "Grupo B":
                    vectorGrupoA[indiceGrabar] = txtDato.Text;
                    indiceGrabar++;
                    lblMensaje.Text = "Almacenamiento..." + txtDato.Text;
                    txtDato.Text = "";
                    break;

                case "Grupo C":
                    vectorGrupoA[indiceGrabar] = txtDato.Text;
                    indiceGrabar++;
                    lblMensaje.Text = "Almacenamiento..." + txtDato.Text;
                    txtDato.Text = "";
                    break;

              
            }
        }
    }
}
        
