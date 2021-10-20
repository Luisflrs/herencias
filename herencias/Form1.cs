using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cbCargo.Text == "Administrativo")
            {
                Administrativo administrativo = new Administrativo();
                administrativo.nombre = txtNombre.Text;
                administrativo.area = cbCargo.Text;

                listBox1.Items.Add(administrativo.registrar());
                listBox1.Items.Add(administrativo.consultar());
                listBox1.Items.Add(administrativo.sueldo());
                txtNombre.Text = "";
                cbCargo.Text = "";
                txtNombre.Focus();


            }
            else if (cbCargo.Text == "Docente")
            {
                Docente docente = new Docente();
                docente.nombre = txtNombre.Text;
                docente.cargo = cbCargo.Text;
                docente.horastrabajadas = txtHoras.Text;

                listBox1.Items.Add(docente.registrar());
                listBox1.Items.Add(docente.consultar());
                listBox1.Items.Add(docente.sueldo());

                txtHoras.Text = "";

                txtNombre.Text = "";
                cbCargo.Text = "";

                txtNombre.Focus();

            }
            else if(cbCargo.Text == "Limpieza")
            {
                PersonalLimpieza personal = new PersonalLimpieza();
                personal.nombre = txtNombre.Text;
                personal.turno = cbTurno.Text;

                listBox1.Items.Add(personal.registrar());
                listBox1.Items.Add(personal.consultar());
                listBox1.Items.Add(personal.sueldo());
                txtNombre.Text = "";
                cbCargo.Text = "";
                cbTurno.Text = "";

            }
            else
            {
                MessageBox.Show("Favor rellene el campo requerido");
                cbCargo.Focus();


            }


        }
    }
}

