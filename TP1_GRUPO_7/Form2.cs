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
    public partial class Frm_Ejercicio1 : Form
    {
        FormPrincipal formPrincipal;

        public Frm_Ejercicio1(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            this.AcceptButton = btnAgregar;
        }

        private void Frm_Ejercicio1_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach(string nombre in lbNombreAgregado.Items)
            {
                if(textNombre.Text.ToLower().Trim() == nombre.ToLower().Trim())
                {
                    MessageBox.Show("El nombre ingresado ya existe", "Atencion");
                    return;
                }
              
            }
            //recorre cada caracter y detecta si hay un numero.
            if(textNombre.Text.Trim().Any(char.IsDigit))
            {
                MessageBox.Show("El nombre ingresado no es valido");
                return;
            }

            foreach (string nombre in listNombrePasado.Items)
            {
                if (textNombre.Text.ToLower() == nombre.ToLower())
                {
                    MessageBox.Show("El nombre ingresado ya existe", "Atencion");
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("El nombre no es válido", "Atencion");
                return;
            }

            lbNombreAgregado.Items.Add(textNombre.Text.Trim());

            textNombre.Text = "";

            textNombre.Focus();
        }

        private void btnPasarItem_Click(object sender, EventArgs e)
        {
            // para seleccionar varios nombrs usar la propiedad selectedItems
            if (lbNombreAgregado.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un nombre de la lista");
                return;
            }

            //mover todos los seleccionados
            while (lbNombreAgregado.SelectedItems.Count > 0)
            {
                var nombre = lbNombreAgregado.SelectedItems[0];
                listNombrePasado.Items.Add(nombre);
                lbNombreAgregado.Items.Remove(nombre);
            }

        }

        private void pasartodos_Click(object sender, EventArgs e)
        {
            if (lbNombreAgregado.Items.Count == 0)
            {
                MessageBox.Show("Todavia no hay ningun item");
                return;
            }

            foreach(string nombres in lbNombreAgregado.Items)
            {
                listNombrePasado.Items.Add(nombres);
            }

            lbNombreAgregado.Items.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Seguro que querés borrar todos los elementos?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                listNombrePasado.Items.Clear();
            }
        }

        private void btnBorrar1_Click(object sender, EventArgs e)
        {
            if (listNombrePasado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un nombre", "Atención!");
                return;
            }
            string seleecionado = listNombrePasado.SelectedItem.ToString();

            DialogResult resultado = MessageBox.Show(
                "seguro que queres borrar el nombre seleccionado?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                listNombrePasado.Items.Remove(seleecionado);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (listNombrePasado.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccion al menos un items", "Atencion");
            }

            while (listNombrePasado.SelectedItems.Count > 0)
            {
                var Nombre = listNombrePasado.SelectedItems[0];

                lbNombreAgregado.Items.Add(Nombre);
                listNombrePasado.Items.Remove(Nombre);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listNombrePasado.Items.Count == 0)
            {
                MessageBox.Show("Todavia no hay ningun item");
                return;
            }

            foreach (string nombres in listNombrePasado.Items)
            {
                lbNombreAgregado.Items.Add(nombres);
            }

            listNombrePasado.Items.Clear();
        }
    }
}
