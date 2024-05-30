using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguraGeometricas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Cuadrado.Checked)
            {
                MessageBox.Show("Los datos de la figura cuadrado estan guardados");
            }
            if (Triangulo.Checked)
            {
                MessageBox.Show("Los datos de la figura triangulo estan guardados");
            }
            if (Circulo.Checked)
            {
                MessageBox.Show("Los datos de la figura circulo estan guardados");
            }
            if (Cubo.Checked)
            {
                MessageBox.Show("Los datos de la figura cubo estan guardados");
            }
            if (Esfera.Checked)
            {
                MessageBox.Show("Los datos de la figura esfera estan guardados");
            }
            if (PoligonoI.Checked)
            {
                MessageBox.Show("Los datos del poligono irregular estan guardados");
            }
            if (PoligonoR.Checked)
            {
                MessageBox.Show("Los datos del poligono regular estan guardados");
            }
            if (Prisma.Checked)
            {
                MessageBox.Show("Los datos de la figura prisma estan guardados");
            }
            if (Rectangulo.Checked)
            {
                MessageBox.Show("Los datos del rectangulo estan guardados");
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Datos.Clear();
            Rectangulo.Checked = false;
            Prisma.Checked = false;
            Cuadrado.Checked = false;
            PoligonoI.Checked = false;
            PoligonoR.Checked = false;
            Esfera.Checked = false;
            Cubo.Checked = false;
            Circulo.Checked = false;
            Triangulo.Checked = false;
        }

        private void Dibujo_Click(object sender, EventArgs e)
        {
            if (Cuadrado.Checked)
            {
                string rutaImagen = "D:\\cuarto semestre\poo\\fgeometricas\\imagenes\cuadrado";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (Triangulo.Checked)
            {
                string rutaImagen = "D:\\cuarto semestre\\poo\\fgeometricas\\imagenes\\triangulo.jpg";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (Circulo.Checked)
            {
                string rutaImagen = "D:\\cuarto semestre\\poo\\fgeometricas\\imagenes\\circulo.jpg";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (Cubo.Checked)
            {
                string rutaImagen = "D:\\cuarto semestre\\poo\\fgeometricas\\imagenes\\cubo.jpg";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (Esfera.Checked)
            {
                string rutaImagen = "D:\\cuarto semestre\\poo\\fgeometricas\\imagenes\\cubo.jpg";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (PoligonoI.Checked)
            {
                string rutaImagen = "D:\\cuarto semestre\\poo\\fgeometricas\\imagenes\\pirregular.jpg";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (PoligonoR.Checked)
            {
                string rutaImagen = "D:\\cuarto semestre\poo\\fgeometricas\\imagenes\\pregular.jpg";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (Prisma.Checked)
            {
                string rutaImagen = "D:\\cuarto semestre\\poo\\fgeometricas\\imagenes\\prisma.jpg";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (Rectangulo.Checked)
            {
                string rutaImagen = "D:\\cuarto semestre\\poo\\fgeometricas\\imagenes\\rectangulo.jpg";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
        }
    }
}
