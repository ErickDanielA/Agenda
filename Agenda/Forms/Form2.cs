using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.Entities;

namespace Agenda.Forms
{
    public partial class Form2 : Form
    {
        Entities.Contato Info = new Contato();
        Entities.ControleContato MySQL = new ControleContato();
        Entities.Conexao con = new Conexao();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Info.Codcontato = int.Parse(tbCod.Text);
            Info.Nome = tbNome.Text.Trim();
            Info.Telefone = mtbTelefone.Text.Trim();
            Info.Celular = mtbCelular.Text.Trim();
            Info.Email = tbEmail.Text.Trim();
            if (Info.Codcontato.ToString() == "" || Info.Celular == "" || Info.Telefone == "" || Info.Nome == "" || Info.Email == "")
            {
                MessageBox.Show("Digite Todas as Informações");
            }
            else { MessageBox.Show(MySQL.alterar(Info)); }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Info.Nome = tbNome.Text;
            Info.Telefone = mtbTelefone.Text;
            Info.Celular = mtbCelular.Text;
            Info.Email = tbEmail.Text;
            MessageBox.Show(MySQL.cadastrar(Info));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            con.Conectar();
            con.Desconectar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Info.Codcontato = int.Parse(tbCod.Text);
            MessageBox.Show(MySQL.excluir(Info));
        }
    }
}
