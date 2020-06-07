using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralitaForm
{
    public partial class FrmMostrar : Form
    {
        Centralita c;

        public FrmMostrar()
        {
            InitializeComponent();
        }

        public FrmMostrar(Centralita c)
        {
            this.c = c; 
        }


    }
}
