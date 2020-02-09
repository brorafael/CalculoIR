using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CalculoIR.Desktop
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            EnviaDadosContribuinte();
        }

        private void AtualizaDadosContribuinte()
        {
            var client = new RestClient($"{txtURL.Text}/api/Contribuintes/");
            var request = new RestRequest(Method.GET);
            request.AddHeader("postman-token", "c31ddb3e-d13f-1ccc-03f3-1b01c359dc05");
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);
            
            if (response.IsSuccessful)
                txtResultado.Text = response.Content;
        }

        private void EnviaDadosContribuinte()
        {
            var sb = new StringBuilder();
            sb.AppendLine("{")
              .AppendLine($"\"Nome\" : \"{txtNome.Text}\",")
              .AppendLine($"\"Cpf\" : \"{txtCPF.Text}\",")
              .AppendLine($"\"RendaMensal\" : {double.Parse(txtRendaMensal.Text)},")
              .AppendLine($"\"QtdDependentes\" : {(int)numDependentes.Value}")
              .AppendLine("}");


            var client = new RestClient($"{txtURL.Text}/api/Contribuintes");
            var request = new RestRequest(Method.POST);
            request.AddHeader("postman-token", "79d4921a-5aa2-4b9b-e4d3-9b545a2f788f");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", sb.ToString(), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            
            if (response.IsSuccessful)
                AtualizaDadosContribuinte();
            else
                MessageBox.Show($"Falha ao enviar ao servidor: {response.ErrorMessage}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient($"{txtURL.Text}/api/CalculoIR/");
            var request = new RestRequest(Method.POST);
            request.AddHeader("postman-token", "4a3716d6-c38a-225d-12c0-461b71811de4");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", $"{{\n\t\"{double.Parse(txtSalarioMinimo.Text)}\" : 1000\n}}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            
            if (response.IsSuccessful)
                txtResultadoCalculo.Text = response.Content;
            else
                MessageBox.Show($"Falha ao calcular: {response.ErrorMessage}");
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
