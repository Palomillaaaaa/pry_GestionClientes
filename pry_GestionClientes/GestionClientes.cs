using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_GestionClientes
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        //Declaracion de Registro
        //Se le pone public para poder siempre acceder a los campos
        private struct RegistroClientes
        {
            public Int32 Codigo; 
            public String Usuario;
            public Decimal Deuda;
            public Decimal Limite;

        }

        //Declaracion de Vector
        private RegistroClientes[] Clientes = new RegistroClientes [12];

        //Declaracion del Indice  
        private Int32 INDICE = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblLimite_Click(object sender, EventArgs e)
        {

        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (INDICE<Clientes.Length)
                { 
                //Le pongo .Codigo para que parta desde ese vector
                Clientes[INDICE].Codigo=Convert.ToInt32 (txtCodigo.Text);
                Clientes[INDICE].Usuario = txtUsuario.Text;
                Clientes[INDICE].Deuda = Convert.ToDecimal(txtDeuda.Text);
                Clientes[INDICE].Limite = Convert.ToDecimal(txtLimite.Text);
                INDICE++;
                Listar();
                //Pongo Indice pero en realidad el indice que pone IND
                txtCodigo.Text = "";
                txtUsuario.Text = "";
                txtDeuda.Text = "";
                txtLimite.Text = "";

            }
            else
                {
                MessageBox.Show("No es posible Cargar más datos");
                }
            }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void Listar() 
        {
            Decimal Total = 0;
            for (Int32 i = 0; i < Clientes.Length; i++)
            {
                dvgClientes.Rows.Add(Clientes[i].Codigo, Clientes[i].Usuario, Clientes[i].Limite, Clientes[i].Deuda);
                Total = Total + Clientes[i].Deuda;
                
            }
            lblTotaldeDeuda.Text = Total.ToString();
        }
        private void btnListar_Click(object sender, EventArgs e)
            
        {
            Listar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comprobar()
        {
            if (txtCodigo.Text != "" && txtUsuario.Text != "" && txtDeuda.Text != "" && txtLimite.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
           comprobar();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }
    }
}
