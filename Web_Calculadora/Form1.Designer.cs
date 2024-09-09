namespace Web_Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_cero = new System.Windows.Forms.Button();
            this.btn_punto = new System.Windows.Forms.Button();
            this.btn_signo = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_menos = new System.Windows.Forms.Button();
            this.btn_mas = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btn_potencial = new System.Windows.Forms.Button();
            this.btn_raiz = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_borrartodo = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_nueve = new System.Windows.Forms.Button();
            this.btn_ocho = new System.Windows.Forms.Button();
            this.btn_siete = new System.Windows.Forms.Button();
            this.btn_seis = new System.Windows.Forms.Button();
            this.btn_cinco = new System.Windows.Forms.Button();
            this.btn_cuatro = new System.Windows.Forms.Button();
            this.btn_tres = new System.Windows.Forms.Button();
            this.btn_dos = new System.Windows.Forms.Button();
            this.btn_uno = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_resultado
            // 
            this.txt_resultado.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_resultado.Location = new System.Drawing.Point(12, 34);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(374, 65);
            this.txt_resultado.TabIndex = 0;
            this.txt_resultado.Text = "0";
            this.txt_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(354, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuText;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(303, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 53);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.txt_resultado);
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 125);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Controls.Add(this.btn_cero);
            this.panel3.Controls.Add(this.btn_punto);
            this.panel3.Controls.Add(this.btn_signo);
            this.panel3.Controls.Add(this.btn_igual);
            this.panel3.Controls.Add(this.btn_menos);
            this.panel3.Controls.Add(this.btn_mas);
            this.panel3.Controls.Add(this.btn_multiplicar);
            this.panel3.Controls.Add(this.btn_dividir);
            this.panel3.Controls.Add(this.btn_potencial);
            this.panel3.Controls.Add(this.btn_raiz);
            this.panel3.Controls.Add(this.btn_quitar);
            this.panel3.Controls.Add(this.btn_borrartodo);
            this.panel3.Controls.Add(this.btn_borrar);
            this.panel3.Controls.Add(this.btn_nueve);
            this.panel3.Controls.Add(this.btn_ocho);
            this.panel3.Controls.Add(this.btn_siete);
            this.panel3.Controls.Add(this.btn_seis);
            this.panel3.Controls.Add(this.btn_cinco);
            this.panel3.Controls.Add(this.btn_cuatro);
            this.panel3.Controls.Add(this.btn_tres);
            this.panel3.Controls.Add(this.btn_dos);
            this.panel3.Controls.Add(this.btn_uno);
            this.panel3.Location = new System.Drawing.Point(0, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 332);
            this.panel3.TabIndex = 5;
            // 
            // btn_cero
            // 
            this.btn_cero.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_cero.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cero.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cero.Location = new System.Drawing.Point(93, 265);
            this.btn_cero.Name = "btn_cero";
            this.btn_cero.Size = new System.Drawing.Size(64, 59);
            this.btn_cero.TabIndex = 21;
            this.btn_cero.Text = "0";
            this.btn_cero.UseVisualStyleBackColor = false;
            this.btn_cero.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btn_punto
            // 
            this.btn_punto.BackColor = System.Drawing.Color.Peru;
            this.btn_punto.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_punto.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_punto.Location = new System.Drawing.Point(175, 265);
            this.btn_punto.Name = "btn_punto";
            this.btn_punto.Size = new System.Drawing.Size(64, 59);
            this.btn_punto.TabIndex = 20;
            this.btn_punto.Text = ".";
            this.btn_punto.UseVisualStyleBackColor = false;
            this.btn_punto.Click += new System.EventHandler(this.btn_punto_Click);
            // 
            // btn_signo
            // 
            this.btn_signo.BackColor = System.Drawing.Color.Peru;
            this.btn_signo.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_signo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_signo.Location = new System.Drawing.Point(14, 265);
            this.btn_signo.Name = "btn_signo";
            this.btn_signo.Size = new System.Drawing.Size(64, 59);
            this.btn_signo.TabIndex = 19;
            this.btn_signo.Text = "±";
            this.btn_signo.UseVisualStyleBackColor = false;
            this.btn_signo.Click += new System.EventHandler(this.btn_signo_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.BackColor = System.Drawing.Color.Peru;
            this.btn_igual.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_igual.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_igual.Location = new System.Drawing.Point(258, 200);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(128, 124);
            this.btn_igual.TabIndex = 18;
            this.btn_igual.Tag = "=";
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = false;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_menos
            // 
            this.btn_menos.BackColor = System.Drawing.Color.Peru;
            this.btn_menos.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_menos.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_menos.Location = new System.Drawing.Point(325, 135);
            this.btn_menos.Name = "btn_menos";
            this.btn_menos.Size = new System.Drawing.Size(61, 59);
            this.btn_menos.TabIndex = 17;
            this.btn_menos.Tag = "-";
            this.btn_menos.Text = "-";
            this.btn_menos.UseVisualStyleBackColor = false;
            this.btn_menos.Click += new System.EventHandler(this.clickoperador);
            // 
            // btn_mas
            // 
            this.btn_mas.BackColor = System.Drawing.Color.Peru;
            this.btn_mas.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mas.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_mas.Location = new System.Drawing.Point(258, 135);
            this.btn_mas.Name = "btn_mas";
            this.btn_mas.Size = new System.Drawing.Size(64, 59);
            this.btn_mas.TabIndex = 16;
            this.btn_mas.Tag = "+";
            this.btn_mas.Text = "+";
            this.btn_mas.UseVisualStyleBackColor = false;
            this.btn_mas.Click += new System.EventHandler(this.clickoperador);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.BackColor = System.Drawing.Color.Peru;
            this.btn_multiplicar.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_multiplicar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_multiplicar.Location = new System.Drawing.Point(325, 70);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(61, 59);
            this.btn_multiplicar.TabIndex = 15;
            this.btn_multiplicar.Tag = "*";
            this.btn_multiplicar.Text = "X";
            this.btn_multiplicar.UseVisualStyleBackColor = false;
            this.btn_multiplicar.Click += new System.EventHandler(this.clickoperador);
            // 
            // btn_dividir
            // 
            this.btn_dividir.BackColor = System.Drawing.Color.Peru;
            this.btn_dividir.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dividir.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_dividir.Location = new System.Drawing.Point(258, 70);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(64, 59);
            this.btn_dividir.TabIndex = 14;
            this.btn_dividir.Tag = "/";
            this.btn_dividir.Text = "/";
            this.btn_dividir.UseVisualStyleBackColor = false;
            this.btn_dividir.Click += new System.EventHandler(this.clickoperador);
            // 
            // btn_potencial
            // 
            this.btn_potencial.BackColor = System.Drawing.Color.Peru;
            this.btn_potencial.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_potencial.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_potencial.Location = new System.Drawing.Point(325, 5);
            this.btn_potencial.Name = "btn_potencial";
            this.btn_potencial.Size = new System.Drawing.Size(61, 59);
            this.btn_potencial.TabIndex = 13;
            this.btn_potencial.Tag = "²";
            this.btn_potencial.Text = "X²";
            this.btn_potencial.UseVisualStyleBackColor = false;
            this.btn_potencial.Click += new System.EventHandler(this.clickoperador);
            // 
            // btn_raiz
            // 
            this.btn_raiz.BackColor = System.Drawing.Color.Peru;
            this.btn_raiz.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_raiz.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_raiz.Location = new System.Drawing.Point(258, 5);
            this.btn_raiz.Name = "btn_raiz";
            this.btn_raiz.Size = new System.Drawing.Size(61, 59);
            this.btn_raiz.TabIndex = 12;
            this.btn_raiz.Tag = "√";
            this.btn_raiz.Text = "√";
            this.btn_raiz.UseVisualStyleBackColor = false;
            this.btn_raiz.Click += new System.EventHandler(this.clickoperador);
            // 
            // btn_quitar
            // 
            this.btn_quitar.BackColor = System.Drawing.Color.Peru;
            this.btn_quitar.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_quitar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_quitar.Location = new System.Drawing.Point(175, 2);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(64, 59);
            this.btn_quitar.TabIndex = 11;
            this.btn_quitar.Text = "<-";
            this.btn_quitar.UseVisualStyleBackColor = false;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_borrartodo
            // 
            this.btn_borrartodo.BackColor = System.Drawing.Color.Peru;
            this.btn_borrartodo.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_borrartodo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_borrartodo.Location = new System.Drawing.Point(93, 2);
            this.btn_borrartodo.Name = "btn_borrartodo";
            this.btn_borrartodo.Size = new System.Drawing.Size(64, 59);
            this.btn_borrartodo.TabIndex = 10;
            this.btn_borrartodo.Text = "C";
            this.btn_borrartodo.UseVisualStyleBackColor = false;
            this.btn_borrartodo.Click += new System.EventHandler(this.btn_borrartodo_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackColor = System.Drawing.Color.Peru;
            this.btn_borrar.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_borrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_borrar.Location = new System.Drawing.Point(14, 2);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(64, 59);
            this.btn_borrar.TabIndex = 9;
            this.btn_borrar.Text = "CE";
            this.btn_borrar.UseVisualStyleBackColor = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_nueve
            // 
            this.btn_nueve.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_nueve.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_nueve.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_nueve.Location = new System.Drawing.Point(175, 70);
            this.btn_nueve.Name = "btn_nueve";
            this.btn_nueve.Size = new System.Drawing.Size(64, 59);
            this.btn_nueve.TabIndex = 8;
            this.btn_nueve.Text = "9";
            this.btn_nueve.UseVisualStyleBackColor = false;
            this.btn_nueve.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btn_ocho
            // 
            this.btn_ocho.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_ocho.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ocho.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ocho.Location = new System.Drawing.Point(93, 70);
            this.btn_ocho.Name = "btn_ocho";
            this.btn_ocho.Size = new System.Drawing.Size(64, 59);
            this.btn_ocho.TabIndex = 8;
            this.btn_ocho.Text = "8";
            this.btn_ocho.UseVisualStyleBackColor = false;
            this.btn_ocho.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btn_siete
            // 
            this.btn_siete.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_siete.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_siete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_siete.Location = new System.Drawing.Point(14, 70);
            this.btn_siete.Name = "btn_siete";
            this.btn_siete.Size = new System.Drawing.Size(64, 59);
            this.btn_siete.TabIndex = 6;
            this.btn_siete.Text = "7";
            this.btn_siete.UseVisualStyleBackColor = false;
            this.btn_siete.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btn_seis
            // 
            this.btn_seis.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_seis.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_seis.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_seis.Location = new System.Drawing.Point(175, 135);
            this.btn_seis.Name = "btn_seis";
            this.btn_seis.Size = new System.Drawing.Size(64, 59);
            this.btn_seis.TabIndex = 5;
            this.btn_seis.Text = "6";
            this.btn_seis.UseVisualStyleBackColor = false;
            this.btn_seis.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btn_cinco
            // 
            this.btn_cinco.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_cinco.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cinco.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cinco.Location = new System.Drawing.Point(93, 135);
            this.btn_cinco.Name = "btn_cinco";
            this.btn_cinco.Size = new System.Drawing.Size(64, 59);
            this.btn_cinco.TabIndex = 4;
            this.btn_cinco.Text = "5";
            this.btn_cinco.UseVisualStyleBackColor = false;
            this.btn_cinco.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btn_cuatro
            // 
            this.btn_cuatro.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_cuatro.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cuatro.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cuatro.Location = new System.Drawing.Point(14, 135);
            this.btn_cuatro.Name = "btn_cuatro";
            this.btn_cuatro.Size = new System.Drawing.Size(64, 59);
            this.btn_cuatro.TabIndex = 3;
            this.btn_cuatro.Text = "4";
            this.btn_cuatro.UseVisualStyleBackColor = false;
            this.btn_cuatro.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btn_tres
            // 
            this.btn_tres.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_tres.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_tres.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_tres.Location = new System.Drawing.Point(175, 200);
            this.btn_tres.Name = "btn_tres";
            this.btn_tres.Size = new System.Drawing.Size(64, 59);
            this.btn_tres.TabIndex = 2;
            this.btn_tres.Text = "3";
            this.btn_tres.UseVisualStyleBackColor = false;
            this.btn_tres.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btn_dos
            // 
            this.btn_dos.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_dos.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dos.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_dos.Location = new System.Drawing.Point(93, 200);
            this.btn_dos.Name = "btn_dos";
            this.btn_dos.Size = new System.Drawing.Size(64, 59);
            this.btn_dos.TabIndex = 1;
            this.btn_dos.Text = "2";
            this.btn_dos.UseVisualStyleBackColor = false;
            this.btn_dos.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btn_uno
            // 
            this.btn_uno.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_uno.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_uno.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_uno.Location = new System.Drawing.Point(14, 200);
            this.btn_uno.Name = "btn_uno";
            this.btn_uno.Size = new System.Drawing.Size(64, 59);
            this.btn_uno.TabIndex = 0;
            this.btn_uno.Text = "1";
            this.btn_uno.UseVisualStyleBackColor = false;
            this.btn_uno.Click += new System.EventHandler(this.agregarnumero);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 522);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txt_resultado;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btn_nueve;
        private Button btn_ocho;
        private Button btn_siete;
        private Button btn_seis;
        private Button btn_cinco;
        private Button btn_cuatro;
        private Button btn_tres;
        private Button btn_dos;
        private Button btn_uno;
        private Button btn_quitar;
        private Button btn_borrartodo;
        private Button btn_borrar;
        private Button btn_potencial;
        private Button btn_raiz;
        private Button btn_cero;
        private Button btn_punto;
        private Button btn_signo;
        private Button btn_igual;
        private Button btn_menos;
        private Button btn_mas;
        private Button btn_multiplicar;
        private Button btn_dividir;
    }
}