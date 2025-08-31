namespace TP1_GRUPO_7
{
    partial class Frm_Ejercicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.gbElementos = new System.Windows.Forms.GroupBox();
            this.lbNombreApellido = new System.Windows.Forms.ListBox();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.BtnBorrarSeleccionado = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            this.gbElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(17, 96);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(81, 20);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre: ";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(17, 145);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(78, 20);
            this.lbApellido.TabIndex = 2;
            this.lbApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(126, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(112, 145);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(126, 20);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Location = new System.Drawing.Point(71, 188);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 43);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.btnAgregar);
            this.gbDatos.Controls.Add(this.lbNombre);
            this.gbDatos.Controls.Add(this.txtApellido);
            this.gbDatos.Controls.Add(this.lbApellido);
            this.gbDatos.Location = new System.Drawing.Point(33, 30);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatos.Size = new System.Drawing.Size(255, 260);
            this.gbDatos.TabIndex = 6;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Ingreso de datos";
            // 
            // gbElementos
            // 
            this.gbElementos.Controls.Add(this.lbNombreApellido);
            this.gbElementos.Location = new System.Drawing.Point(349, 30);
            this.gbElementos.Margin = new System.Windows.Forms.Padding(2);
            this.gbElementos.Name = "gbElementos";
            this.gbElementos.Padding = new System.Windows.Forms.Padding(2);
            this.gbElementos.Size = new System.Drawing.Size(243, 260);
            this.gbElementos.TabIndex = 7;
            this.gbElementos.TabStop = false;
            this.gbElementos.Text = "Elementos";
            // 
            // lbNombreApellido
            // 
            this.lbNombreApellido.FormattingEnabled = true;
            this.lbNombreApellido.Location = new System.Drawing.Point(13, 24);
            this.lbNombreApellido.Margin = new System.Windows.Forms.Padding(2);
            this.lbNombreApellido.Name = "lbNombreApellido";
            this.lbNombreApellido.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbNombreApellido.Size = new System.Drawing.Size(217, 134);
            this.lbNombreApellido.Sorted = true;
            this.lbNombreApellido.TabIndex = 0;
            // 
            // botonBorrar
            // 
            this.botonBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBorrar.Location = new System.Drawing.Point(349, 295);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(107, 35);
            this.botonBorrar.TabIndex = 8;
            this.botonBorrar.Text = "Borrar todo";
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // BtnBorrarSeleccionado
            // 
            this.BtnBorrarSeleccionado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBorrarSeleccionado.Location = new System.Drawing.Point(485, 295);
            this.BtnBorrarSeleccionado.Name = "BtnBorrarSeleccionado";
            this.BtnBorrarSeleccionado.Size = new System.Drawing.Size(107, 35);
            this.BtnBorrarSeleccionado.TabIndex = 9;
            this.BtnBorrarSeleccionado.Text = "Borrar seleccionado";
            this.BtnBorrarSeleccionado.UseVisualStyleBackColor = true;
            this.BtnBorrarSeleccionado.Click += new System.EventHandler(this.btnBorrarSeleccionado);
            // 
            // Frm_Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BtnBorrarSeleccionado);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.gbElementos);
            this.Controls.Add(this.gbDatos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Ejercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Ejercicio2_FormClosed);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbElementos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.GroupBox gbElementos;
        private System.Windows.Forms.ListBox lbNombreApellido;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.Button BtnBorrarSeleccionado;
    }
}