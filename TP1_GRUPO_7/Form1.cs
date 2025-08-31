using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_7
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            Frm_Ejercicio1 frm_Ejercicio1 = new Frm_Ejercicio1(this);
            frm_Ejercicio1.Show();
            this.Hide();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            Frm_Ejercicio2 frm_Ejercicio2 = new Frm_Ejercicio2(this);
            frm_Ejercicio2.Show();
            this.Hide();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            Frm_Ejercicio3 frm_Ejercicio3 = new Frm_Ejercicio3(this);
            frm_Ejercicio3.Show();
            this.Hide();
        }
    }
}
