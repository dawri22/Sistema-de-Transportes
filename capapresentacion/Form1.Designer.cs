namespace capapresentacion
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.dtfechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtano = new System.Windows.Forms.TextBox();
            this.btnguardarautobuses = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.btnguardarruta = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbchofer = new System.Windows.Forms.ComboBox();
            this.cbruta = new System.Windows.Forms.ComboBox();
            this.btnasignar = new System.Windows.Forms.Button();
            this.datachoferes = new System.Windows.Forms.DataGridView();
            this.cbauto = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datachoferes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.txtcedula);
            this.tabPage1.Controls.Add(this.txtnombre);
            this.tabPage1.Controls.Add(this.txtapellido);
            this.tabPage1.Controls.Add(this.dtfechanacimiento);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(930, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Choferes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(163, 367);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 31);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(90, 253);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(100, 22);
            this.txtcedula.TabIndex = 7;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(90, 36);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 22);
            this.txtnombre.TabIndex = 6;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(90, 97);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 22);
            this.txtapellido.TabIndex = 5;
            // 
            // dtfechanacimiento
            // 
            this.dtfechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechanacimiento.Location = new System.Drawing.Point(163, 173);
            this.dtfechanacimiento.Name = "dtfechanacimiento";
            this.dtfechanacimiento.Size = new System.Drawing.Size(200, 22);
            this.dtfechanacimiento.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnguardarautobuses);
            this.tabPage2.Controls.Add(this.txtano);
            this.tabPage2.Controls.Add(this.txtcolor);
            this.tabPage2.Controls.Add(this.txtplaca);
            this.tabPage2.Controls.Add(this.txtmodelo);
            this.tabPage2.Controls.Add(this.txtmarca);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(930, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Autobuses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnguardarruta);
            this.tabPage3.Controls.Add(this.txtruta);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(930, 426);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rutas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Modelo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Placa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Color ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ano";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(78, 42);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(100, 22);
            this.txtmarca.TabIndex = 3;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(78, 85);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(100, 22);
            this.txtmodelo.TabIndex = 3;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(78, 130);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(100, 22);
            this.txtplaca.TabIndex = 3;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(78, 171);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(100, 22);
            this.txtcolor.TabIndex = 3;
            // 
            // txtano
            // 
            this.txtano.Location = new System.Drawing.Point(78, 211);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(100, 22);
            this.txtano.TabIndex = 3;
            // 
            // btnguardarautobuses
            // 
            this.btnguardarautobuses.Location = new System.Drawing.Point(78, 301);
            this.btnguardarautobuses.Name = "btnguardarautobuses";
            this.btnguardarautobuses.Size = new System.Drawing.Size(111, 38);
            this.btnguardarautobuses.TabIndex = 4;
            this.btnguardarautobuses.Text = "Guardar";
            this.btnguardarautobuses.UseVisualStyleBackColor = true;
            this.btnguardarautobuses.Click += new System.EventHandler(this.btnguardarautobuses_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ruta";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtruta
            // 
            this.txtruta.Location = new System.Drawing.Point(60, 43);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(644, 22);
            this.txtruta.TabIndex = 1;
            // 
            // btnguardarruta
            // 
            this.btnguardarruta.Location = new System.Drawing.Point(319, 156);
            this.btnguardarruta.Name = "btnguardarruta";
            this.btnguardarruta.Size = new System.Drawing.Size(75, 23);
            this.btnguardarruta.TabIndex = 2;
            this.btnguardarruta.Text = "Guardar";
            this.btnguardarruta.UseVisualStyleBackColor = true;
            this.btnguardarruta.Click += new System.EventHandler(this.btnguardarruta_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.cbauto);
            this.tabPage4.Controls.Add(this.datachoferes);
            this.tabPage4.Controls.Add(this.btnasignar);
            this.tabPage4.Controls.Add(this.cbruta);
            this.tabPage4.Controls.Add(this.cbchofer);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(930, 426);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Asignacion";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Chofer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(213, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ruta";
            // 
            // cbchofer
            // 
            this.cbchofer.FormattingEnabled = true;
            this.cbchofer.Location = new System.Drawing.Point(60, 73);
            this.cbchofer.Name = "cbchofer";
            this.cbchofer.Size = new System.Drawing.Size(121, 24);
            this.cbchofer.TabIndex = 2;
            // 
            // cbruta
            // 
            this.cbruta.FormattingEnabled = true;
            this.cbruta.Location = new System.Drawing.Point(254, 73);
            this.cbruta.Name = "cbruta";
            this.cbruta.Size = new System.Drawing.Size(228, 24);
            this.cbruta.TabIndex = 3;
            // 
            // btnasignar
            // 
            this.btnasignar.Location = new System.Drawing.Point(766, 67);
            this.btnasignar.Name = "btnasignar";
            this.btnasignar.Size = new System.Drawing.Size(94, 35);
            this.btnasignar.TabIndex = 4;
            this.btnasignar.Text = "Asignar";
            this.btnasignar.UseVisualStyleBackColor = true;
            this.btnasignar.Click += new System.EventHandler(this.btnasignar_Click);
            // 
            // datachoferes
            // 
            this.datachoferes.AllowUserToAddRows = false;
            this.datachoferes.AllowUserToDeleteRows = false;
            this.datachoferes.AllowUserToOrderColumns = true;
            this.datachoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datachoferes.Location = new System.Drawing.Point(10, 122);
            this.datachoferes.Name = "datachoferes";
            this.datachoferes.ReadOnly = true;
            this.datachoferes.RowHeadersWidth = 51;
            this.datachoferes.RowTemplate.Height = 24;
            this.datachoferes.Size = new System.Drawing.Size(850, 276);
            this.datachoferes.TabIndex = 5;
            this.datachoferes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbauto
            // 
            this.cbauto.FormattingEnabled = true;
            this.cbauto.Location = new System.Drawing.Point(588, 73);
            this.cbauto.Name = "cbauto";
            this.cbauto.Size = new System.Drawing.Size(121, 24);
            this.cbauto.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(522, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Autobus";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 499);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datachoferes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.DateTimePicker dtfechanacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnguardarautobuses;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnguardarruta;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnasignar;
        private System.Windows.Forms.ComboBox cbruta;
        private System.Windows.Forms.ComboBox cbchofer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView datachoferes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbauto;
    }
}