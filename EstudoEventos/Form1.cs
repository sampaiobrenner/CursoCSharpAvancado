using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoEventos
{
    public partial class rfmGerenciador : Form
    {
        private GerenciadorLatidos _gerenciadorLatidos;
        public rfmGerenciador()
        {
            InitializeComponent();
            _gerenciadorLatidos = new GerenciadorLatidos();
            _gerenciadorLatidos.ExcessoDecibeisEvent += (sender, args) => 
            {
                ExcessoDecibeisEventsArgs arg = (ExcessoDecibeisEventsArgs)args;
                MessageBox.Show(string.Format("O cão passou dos limites. {0} decibeis.", arg.IntensidadeLatido), "Excesso de latidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pgbLatidos.Value = 0;
        }

        private void btnLatir_Click(object sender, EventArgs e)
        {
            pgbLatidos.Value = _gerenciadorLatidos.Latir();
        }

        //private void QuandoExceder(object sender, EventArgs e)
        //{
        //    ExcessoDecibeisEventsArgs arg = (ExcessoDecibeisEventsArgs)e;
        //    MessageBox.Show(string.Format("O cão passou dos limites. {0} decibeis.", arg.IntensidadeLatido), "Excesso de latidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //}

    }
}
