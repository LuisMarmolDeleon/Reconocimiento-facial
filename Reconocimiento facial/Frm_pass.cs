using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconocimiento_facial
{
    public partial class Frm_pass : MetroFramework.Forms.MetroForm
    {
        String nombre;
        DBCon con = new DBCon();
        public Frm_pass(String n)
        {
            nombre = n;
            InitializeComponent();
        }

        private void Frm_pass_Load(object sender, EventArgs e)
        {
            lblName.Text = nombre;
            this.Text = "Claves de " + lblName.Text;
            Cargar();
        }

        private void Cargar()
        {      
            dataGridView.DataSource = con.ObtenerContras(nombre);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                txtSitio.Text = row.Cells[1].Value.ToString();
                txtContra.Text = row.Cells[2].Value.ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_pass_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_Reconocimiento fr = new Frm_Reconocimiento();
            fr.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            con.GuardarSitio(txtSitio.Text, txtContra.Text, lblName.Text);
            Cargar();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
            Cargar();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            
            Cargar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Para registrar una clave solo ingrese el enlace de la pagina seguido de la clave, luego haga clic en el boton de agregar.", "Ayuda");
        }
    }
}
