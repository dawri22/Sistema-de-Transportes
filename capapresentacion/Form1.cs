using capanegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capapresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema_Transporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void limpiar()
        {
            this.txtnombre.Text = string.Empty;
            this.txtapellido.Text = string.Empty;
            this.txtcedula.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
               string rpta = "";

                rpta = NDatos.insertardatochofer(this.txtnombre.Text.Trim().ToUpper(), this.txtapellido.Text.Trim().ToUpper(), this.dtfechanacimiento.Value, this.txtcedula.Text.Trim().ToUpper());

                if (rpta.Equals("OK"))
                {
                    this.mensajeerror("se inserto el Chofer satisfactoriamente");
                    limpiar();

                }
                else
                {
                    this.mensajeerror(rpta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }

            this.mostrardatos();
            this.cargarcombo();
            this.cargarcomboruta();
            this.cargarcomboauto();


        }

        private void btnguardarautobuses_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                rpta = NDatos.insertardatoautobus(this.txtmarca.Text.Trim().ToUpper(), this.txtmodelo.Text.Trim().ToUpper(), this.txtplaca.Text.Trim().ToUpper(), this.txtcolor.Text.Trim().ToUpper(), this.txtano.Text);

                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("Datos insertados correctamente");
                }
                else
                {
                    this.mensajeerror(rpta);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }

            this.mostrardatos();
            this.cargarcombo();
            this.cargarcomboruta();
            this.cargarcomboauto();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void limpiarruta()
        {
            this.txtruta.Text = string.Empty;

        }

        private void btnguardarruta_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                rpta = NDatos.insertadatoruta(txtruta.Text);
                if (rpta.Equals("OK"))
                {
                    limpiarruta();
                    MessageBox.Show("Datos Insertados Correctamente");
                }
                else
                {
                    this.mensajeerror(rpta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }

            this.mostrardatos();
            this.cargarcombo();
            this.cargarcomboruta();
            this.cargarcomboauto();

        }

        private void cargarcombo()
        {
            this.cbchofer.DataSource = NDatos.mostrardatocombochofer();
            this.cbchofer.DisplayMember = "Nombre";
            this.cbchofer.ValueMember = "idchofer";
        }

        private void cargarcomboruta()
        {
            this.cbruta.DataSource = NDatos.mostrardatocomboruta();
            this.cbruta.DisplayMember = "Rutas";
            this.cbruta.ValueMember = "idruta";
        }

        private void cargarcomboauto()
        {
            this.cbauto.DataSource = NDatos.mostrardatocomboauto();
            this.cbauto.DisplayMember = "Modelo";
            this.cbauto.ValueMember = "idautobuses";
        }

        private void mostrardatos()
        {
            this.datachoferes.DataSource = NDatos.mostrardato();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrardatos();
            cargarcombo();
            cargarcomboruta();
            cargarcomboauto();
        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
            string rpta = "";

            rpta = NDatos.asignacion(cbchofer.Text, cbruta.Text);

            if (rpta.Equals("OK"))
            {
                MessageBox.Show("Asignacion de ruta realizada correcamente");
            }
            else
            {
                this.mensajeerror(rpta);
            }

            rpta = NDatos.asignacionauto(cbchofer.Text, cbauto.Text);

            if (rpta.Equals("OK"))
            {
                MessageBox.Show("Asignacion de auto realizada correcamente");
            }
            else
            {
                this.mensajeerror(rpta);
            }

            this.mostrardatos();
            this.cargarcombo();
            this.cargarcomboruta();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
