namespace Proyecto_5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Estatura = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.gb_Genero = new System.Windows.Forms.GroupBox();
            this.rb_Mujer = new System.Windows.Forms.RadioButton();
            this.rb_Hombre = new System.Windows.Forms.RadioButton();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.tb_Apellidos = new System.Windows.Forms.TextBox();
            this.tb_Telefono = new System.Windows.Forms.TextBox();
            this.tb_Estatura = new System.Windows.Forms.TextBox();
            this.tb_Edad = new System.Windows.Forms.TextBox();
            this.bt_Guardar = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.gb_Genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(59, 30);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(52, 15);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellidos.Location = new System.Drawing.Point(52, 68);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(59, 15);
            this.lbl_Apellidos.TabIndex = 1;
            this.lbl_Apellidos.Text = "Apellidos";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.Location = new System.Drawing.Point(59, 106);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(55, 15);
            this.lbl_Telefono.TabIndex = 2;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // lbl_Estatura
            // 
            this.lbl_Estatura.AutoSize = true;
            this.lbl_Estatura.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estatura.Location = new System.Drawing.Point(56, 145);
            this.lbl_Estatura.Name = "lbl_Estatura";
            this.lbl_Estatura.Size = new System.Drawing.Size(55, 15);
            this.lbl_Estatura.TabIndex = 3;
            this.lbl_Estatura.Text = "Estatura";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Edad.Location = new System.Drawing.Point(76, 187);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(35, 15);
            this.lbl_Edad.TabIndex = 4;
            this.lbl_Edad.Text = "Edad";
            // 
            // gb_Genero
            // 
            this.gb_Genero.Controls.Add(this.rb_Mujer);
            this.gb_Genero.Controls.Add(this.rb_Hombre);
            this.gb_Genero.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Genero.Location = new System.Drawing.Point(107, 242);
            this.gb_Genero.Name = "gb_Genero";
            this.gb_Genero.Size = new System.Drawing.Size(172, 68);
            this.gb_Genero.TabIndex = 5;
            this.gb_Genero.TabStop = false;
            this.gb_Genero.Text = "Genero";
            // 
            // rb_Mujer
            // 
            this.rb_Mujer.AutoSize = true;
            this.rb_Mujer.Location = new System.Drawing.Point(109, 20);
            this.rb_Mujer.Name = "rb_Mujer";
            this.rb_Mujer.Size = new System.Drawing.Size(57, 19);
            this.rb_Mujer.TabIndex = 1;
            this.rb_Mujer.TabStop = true;
            this.rb_Mujer.Text = "Mujer";
            this.rb_Mujer.UseVisualStyleBackColor = true;
            // 
            // rb_Hombre
            // 
            this.rb_Hombre.AutoSize = true;
            this.rb_Hombre.Location = new System.Drawing.Point(7, 20);
            this.rb_Hombre.Name = "rb_Hombre";
            this.rb_Hombre.Size = new System.Drawing.Size(70, 19);
            this.rb_Hombre.TabIndex = 0;
            this.rb_Hombre.TabStop = true;
            this.rb_Hombre.Text = "Hombre";
            this.rb_Hombre.UseVisualStyleBackColor = true;
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(147, 30);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(100, 20);
            this.tb_Nombre.TabIndex = 6;
            // 
            // tb_Apellidos
            // 
            this.tb_Apellidos.Location = new System.Drawing.Point(147, 63);
            this.tb_Apellidos.Name = "tb_Apellidos";
            this.tb_Apellidos.Size = new System.Drawing.Size(100, 20);
            this.tb_Apellidos.TabIndex = 7;
            // 
            // tb_Telefono
            // 
            this.tb_Telefono.Location = new System.Drawing.Point(147, 106);
            this.tb_Telefono.Name = "tb_Telefono";
            this.tb_Telefono.Size = new System.Drawing.Size(100, 20);
            this.tb_Telefono.TabIndex = 8;
            // 
            // tb_Estatura
            // 
            this.tb_Estatura.Location = new System.Drawing.Point(147, 145);
            this.tb_Estatura.Name = "tb_Estatura";
            this.tb_Estatura.Size = new System.Drawing.Size(100, 20);
            this.tb_Estatura.TabIndex = 9;
            // 
            // tb_Edad
            // 
            this.tb_Edad.Location = new System.Drawing.Point(147, 185);
            this.tb_Edad.Name = "tb_Edad";
            this.tb_Edad.Size = new System.Drawing.Size(100, 20);
            this.tb_Edad.TabIndex = 10;
            // 
            // bt_Guardar
            // 
            this.bt_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Guardar.Location = new System.Drawing.Point(157, 336);
            this.bt_Guardar.Name = "bt_Guardar";
            this.bt_Guardar.Size = new System.Drawing.Size(90, 44);
            this.bt_Guardar.TabIndex = 11;
            this.bt_Guardar.Text = "Guardar";
            this.bt_Guardar.UseVisualStyleBackColor = true;
            this.bt_Guardar.Click += new System.EventHandler(this.bt_Guardar_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancelar.Location = new System.Drawing.Point(157, 401);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(90, 43);
            this.bt_Cancelar.TabIndex = 12;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            this.bt_Cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 497);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Guardar);
            this.Controls.Add(this.tb_Edad);
            this.Controls.Add(this.tb_Estatura);
            this.Controls.Add(this.tb_Telefono);
            this.Controls.Add(this.tb_Apellidos);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.gb_Genero);
            this.Controls.Add(this.lbl_Edad);
            this.Controls.Add(this.lbl_Estatura);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Apellidos);
            this.Controls.Add(this.lbl_Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_Genero.ResumeLayout(false);
            this.gb_Genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Estatura;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.GroupBox gb_Genero;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.TextBox tb_Apellidos;
        private System.Windows.Forms.TextBox tb_Telefono;
        private System.Windows.Forms.TextBox tb_Estatura;
        private System.Windows.Forms.TextBox tb_Edad;
        private System.Windows.Forms.Button bt_Guardar;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.RadioButton rb_Mujer;
        private System.Windows.Forms.RadioButton rb_Hombre;
    }
}

