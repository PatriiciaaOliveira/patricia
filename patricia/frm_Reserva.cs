using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patricia
{
    public partial class frm_Reserva : Form
    {
        private string relatorioFilePath = "relatorio.txt";

        // Declare os objetos TextBox e DataGridView
        private TextBox txtRelatorio;
        private DataGridView dgvRelatorio;

        public frm_Reserva()
        {
            InitializeComponent();
        }

        private void frm_Reserva_Load(object sender, EventArgs e)
        {
            // Carregar os dados do arquivo de texto para o DataGridView
            CarregarRelatorio();
        }

        private void CarregarRelatorio()       {
            // Verificar se o arquivo existe
            if (File.Exists(relatorioFilePath))
            {
                // Ler as linhas do arquivo
                string[] linhas = File.ReadAllLines(relatorioFilePath);

                // Limpar o DataGridView
            

                // Adicionar cada linha como uma nova linha no DataGridView
                foreach (string linha in linhas)
                {
                    // Dividir a linha em colunas usando a vírgula como delimitador
                    string[] colunas = linha.Split(',');

                    // Adicionar a linha ao DataGridView
                    
                }
            }
            else
            {
                MessageBox.Show("Nenhum relatório disponível.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConfirmar1_Click(object sender, EventArgs e)
        {
            // Salvar os dados do relatório
            string nome = txtNome1.Text;
            string disci = cbDisci.SelectedItem?.ToString();
            string reserva = cbReserva1.SelectedItem?.ToString();
            string periodo = cbPeriodo1.SelectedItem?.ToString();
            string data = mcCalendario1.SelectionStart.ToString("dd/MM/yyyy");
            // Criar uma linha com os dados do relatório
            string[] novaLinha = { nome, disci, reserva, periodo, data };

            // Adicionar a linha ao arquivo de texto
            File.AppendAllText(relatorioFilePath, string.Join(",", novaLinha) + Environment.NewLine);

            // Exibir as informações cadastradas em uma MessageBox
            string mensagem = $"Reserva confirmada com sucesso!\n\nNome: {nome}\nDisciplina: {disci}\nReserva: {reserva}\nPeríodo: {periodo}\nData: {data}";
            MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparControles();
        }

        private void LimparControles()
        {
            txtNome1.Clear();
            cbDisci.SelectedIndex = -1;
            cbReserva1.SelectedIndex = -1;
            cbPeriodo1.SelectedIndex = -1;
            mcCalendario1.SetDate(DateTime.Today);
        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}