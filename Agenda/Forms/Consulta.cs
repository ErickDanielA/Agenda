using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Agenda.Entities;

namespace Agenda.Forms
{
    public partial class Consulta : Form
    {
        Entities.ControleContato consulta = new Entities.ControleContato();
        public Consulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb.SelectedIndex == 0)
                {
                consulta.ConsultaCodigo(int.Parse(txbDado.Text));
                }
            else if(cb.SelectedIndex == 1)
                {
                consulta.ConsultaNome(txbDado.Text);
                }
            else if (cb.SelectedIndex == 2)
                {
                consulta.ConsultaTelefone(txbDado.Text);
                }
            else if (cb.SelectedIndex == 3)
                {
                consulta.ConsultaCelular(txbDado.Text);
                }
            else if (cb.SelectedIndex == 4)
                {
                try {
                    consulta.ConsultaEmail(txbDado.Text); 
                    }
                catch(Exception erro) 
                    {
                    MessageBox.Show(Text, erro.Message);
                    }
                
                }



        }

        private void button2_Click(object sender, EventArgs e)
            {
            consulta.ListarTodos();
            }
        }
}