
namespace fgeometricas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datos = new System.Windows.Forms.TextBox();
            this.esfera = new System.Windows.Forms.RadioButton();
            this.prisma = new System.Windows.Forms.RadioButton();
            this.irregular = new System.Windows.Forms.RadioButton();
            this.cubo = new System.Windows.Forms.RadioButton();
            this.rectangulo = new System.Windows.Forms.RadioButton();
            this.circulo = new System.Windows.Forms.RadioButton();
            this.triangulo = new System.Windows.Forms.RadioButton();
            this.regular = new System.Windows.Forms.RadioButton();
            this.cuadrado = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.exportar = new System.Windows.Forms.Button();
            this.dibujar = new System.Windows.Forms.Button();
            this.informacion = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.RichTextBox();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datos);
            this.groupBox1.Controls.Add(this.esfera);
            this.groupBox1.Controls.Add(this.prisma);
            this.groupBox1.Controls.Add(this.irregular);
            this.groupBox1.Controls.Add(this.cubo);
            this.groupBox1.Controls.Add(this.rectangulo);
            this.groupBox1.Controls.Add(this.circulo);
            this.groupBox1.Controls.Add(this.triangulo);
            this.groupBox1.Controls.Add(this.regular);
            this.groupBox1.Controls.Add(this.cuadrado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.calcular);
            this.groupBox1.Controls.Add(this.limpiar);
            this.groupBox1.Controls.Add(this.exportar);
            this.groupBox1.Controls.Add(this.dibujar);
            this.groupBox1.Controls.Add(this.informacion);
            this.groupBox1.Controls.Add(this.guardar);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // datos
            // 
            this.datos.Location = new System.Drawing.Point(243, 93);
            this.datos.Name = "datos";
            this.datos.Size = new System.Drawing.Size(251, 20);
            this.datos.TabIndex = 17;
            // 
            // esfera
            // 
            this.esfera.AutoSize = true;
            this.esfera.Location = new System.Drawing.Point(555, 41);
            this.esfera.Name = "esfera";
            this.esfera.Size = new System.Drawing.Size(67, 17);
            this.esfera.TabIndex = 16;
            this.esfera.TabStop = true;
            this.esfera.Text = "ESFERA";
            this.esfera.UseVisualStyleBackColor = true;
            // 
            // prisma
            // 
            this.prisma.AutoSize = true;
            this.prisma.Location = new System.Drawing.Point(384, 64);
            this.prisma.Name = "prisma";
            this.prisma.Size = new System.Drawing.Size(66, 17);
            this.prisma.TabIndex = 15;
            this.prisma.TabStop = true;
            this.prisma.Text = "PRISMA";
            this.prisma.UseVisualStyleBackColor = true;
            // 
            // irregular
            // 
            this.irregular.AutoSize = true;
            this.irregular.Location = new System.Drawing.Point(384, 41);
            this.irregular.Name = "irregular";
            this.irregular.Size = new System.Drawing.Size(147, 17);
            this.irregular.TabIndex = 14;
            this.irregular.TabStop = true;
            this.irregular.Text = "POLIGONO IRREGULAR";
            this.irregular.UseVisualStyleBackColor = true;
            // 
            // cubo
            // 
            this.cubo.AutoSize = true;
            this.cubo.Location = new System.Drawing.Point(270, 64);
            this.cubo.Name = "cubo";
            this.cubo.Size = new System.Drawing.Size(55, 17);
            this.cubo.TabIndex = 13;
            this.cubo.TabStop = true;
            this.cubo.Text = "CUBO";
            this.cubo.UseVisualStyleBackColor = true;
            // 
            // rectangulo
            // 
            this.rectangulo.AutoSize = true;
            this.rectangulo.Location = new System.Drawing.Point(270, 41);
            this.rectangulo.Name = "rectangulo";
            this.rectangulo.Size = new System.Drawing.Size(99, 17);
            this.rectangulo.TabIndex = 12;
            this.rectangulo.TabStop = true;
            this.rectangulo.Text = "RECTANGULO";
            this.rectangulo.UseVisualStyleBackColor = true;
            // 
            // circulo
            // 
            this.circulo.AutoSize = true;
            this.circulo.Location = new System.Drawing.Point(167, 64);
            this.circulo.Name = "circulo";
            this.circulo.Size = new System.Drawing.Size(72, 17);
            this.circulo.TabIndex = 11;
            this.circulo.TabStop = true;
            this.circulo.Text = "CIRCULO";
            this.circulo.UseVisualStyleBackColor = true;
            // 
            // triangulo
            // 
            this.triangulo.AutoSize = true;
            this.triangulo.Location = new System.Drawing.Point(167, 41);
            this.triangulo.Name = "triangulo";
            this.triangulo.Size = new System.Drawing.Size(88, 17);
            this.triangulo.TabIndex = 10;
            this.triangulo.TabStop = true;
            this.triangulo.Text = "TRIANGULO";
            this.triangulo.UseVisualStyleBackColor = true;
            // 
            // regular
            // 
            this.regular.AutoSize = true;
            this.regular.Location = new System.Drawing.Point(26, 64);
            this.regular.Name = "regular";
            this.regular.Size = new System.Drawing.Size(136, 17);
            this.regular.TabIndex = 9;
            this.regular.TabStop = true;
            this.regular.Text = "POLIGONO REGULAR";
            this.regular.UseVisualStyleBackColor = true;
            // 
            // cuadrado
            // 
            this.cuadrado.AutoSize = true;
            this.cuadrado.Location = new System.Drawing.Point(26, 41);
            this.cuadrado.Name = "cuadrado";
            this.cuadrado.Size = new System.Drawing.Size(86, 17);
            this.cuadrado.TabIndex = 8;
            this.cuadrado.TabStop = true;
            this.cuadrado.Text = "CUADRADO";
            this.cuadrado.UseVisualStyleBackColor = true;
            this.cuadrado.CheckedChanged += new System.EventHandler(this.cuadrado_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingresa medidas del lado, arista, radio, etc...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "CONSTRUCTOR DE FIGURAS GEOMETRICAS";
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(462, 128);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(88, 24);
            this.calcular.TabIndex = 5;
            this.calcular.Text = "calcular";
            this.calcular.UseVisualStyleBackColor = true;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(351, 128);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(88, 24);
            this.limpiar.TabIndex = 4;
            this.limpiar.Text = "limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            // 
            // exportar
            // 
            this.exportar.Location = new System.Drawing.Point(240, 128);
            this.exportar.Name = "exportar";
            this.exportar.Size = new System.Drawing.Size(88, 24);
            this.exportar.TabIndex = 3;
            this.exportar.Text = "exportar";
            this.exportar.UseVisualStyleBackColor = true;
            // 
            // dibujar
            // 
            this.dibujar.Location = new System.Drawing.Point(127, 128);
            this.dibujar.Name = "dibujar";
            this.dibujar.Size = new System.Drawing.Size(88, 24);
            this.dibujar.TabIndex = 2;
            this.dibujar.Text = "dibujar";
            this.dibujar.UseVisualStyleBackColor = true;
            // 
            // informacion
            // 
            this.informacion.Location = new System.Drawing.Point(20, 128);
            this.informacion.Name = "informacion";
            this.informacion.Size = new System.Drawing.Size(88, 24);
            this.informacion.TabIndex = 1;
            this.informacion.Text = "informacion";
            this.informacion.UseVisualStyleBackColor = true;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(574, 128);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(88, 24);
            this.guardar.TabIndex = 0;
            this.guardar.Text = "guardar";
            this.guardar.UseVisualStyleBackColor = true;
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(363, 192);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(311, 237);
            this.info.TabIndex = 1;
            this.info.Text = "";
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(32, 192);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(325, 237);
            this.imagen.TabIndex = 2;
            this.imagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.info);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button informacion;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.RadioButton regular;
        private System.Windows.Forms.RadioButton cuadrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button exportar;
        private System.Windows.Forms.Button dibujar;
        private System.Windows.Forms.TextBox datos;
        private System.Windows.Forms.RadioButton esfera;
        private System.Windows.Forms.RadioButton prisma;
        private System.Windows.Forms.RadioButton irregular;
        private System.Windows.Forms.RadioButton cubo;
        private System.Windows.Forms.RadioButton rectangulo;
        private System.Windows.Forms.RadioButton circulo;
        private System.Windows.Forms.RadioButton triangulo;
        private System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.PictureBox imagen;
    }
}

