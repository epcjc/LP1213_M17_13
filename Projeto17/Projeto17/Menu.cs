using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto17
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rest;
            rest = (int)this.loginTableAdapter.checkLogin(this.textBox1.text, this.textBox2.text);
            if (rest ! = 1)

            {
            MenssageBox.show("Acesso negado", "Erro a fazer login", MessageBoxButtons.OK);

            
        }
            else
    }
        form1 frm = Form1();
        frm.show();
}
