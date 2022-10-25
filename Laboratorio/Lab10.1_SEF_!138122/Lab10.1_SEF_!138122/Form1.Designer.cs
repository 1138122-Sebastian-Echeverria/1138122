namespace Lab10._1_SEF__138122
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
            this.Datos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.inputPrecio = new System.Windows.Forms.NumericUpDown();
            this.inputModelo = new System.Windows.Forms.NumericUpDown();
            this.inputDescripcion = new System.Windows.Forms.RichTextBox();
            this.inputDatos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.botonIVA = new System.Windows.Forms.Button();
            this.inputIVA = new System.Windows.Forms.NumericUpDown();
            this.outputPF = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IVA = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.outputDescripcion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.outputPrecio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OutputModelo = new System.Windows.Forms.Label();
            this.outputMarca = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botonActualizar = new System.Windows.Forms.Button();
            this.Datos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputModelo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputIVA)).BeginInit();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.tabPage1);
            this.Datos.Controls.Add(this.tabPage2);
            this.Datos.Cursor = System.Windows.Forms.Cursors.Default;
            this.Datos.Location = new System.Drawing.Point(12, 12);
            this.Datos.Name = "Datos";
            this.Datos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Datos.SelectedIndex = 0;
            this.Datos.Size = new System.Drawing.Size(505, 279);
            this.Datos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.inputPrecio);
            this.tabPage1.Controls.Add(this.inputModelo);
            this.tabPage1.Controls.Add(this.inputDescripcion);
            this.tabPage1.Controls.Add(this.inputDatos);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.inputMarca);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(497, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso de Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // inputPrecio
            // 
            this.inputPrecio.DecimalPlaces = 2;
            this.inputPrecio.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.inputPrecio.Location = new System.Drawing.Point(92, 110);
            this.inputPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.inputPrecio.Name = "inputPrecio";
            this.inputPrecio.Size = new System.Drawing.Size(345, 20);
            this.inputPrecio.TabIndex = 12;
            this.inputPrecio.ThousandsSeparator = true;
            // 
            // inputModelo
            // 
            this.inputModelo.Location = new System.Drawing.Point(92, 76);
            this.inputModelo.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.inputModelo.Minimum = new decimal(new int[] {
            2007,
            0,
            0,
            0});
            this.inputModelo.Name = "inputModelo";
            this.inputModelo.Size = new System.Drawing.Size(345, 20);
            this.inputModelo.TabIndex = 11;
            this.inputModelo.ThousandsSeparator = true;
            this.inputModelo.Value = new decimal(new int[] {
            2007,
            0,
            0,
            0});
            // 
            // inputDescripcion
            // 
            this.inputDescripcion.Location = new System.Drawing.Point(92, 136);
            this.inputDescripcion.Name = "inputDescripcion";
            this.inputDescripcion.Size = new System.Drawing.Size(345, 39);
            this.inputDescripcion.TabIndex = 10;
            this.inputDescripcion.Text = "";
            // 
            // inputDatos
            // 
            this.inputDatos.Location = new System.Drawing.Point(208, 181);
            this.inputDatos.Name = "inputDatos";
            this.inputDatos.Size = new System.Drawing.Size(94, 38);
            this.inputDatos.TabIndex = 9;
            this.inputDatos.Text = "Cargar Datos";
            this.inputDatos.UseVisualStyleBackColor = true;
            this.inputDatos.Click += new System.EventHandler(this.inputDatos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descripcion";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(23, 110);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(37, 13);
            this.label.TabIndex = 5;
            this.label.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modelo";
            // 
            // inputMarca
            // 
            this.inputMarca.Location = new System.Drawing.Point(92, 39);
            this.inputMarca.Name = "inputMarca";
            this.inputMarca.Size = new System.Drawing.Size(345, 20);
            this.inputMarca.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carro";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.botonIVA);
            this.tabPage2.Controls.Add(this.inputIVA);
            this.tabPage2.Controls.Add(this.outputPF);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.IVA);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.outputDescripcion);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.outputPrecio);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.OutputModelo);
            this.tabPage2.Controls.Add(this.outputMarca);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.botonActualizar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(497, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // botonIVA
            // 
            this.botonIVA.Location = new System.Drawing.Point(69, 198);
            this.botonIVA.Name = "botonIVA";
            this.botonIVA.Size = new System.Drawing.Size(97, 23);
            this.botonIVA.TabIndex = 14;
            this.botonIVA.Text = "Calcular Valor";
            this.botonIVA.UseVisualStyleBackColor = true;
            this.botonIVA.Click += new System.EventHandler(this.botonIVA_Click);
            // 
            // inputIVA
            // 
            this.inputIVA.DecimalPlaces = 2;
            this.inputIVA.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.inputIVA.Location = new System.Drawing.Point(69, 172);
            this.inputIVA.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputIVA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inputIVA.Name = "inputIVA";
            this.inputIVA.Size = new System.Drawing.Size(120, 20);
            this.inputIVA.TabIndex = 13;
            this.inputIVA.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // outputPF
            // 
            this.outputPF.AutoSize = true;
            this.outputPF.Location = new System.Drawing.Point(77, 234);
            this.outputPF.Name = "outputPF";
            this.outputPF.Size = new System.Drawing.Size(62, 13);
            this.outputPF.TabIndex = 12;
            this.outputPF.Text = "Precio Final";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Precio Final";
            // 
            // IVA
            // 
            this.IVA.AutoSize = true;
            this.IVA.Location = new System.Drawing.Point(30, 174);
            this.IVA.Name = "IVA";
            this.IVA.Size = new System.Drawing.Size(24, 13);
            this.IVA.TabIndex = 10;
            this.IVA.Text = "IVA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Descripcion";
            // 
            // outputDescripcion
            // 
            this.outputDescripcion.AutoSize = true;
            this.outputDescripcion.Location = new System.Drawing.Point(75, 143);
            this.outputDescripcion.Name = "outputDescripcion";
            this.outputDescripcion.Size = new System.Drawing.Size(63, 13);
            this.outputDescripcion.TabIndex = 8;
            this.outputDescripcion.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Precio";
            // 
            // outputPrecio
            // 
            this.outputPrecio.AutoSize = true;
            this.outputPrecio.Location = new System.Drawing.Point(75, 120);
            this.outputPrecio.Name = "outputPrecio";
            this.outputPrecio.Size = new System.Drawing.Size(37, 13);
            this.outputPrecio.TabIndex = 6;
            this.outputPrecio.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Modelo";
            // 
            // OutputModelo
            // 
            this.OutputModelo.AutoSize = true;
            this.OutputModelo.Location = new System.Drawing.Point(75, 94);
            this.OutputModelo.Name = "OutputModelo";
            this.OutputModelo.Size = new System.Drawing.Size(42, 13);
            this.OutputModelo.TabIndex = 4;
            this.OutputModelo.Text = "Modelo";
            // 
            // outputMarca
            // 
            this.outputMarca.AutoSize = true;
            this.outputMarca.Location = new System.Drawing.Point(75, 68);
            this.outputMarca.Name = "outputMarca";
            this.outputMarca.Size = new System.Drawing.Size(37, 13);
            this.outputMarca.TabIndex = 3;
            this.outputMarca.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Marca";
            // 
            // botonActualizar
            // 
            this.botonActualizar.Location = new System.Drawing.Point(6, 6);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(485, 39);
            this.botonActualizar.TabIndex = 0;
            this.botonActualizar.Text = "Refrescar";
            this.botonActualizar.UseVisualStyleBackColor = true;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 303);
            this.Controls.Add(this.Datos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Datos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputModelo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputIVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Datos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button inputDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label OutputModelo;
        private System.Windows.Forms.Label outputMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonActualizar;
        private System.Windows.Forms.NumericUpDown inputIVA;
        private System.Windows.Forms.Label outputPF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label IVA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label outputDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label outputPrecio;
        private System.Windows.Forms.NumericUpDown inputModelo;
        private System.Windows.Forms.RichTextBox inputDescripcion;
        private System.Windows.Forms.NumericUpDown inputPrecio;
        private System.Windows.Forms.Button botonIVA;
    }
}

