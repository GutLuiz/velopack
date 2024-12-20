using System;
using System.Windows.Forms;

namespace TesteWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurar a interface do formulário
            CriarInterface();
        }

        private void CriarInterface()
        {
            // Label para o título
            Label lblTitulo = new Label();
            lblTitulo.Text = "Título: Pedido/Venda";
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new System.Drawing.Point(20, 20); // Posição no formulário
            this.Controls.Add(lblTitulo);

            // TextBox para o CNPJ
            TextBox txtCNPJ = new TextBox();
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Location = new System.Drawing.Point(20, 50); // Posição no formulário
            txtCNPJ.Width = 200; // Largura
            this.Controls.Add(txtCNPJ);

            // Botão para Salvar
            Button btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Location = new System.Drawing.Point(20, 90); // Posição no formulário
            btnSalvar.Click += BtnSalvar_Click; // Associa o evento de clique
            this.Controls.Add(btnSalvar);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Lógica do botão Salvar
            MessageBox.Show("CNPJ salvo com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
