using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Guardar_Click(object sender, EventArgs e)
        {
            string Nombres = tb_Nombre.Text;
            string Apellidos = tb_Apellidos.Text;
            string Telefono = tb_Telefono.Text;
            string Estatura = tb_Estatura.Text;
            string Edad = tb_Edad.Text;

            string Genero = "";
            if (rb_Hombre.Checked)
            {
                Genero = "Hombre";
            }
            else if (rb_Mujer.Checked)
            {
                Genero = "Mujer";
            }

            string datos = $"Nombres: {Nombres}\r\nApellios: { Apellidos}\r\nTelefono: { Telefono} kg\r\nEstatura: { Estatura} cm\r\nEdad: {Edad} años\r\nGenero: { Genero}";

            string rutaarchivo = "C:/Users/moram/Documents/3Mdatos.txt"; 

            bool archivoExiste = File.Exists(rutaarchivo);

            Console.WriteLine(archivoExiste);
            if (archivoExiste == false) 
            { 
                File.WriteAllText(rutaarchivo, datos);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(rutaarchivo, true))
                {
                    if (archivoExiste)
                    {
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);
                }
            }
            MessageBox.Show("Datos guardados con exito:\n\n" + datos, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            tb_Nombre.Clear();
            tb_Apellidos.Clear();
            tb_Estatura.Clear();
            tb_Telefono.Clear();
            tb_Edad.Clear();
            rb_Hombre.Checked=false;
            rb_Mujer.Checked=false;
        }
    }
       
}
