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
    public partial class Login : Form
        {
        public Login()
            {
            InitializeComponent();
            }

        private void entrar_Click(object sender, EventArgs e)
            {
            Entities.Login login = new Entities.Login();
            login.Logar(tbLogin.Text, tbSenha.Text);
            }
        }
    }
