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
            rest = (int)this.loginTableAdapter.checkLogin(this.database1DataSet.login, this.textBox1.Text, this.textBox2.Text);
            if (rest != 1)
            {
                MessageBox.Show("Acesso negado", "Erro a fazer login", MessageBoxButtons.OK);

            }
            else
            {
                Form1 frm = new Form1();
                frm.Show();
            }
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.database1DataSet.login);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



    }
}

