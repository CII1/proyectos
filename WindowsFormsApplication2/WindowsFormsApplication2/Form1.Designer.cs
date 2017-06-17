namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnincrementar = new System.Windows.Forms.Button();
            this.btnpausar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(167, 114);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(351, 18);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnincrementar
            // 
            this.btnincrementar.Location = new System.Drawing.Point(61, 238);
            this.btnincrementar.Name = "btnincrementar";
            this.btnincrementar.Size = new System.Drawing.Size(153, 58);
            this.btnincrementar.TabIndex = 1;
            this.btnincrementar.Text = "Iniciar descargas";
            this.btnincrementar.UseVisualStyleBackColor = true;
            this.btnincrementar.Click += new System.EventHandler(this.btnincrementar_Click);
            // 
            // btnpausar
            // 
            this.btnpausar.Location = new System.Drawing.Point(482, 238);
            this.btnpausar.Name = "btnpausar";
            this.btnpausar.Size = new System.Drawing.Size(153, 58);
            this.btnpausar.TabIndex = 2;
            this.btnpausar.Text = "Pausar";
            this.btnpausar.UseVisualStyleBackColor = true;
            this.btnpausar.Click += new System.EventHandler(this.btnpausar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 58);
            this.button2.TabIndex = 4;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(167, 138);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(351, 20);
            this.progressBar2.TabIndex = 5;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(167, 164);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(351, 23);
            this.progressBar3.TabIndex = 6;
            this.progressBar3.Click += new System.EventHandler(this.progressBar3_Click);
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(167, 194);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(351, 23);
            this.progressBar4.TabIndex = 7;
            this.progressBar4.Click += new System.EventHandler(this.progressBar4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "descarga 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "descarga 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "descarga 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "descarga 4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(299, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(420, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "ingrese el tamaña de cada descarga";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(555, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(555, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(555, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(555, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.hacker_by_hashbox;
            this.ClientSize = new System.Drawing.Size(647, 308);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnpausar);
            this.Controls.Add(this.btnincrementar);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "procesos de descarga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnincrementar;
        private System.Windows.Forms.Button btnpausar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

