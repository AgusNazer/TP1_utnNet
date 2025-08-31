using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TP1_GRUPO_7
{
    public partial class Frm_Ejercicio3 : Form
    {
        FormPrincipal formPrincipal;
        public Frm_Ejercicio3(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void Frm_Ejercicio3_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
        }

        private void listarProfesionesSeleccionadas()
        {
            List<string> seleccionados = new List<string>();
            
            foreach (System.Windows.Forms.CheckBox checkBox in groupBoxProfesion.Controls)
            {
                if (checkBox != null && checkBox.Checked)
                {
                    seleccionados.Add("- " + checkBox.Text);
                }
            }

            foreach (System.Windows.Forms.CheckBox checkBox in gbOficiosPersonalizados.Controls)
            {
                if (checkBox != null && checkBox.Checked)
                {
                    seleccionados.Add("- " + checkBox.Text);
                }
            }

            //se encarga de mostrar si se eligio un oficio
            if (seleccionados.Count>0){
                lbSeleccionOficio.Text = String.Join(Environment.NewLine, seleccionados);
            }
            else
            {
                lbSeleccionOficio.Text = "No seleccionaste ninguna opcion";
            }
            
        }

        private void mostrarSexoSeleccionado()
        {
            string sexoSeleccionado = " ";

            if (rdFemenino.Checked)
            {
                sexoSeleccionado = "Femenino";
            }
            else if (rbMasculino.Checked)
            {
                sexoSeleccionado = "Masculino";
            }
            lbSeleccionSexo.Text = sexoSeleccionado;


            string EstadoCivilSelec = " ";

            if (rbCasado.Checked)
            {
                EstadoCivilSelec = "Casado";
            }
            else if (rbSoltero.Checked)
            {
                EstadoCivilSelec = "Soltero";
            }
            lbSelecEstCivil.Text = EstadoCivilSelec;
        }

        private void btnMostrarSeleccion_Click(object sender, EventArgs e)
        {
            mostrarSexoSeleccionado();

            listarProfesionesSeleccionadas();
        }

        private void btnQuitarSeleccion_Click(object sender, EventArgs e)
        {
            rdFemenino.Checked = true;
            rbMasculino.Checked = false;

            rbCasado.Checked = true;
            rbSoltero.Checked = false;

            if(checkBoxData.Checked == true || checkBoxOperador.Checked == true ||
               checkBoxReparador.Checked == true || checkBoxProgramador.Checked == true ||
               checkBoxTester.Checked == true)
            {
                checkBoxData.Checked = false;
                checkBoxOperador.Checked = false;
                checkBoxReparador.Checked = false;
                checkBoxProgramador.Checked = false;
                checkBoxTester.Checked = false;
            }

            if (gbOficiosPersonalizados.Controls.Count > 0)
            {
                foreach (Control control in gbOficiosPersonalizados.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void btnAgregarOficio_Click(object sender, EventArgs e)
        {
            const int LIMITE_OFICIOS_PERSONALIZADOS = 5;

            if (string.IsNullOrWhiteSpace(txtOficioPersonalizado.Text))
            {
                MessageBox.Show("Debe ser un oficio válido.", "Atencion!!");
                return;
            }

            if (gbOficiosPersonalizados.Controls.Count >= LIMITE_OFICIOS_PERSONALIZADOS)
            {
                MessageBox.Show("Límite excedido.", "Atencion!!");
                return;
            }

            int y = 15;
            int x = 10;

            if (gbOficiosPersonalizados.Controls.Count > 0)
            {
                Control ultimo = gbOficiosPersonalizados.Controls[gbOficiosPersonalizados.Controls.Count - 1];
                y = ultimo.Top + ultimo.Height - 1;
            }

            System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
            checkBox.Text = txtOficioPersonalizado.Text.Trim();

            checkBox.Location = new Point(x, y);

            gbOficiosPersonalizados.Controls.Add(checkBox);

            txtOficioPersonalizado.Clear();
            txtOficioPersonalizado.Focus();
        }

        private void btnBorrarPersonalizados_Click(object sender, EventArgs e)
        {
            if (gbOficiosPersonalizados.Controls.Count <= 0)
            {
                MessageBox.Show("No hay oficios personalizados para borrar.", "Atencion!!");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Seguro que quieres borrar los oficios personalizados?",
                "Confirmacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (resultado == DialogResult.Yes)
            {
                gbOficiosPersonalizados.Controls.Clear();
            }
        }
    }
}
