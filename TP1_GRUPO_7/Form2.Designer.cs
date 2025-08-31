namespace TP1_GRUPO_7
{
    partial class Frm_Ejercicio1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbNombreAgregado = new System.Windows.Forms.ListBox();
            this.btnPasarItem = new System.Windows.Forms.Button();
            this.pasartodos = new System.Windows.Forms.Button();
            this.listNombrePasado = new System.Windows.Forms.ListBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBorrar1 = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btPasarDenuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(74, 34);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese su nombre:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(187, 31);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(133, 20);
            this.textNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Location = new System.Drawing.Point(350, 24);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 33);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbNombreAgregado
            // 
            this.lbNombreAgregado.FormattingEnabled = true;
            this.lbNombreAgregado.Location = new System.Drawing.Point(19, 79);
            this.lbNombreAgregado.Margin = new System.Windows.Forms.Padding(2);
            this.lbNombreAgregado.Name = "lbNombreAgregado";
            this.lbNombreAgregado.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbNombreAgregado.Size = new System.Drawing.Size(138, 199);
            this.lbNombreAgregado.TabIndex = 3;
            // 
            // btnPasarItem
            // 
            this.btnPasarItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarItem.Location = new System.Drawing.Point(219, 90);
            this.btnPasarItem.Name = "btnPasarItem";
            this.btnPasarItem.Size = new System.Drawing.Size(75, 30);
            this.btnPasarItem.TabIndex = 4;
            this.btnPasarItem.Text = ">";
            this.btnPasarItem.UseVisualStyleBackColor = true;
            this.btnPasarItem.Click += new System.EventHandler(this.btnPasarItem_Click);
            // 
            // pasartodos
            // 
            this.pasartodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pasartodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasartodos.Location = new System.Drawing.Point(219, 126);
            this.pasartodos.Name = "pasartodos";
            this.pasartodos.Size = new System.Drawing.Size(75, 30);
            this.pasartodos.TabIndex = 5;
            this.pasartodos.Text = ">>";
            this.pasartodos.UseVisualStyleBackColor = true;
            this.pasartodos.Click += new System.EventHandler(this.pasartodos_Click);
            // 
            // listNombrePasado
            // 
            this.listNombrePasado.FormattingEnabled = true;
            this.listNombrePasado.Location = new System.Drawing.Point(360, 79);
            this.listNombrePasado.Margin = new System.Windows.Forms.Padding(2);
            this.listNombrePasado.Name = "listNombrePasado";
            this.listNombrePasado.Size = new System.Drawing.Size(138, 199);
            this.listNombrePasado.TabIndex = 6;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Location = new System.Drawing.Point(206, 309);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(101, 35);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar todo";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBorrar1
            // 
            this.btnBorrar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar1.Location = new System.Drawing.Point(206, 257);
            this.btnBorrar1.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar1.Name = "btnBorrar1";
            this.btnBorrar1.Size = new System.Drawing.Size(100, 37);
            this.btnBorrar1.TabIndex = 8;
            this.btnBorrar1.Text = "Borrar seleccionado";
            this.btnBorrar1.UseVisualStyleBackColor = true;
            this.btnBorrar1.Click += new System.EventHandler(this.btnBorrar1_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Location = new System.Drawing.Point(219, 172);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 34);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "<";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btPasarDenuevo
            // 
            this.btPasarDenuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPasarDenuevo.Location = new System.Drawing.Point(219, 211);
            this.btPasarDenuevo.Name = "btPasarDenuevo";
            this.btPasarDenuevo.Size = new System.Drawing.Size(75, 35);
            this.btPasarDenuevo.TabIndex = 11;
            this.btPasarDenuevo.Text = "<<";
            this.btPasarDenuevo.UseVisualStyleBackColor = true;
            this.btPasarDenuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.btPasarDenuevo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBorrar1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.listNombrePasado);
            this.Controls.Add(this.pasartodos);
            this.Controls.Add(this.btnPasarItem);
            this.Controls.Add(this.lbNombreAgregado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Frm_Ejercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Ejercicio1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbNombreAgregado;
        private System.Windows.Forms.Button btnPasarItem;
        private System.Windows.Forms.Button pasartodos;
        private System.Windows.Forms.ListBox listNombrePasado;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBorrar1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btPasarDenuevo;
    }
}