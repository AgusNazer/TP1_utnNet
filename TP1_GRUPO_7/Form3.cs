using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP1_GRUPO_7
{
    public partial class Frm_Ejercicio2 : Form
    {
        FormPrincipal formPrincipal;

        public Frm_Ejercicio2(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            this.AcceptButton = btnAgregar;
        }

        private void Frm_Ejercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //validacion para que no ingrese nombre ni apellido vacio
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                //cartel si se ingresa nombre vacio
                MessageBox.Show("Debe ingresar nombre");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar un apellido válido");
                return;
            }

            ///guarda o nombre y apelido para despues unirlos y agregarlo a Listbox
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string nombreCompleto = string.Concat(nombre, " ", apellido);

            ///Recorremos para buscar similituds
            foreach (var item in lbNombreApellido.Items)
            {
                ///convierte un objeto de ListBox en un string y o guarda en la variable
                string existente = item.ToString();

                if (string.Equals(existente, nombreCompleto, StringComparison.OrdinalIgnoreCase))
                {
                    
                    if (!string.Equals(existente, nombreCompleto, StringComparison.Ordinal))
                    {
                        MessageBox.Show("Este nombre ya fue ingresado, pero con diferente uso de mayúsculas.");
                        return;
                    }

                    // Si es igual exactamente
                    MessageBox.Show("Este nombre ya fue ingresado.");
                    return;
                }
            }
            
            lbNombreApellido.Items.Add(nombreCompleto);
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNombre.Focus();
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            if (lbNombreApellido.Items.Count <= 0)
            {
                MessageBox.Show("No hay elementos para eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Seguro que querés borrar todos los elementos?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                lbNombreApellido.Items.Clear();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void btnBorrarSeleccionado(object sender, EventArgs e)
        {
            if (lbNombreApellido.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un elemento", "Atencion!!");
                return;
            }

            string seleccionado = lbNombreApellido.SelectedItem.ToString();

            DialogResult resultado = MessageBox.Show(
                "¿Seguro que quieres borrar el nombre seleccionado?",
                "Confirmacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (resultado == DialogResult.Yes)
            {
                lbNombreApellido.Items.Remove(seleccionado);
            }
        }
    }
}
