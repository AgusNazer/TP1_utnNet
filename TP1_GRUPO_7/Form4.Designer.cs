namespace TP1_GRUPO_7
{
    partial class Frm_Ejercicio3
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
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rdFemenino = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnMostrarSeleccion = new System.Windows.Forms.Button();
            this.gbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.groupBoxProfesion = new System.Windows.Forms.GroupBox();
            this.checkBoxTester = new System.Windows.Forms.CheckBox();
            this.checkBoxReparador = new System.Windows.Forms.CheckBox();
            this.checkBoxProgramador = new System.Windows.Forms.CheckBox();
            this.checkBoxOperador = new System.Windows.Forms.CheckBox();
            this.checkBoxData = new System.Windows.Forms.CheckBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbSeleccionSexo = new System.Windows.Forms.Label();
            this.lbEstadoCivil = new System.Windows.Forms.Label();
            this.lbSelecEstCivil = new System.Windows.Forms.Label();
            this.lbOficio = new System.Windows.Forms.Label();
            this.lbSeleccionOficio = new System.Windows.Forms.Label();
            this.btnQuitarSeleccion = new System.Windows.Forms.Button();
            this.btnAgregarOficio = new System.Windows.Forms.Button();
            this.txtOficioPersonalizado = new System.Windows.Forms.TextBox();
            this.gbOficiosPersonalizados = new System.Windows.Forms.GroupBox();
            this.btnBorrarPersonalizados = new System.Windows.Forms.Button();
            this.gbGenero.SuspendLayout();
            this.gbEstadoCivil.SuspendLayout();
            this.groupBoxProfesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbMasculino);
            this.gbGenero.Controls.Add(this.rdFemenino);
            this.gbGenero.Location = new System.Drawing.Point(97, 33);
            this.gbGenero.Margin = new System.Windows.Forms.Padding(2);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Padding = new System.Windows.Forms.Padding(2);
            this.gbGenero.Size = new System.Drawing.Size(155, 112);
            this.gbGenero.TabIndex = 0;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "SEXO";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMasculino.Location = new System.Drawing.Point(10, 70);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(2);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdFemenino
            // 
            this.rdFemenino.AutoSize = true;
            this.rdFemenino.Checked = true;
            this.rdFemenino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdFemenino.Location = new System.Drawing.Point(10, 32);
            this.rdFemenino.Margin = new System.Windows.Forms.Padding(2);
            this.rdFemenino.Name = "rdFemenino";
            this.rdFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdFemenino.TabIndex = 0;
            this.rdFemenino.TabStop = true;
            this.rdFemenino.Text = "Femenino";
            this.rdFemenino.UseVisualStyleBackColor = true;
            // 
            // btnMostrarSeleccion
            // 
            this.btnMostrarSeleccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarSeleccion.Location = new System.Drawing.Point(97, 317);
            this.btnMostrarSeleccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarSeleccion.Name = "btnMostrarSeleccion";
            this.btnMostrarSeleccion.Size = new System.Drawing.Size(173, 25);
            this.btnMostrarSeleccion.TabIndex = 1;
            this.btnMostrarSeleccion.Text = "Mostrar lo que se seleccionó";
            this.btnMostrarSeleccion.UseVisualStyleBackColor = true;
            this.btnMostrarSeleccion.Click += new System.EventHandler(this.btnMostrarSeleccion_Click);
            // 
            // gbEstadoCivil
            // 
            this.gbEstadoCivil.Controls.Add(this.rbSoltero);
            this.gbEstadoCivil.Controls.Add(this.rbCasado);
            this.gbEstadoCivil.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.gbEstadoCivil.Location = new System.Drawing.Point(375, 33);
            this.gbEstadoCivil.Name = "gbEstadoCivil";
            this.gbEstadoCivil.Size = new System.Drawing.Size(179, 112);
            this.gbEstadoCivil.TabIndex = 2;
            this.gbEstadoCivil.TabStop = false;
            this.gbEstadoCivil.Text = "Estado Civil";
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSoltero.Location = new System.Drawing.Point(33, 70);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(58, 17);
            this.rbSoltero.TabIndex = 1;
            this.rbSoltero.Text = "Soltero";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Checked = true;
            this.rbCasado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCasado.Location = new System.Drawing.Point(33, 32);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(61, 17);
            this.rbCasado.TabIndex = 0;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // groupBoxProfesion
            // 
            this.groupBoxProfesion.Controls.Add(this.checkBoxTester);
            this.groupBoxProfesion.Controls.Add(this.checkBoxReparador);
            this.groupBoxProfesion.Controls.Add(this.checkBoxProgramador);
            this.groupBoxProfesion.Controls.Add(this.checkBoxOperador);
            this.groupBoxProfesion.Controls.Add(this.checkBoxData);
            this.groupBoxProfesion.Location = new System.Drawing.Point(97, 167);
            this.groupBoxProfesion.Name = "groupBoxProfesion";
            this.groupBoxProfesion.Size = new System.Drawing.Size(110, 135);
            this.groupBoxProfesion.TabIndex = 3;
            this.groupBoxProfesion.TabStop = false;
            this.groupBoxProfesion.Text = "Oficio/s";
            // 
            // checkBoxTester
            // 
            this.checkBoxTester.AutoSize = true;
            this.checkBoxTester.Location = new System.Drawing.Point(6, 111);
            this.checkBoxTester.Name = "checkBoxTester";
            this.checkBoxTester.Size = new System.Drawing.Size(56, 17);
            this.checkBoxTester.TabIndex = 4;
            this.checkBoxTester.Text = "Tester";
            this.checkBoxTester.UseVisualStyleBackColor = true;
            // 
            // checkBoxReparador
            // 
            this.checkBoxReparador.AutoSize = true;
            this.checkBoxReparador.Location = new System.Drawing.Point(6, 88);
            this.checkBoxReparador.Name = "checkBoxReparador";
            this.checkBoxReparador.Size = new System.Drawing.Size(76, 17);
            this.checkBoxReparador.TabIndex = 3;
            this.checkBoxReparador.Text = "Reparador";
            this.checkBoxReparador.UseVisualStyleBackColor = true;
            // 
            // checkBoxProgramador
            // 
            this.checkBoxProgramador.AutoSize = true;
            this.checkBoxProgramador.Location = new System.Drawing.Point(6, 65);
            this.checkBoxProgramador.Name = "checkBoxProgramador";
            this.checkBoxProgramador.Size = new System.Drawing.Size(86, 17);
            this.checkBoxProgramador.TabIndex = 2;
            this.checkBoxProgramador.Text = "Prorgamador";
            this.checkBoxProgramador.UseVisualStyleBackColor = true;
            // 
            // checkBoxOperador
            // 
            this.checkBoxOperador.AutoSize = true;
            this.checkBoxOperador.Location = new System.Drawing.Point(6, 42);
            this.checkBoxOperador.Name = "checkBoxOperador";
            this.checkBoxOperador.Size = new System.Drawing.Size(102, 17);
            this.checkBoxOperador.TabIndex = 1;
            this.checkBoxOperador.Text = "Operador de PC";
            this.checkBoxOperador.UseVisualStyleBackColor = true;
            // 
            // checkBoxData
            // 
            this.checkBoxData.AutoSize = true;
            this.checkBoxData.Location = new System.Drawing.Point(6, 19);
            this.checkBoxData.Name = "checkBoxData";
            this.checkBoxData.Size = new System.Drawing.Size(76, 17);
            this.checkBoxData.TabIndex = 0;
            this.checkBoxData.Text = "Data Entry";
            this.checkBoxData.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(168, 353);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(321, 17);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Usted seleccionó los siguientes elementos:";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.Location = new System.Drawing.Point(90, 379);
            this.lbSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(53, 17);
            this.lbSexo.TabIndex = 5;
            this.lbSexo.Text = "Sexo: ";
            // 
            // lbSeleccionSexo
            // 
            this.lbSeleccionSexo.AutoSize = true;
            this.lbSeleccionSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeleccionSexo.Location = new System.Drawing.Point(138, 379);
            this.lbSeleccionSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSeleccionSexo.Name = "lbSeleccionSexo";
            this.lbSeleccionSexo.Size = new System.Drawing.Size(114, 17);
            this.lbSeleccionSexo.TabIndex = 6;
            this.lbSeleccionSexo.Text = "seleccion sexo";
            // 
            // lbEstadoCivil
            // 
            this.lbEstadoCivil.AutoSize = true;
            this.lbEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstadoCivil.Location = new System.Drawing.Point(90, 402);
            this.lbEstadoCivil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEstadoCivil.Name = "lbEstadoCivil";
            this.lbEstadoCivil.Size = new System.Drawing.Size(98, 17);
            this.lbEstadoCivil.TabIndex = 7;
            this.lbEstadoCivil.Text = "Estado Civil:";
            // 
            // lbSelecEstCivil
            // 
            this.lbSelecEstCivil.AutoSize = true;
            this.lbSelecEstCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelecEstCivil.Location = new System.Drawing.Point(182, 402);
            this.lbSelecEstCivil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSelecEstCivil.Name = "lbSelecEstCivil";
            this.lbSelecEstCivil.Size = new System.Drawing.Size(168, 17);
            this.lbSelecEstCivil.TabIndex = 8;
            this.lbSelecEstCivil.Text = "Seleccion Estado Civil";
            // 
            // lbOficio
            // 
            this.lbOficio.AutoSize = true;
            this.lbOficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOficio.Location = new System.Drawing.Point(90, 426);
            this.lbOficio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOficio.Name = "lbOficio";
            this.lbOficio.Size = new System.Drawing.Size(68, 17);
            this.lbOficio.TabIndex = 9;
            this.lbOficio.Text = "Oficio/s:";
            // 
            // lbSeleccionOficio
            // 
            this.lbSeleccionOficio.AutoSize = true;
            this.lbSeleccionOficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeleccionOficio.Location = new System.Drawing.Point(90, 443);
            this.lbSeleccionOficio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSeleccionOficio.Name = "lbSeleccionOficio";
            this.lbSeleccionOficio.Size = new System.Drawing.Size(135, 17);
            this.lbSeleccionOficio.TabIndex = 10;
            this.lbSeleccionOficio.Text = "Selección oficio/s";
            // 
            // btnQuitarSeleccion
            // 
            this.btnQuitarSeleccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarSeleccion.Location = new System.Drawing.Point(410, 317);
            this.btnQuitarSeleccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarSeleccion.Name = "btnQuitarSeleccion";
            this.btnQuitarSeleccion.Size = new System.Drawing.Size(144, 25);
            this.btnQuitarSeleccion.TabIndex = 2;
            this.btnQuitarSeleccion.Text = "Quitar lo seleccionado";
            this.btnQuitarSeleccion.UseVisualStyleBackColor = true;
            this.btnQuitarSeleccion.Click += new System.EventHandler(this.btnQuitarSeleccion_Click);
            // 
            // btnAgregarOficio
            // 
            this.btnAgregarOficio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarOficio.Location = new System.Drawing.Point(443, 200);
            this.btnAgregarOficio.Name = "btnAgregarOficio";
            this.btnAgregarOficio.Size = new System.Drawing.Size(111, 33);
            this.btnAgregarOficio.TabIndex = 11;
            this.btnAgregarOficio.Text = "Agregar oficio";
            this.btnAgregarOficio.UseVisualStyleBackColor = true;
            this.btnAgregarOficio.Click += new System.EventHandler(this.btnAgregarOficio_Click);
            // 
            // txtOficioPersonalizado
            // 
            this.txtOficioPersonalizado.Location = new System.Drawing.Point(443, 174);
            this.txtOficioPersonalizado.Name = "txtOficioPersonalizado";
            this.txtOficioPersonalizado.Size = new System.Drawing.Size(111, 20);
            this.txtOficioPersonalizado.TabIndex = 12;
            // 
            // gbOficiosPersonalizados
            // 
            this.gbOficiosPersonalizados.Location = new System.Drawing.Point(213, 167);
            this.gbOficiosPersonalizados.Name = "gbOficiosPersonalizados";
            this.gbOficiosPersonalizados.Size = new System.Drawing.Size(224, 135);
            this.gbOficiosPersonalizados.TabIndex = 13;
            this.gbOficiosPersonalizados.TabStop = false;
            this.gbOficiosPersonalizados.Text = "Oficios personalizados";
            // 
            // btnBorrarPersonalizados
            // 
            this.btnBorrarPersonalizados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarPersonalizados.Location = new System.Drawing.Point(443, 240);
            this.btnBorrarPersonalizados.Name = "btnBorrarPersonalizados";
            this.btnBorrarPersonalizados.Size = new System.Drawing.Size(111, 41);
            this.btnBorrarPersonalizados.TabIndex = 14;
            this.btnBorrarPersonalizados.Text = "Borrar personalizados";
            this.btnBorrarPersonalizados.UseVisualStyleBackColor = true;
            this.btnBorrarPersonalizados.Click += new System.EventHandler(this.btnBorrarPersonalizados_Click);
            // 
            // Frm_Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 639);
            this.Controls.Add(this.btnBorrarPersonalizados);
            this.Controls.Add(this.gbOficiosPersonalizados);
            this.Controls.Add(this.txtOficioPersonalizado);
            this.Controls.Add(this.btnAgregarOficio);
            this.Controls.Add(this.btnQuitarSeleccion);
            this.Controls.Add(this.lbSeleccionOficio);
            this.Controls.Add(this.lbOficio);
            this.Controls.Add(this.lbSelecEstCivil);
            this.Controls.Add(this.lbEstadoCivil);
            this.Controls.Add(this.lbSeleccionSexo);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.groupBoxProfesion);
            this.Controls.Add(this.gbEstadoCivil);
            this.Controls.Add(this.btnMostrarSeleccion);
            this.Controls.Add(this.gbGenero);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Frm_Ejercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Ejercicio3_FormClosed);
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.gbEstadoCivil.ResumeLayout(false);
            this.gbEstadoCivil.PerformLayout();
            this.groupBoxProfesion.ResumeLayout(false);
            this.groupBoxProfesion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGenero;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rdFemenino;
        private System.Windows.Forms.Button btnMostrarSeleccion;
        private System.Windows.Forms.GroupBox gbEstadoCivil;
        private System.Windows.Forms.RadioButton rbSoltero;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.GroupBox groupBoxProfesion;
        private System.Windows.Forms.CheckBox checkBoxData;
        private System.Windows.Forms.CheckBox checkBoxOperador;
        private System.Windows.Forms.CheckBox checkBoxReparador;
        private System.Windows.Forms.CheckBox checkBoxProgramador;
        private System.Windows.Forms.CheckBox checkBoxTester;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbSeleccionSexo;
        private System.Windows.Forms.Label lbEstadoCivil;
        private System.Windows.Forms.Label lbSelecEstCivil;
        private System.Windows.Forms.Label lbOficio;
        private System.Windows.Forms.Label lbSeleccionOficio;
        private System.Windows.Forms.Button btnQuitarSeleccion;
        private System.Windows.Forms.Button btnAgregarOficio;
        private System.Windows.Forms.TextBox txtOficioPersonalizado;
        private System.Windows.Forms.GroupBox gbOficiosPersonalizados;
        private System.Windows.Forms.Button btnBorrarPersonalizados;
    }
}