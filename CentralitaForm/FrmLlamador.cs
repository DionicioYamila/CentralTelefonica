using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralitaForm
{
    public partial class FrmLlamador : Form
    {

        Centralita c;
        public FrmLlamador()
        {
            InitializeComponent();
        }

        public FrmLlamador(Centralita c)
        {
            this.c = c;
        }

        public Centralita Cent
        {
            get
            {
                return this.c;
            }
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            string s = ((TextBox)sender).Text;                             //MessageBox.Show(((TextBox)sender).Text);

            if (s.Contains("Nro Destino") && s != "Nro Destino")
            {
                ((TextBox)sender).Text = s.Remove(0, "Nro Destino".Length);
            }

            if (s == string.Empty)
            {
                ((TextBox)sender).Text = "Nro Destino";
            }

            if (s.IndexOf("#") == 0)
            {
                comboBoxFranja.Enabled = true;
            }
            else
            {
                comboBoxFranja.Enabled = false;
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "9";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "0";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            //Llamada l = new Llamada()
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = string.Empty;
        }
    }
}
