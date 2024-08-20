using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSupermercado
{
    public partial class Form1 : Form
    {
        double total;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Entrada 
            double qtde = double.Parse(txtQtde.Text);
            double valor = double.Parse(txtValor.Text);

            // Procesamento
            total += qtde * valor;

            // Saída 
            lblTotal.Text = total.ToString("C");

            // Insere o produto no ListBox
            lstProdutos.Items.Add(txtProduto.Text + " / " + txtQtde.Text + " / " + valor.ToString("C"));

            // Limpa as caixas para inserir novo produto
            txtProduto.Clear();
            txtQtde.Clear();
            txtValor.Clear();
            txtProduto.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Zera a variavel total 
            total = 0;
            lblTotal.Text = total.ToString("C");

            // Limpa o ListBox
            lstProdutos.Items.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // Encerra a aplicação
            Application.Exit();
        }
    }
}
