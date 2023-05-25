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
    public partial class Form1 : Form
    {
        Entities.ControleContato controle = new Entities.ControleContato();        
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta form = new Consulta();
            form.ShowDialog();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controle.Backup("C:\\Users\\Manager\\Downloads\\Agenda-main\\Backup"), "Backup do Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string CaminhoBackup = openFileDialog1.FileName;
                MessageBox.Show(controle.Restore(CaminhoBackup), "Restauração do BD",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
