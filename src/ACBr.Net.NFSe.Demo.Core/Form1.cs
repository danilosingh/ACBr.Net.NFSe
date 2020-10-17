using ACBr.Net.NFSe.DANFSe.FastReport.Core;
using ACBr.Net.NFSe.Providers;
using System.Windows.Forms;
using System.Linq;
using ACBr.Net.NFSe.Nota;
using System;
using System.IO;
using System.Diagnostics;

namespace ACBr.Net.NFSe.Demo.Core
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, System.EventArgs e)
        {
            var acbrNFSe = new ACBrNFSe
            {
                DANFSe = new DANFSeFastReport()
            };

            var municipio = ProviderManager.Municipios.FirstOrDefault();
            if (municipio == null) return;

            acbrNFSe.NotasServico.Clear();
            var nfSe = acbrNFSe.NotasServico.AddNew();
            nfSe.IdentificacaoRps.Numero = "1";
            nfSe.IdentificacaoRps.Serie = "1";
            nfSe.IdentificacaoRps.Tipo = TipoRps.RPS;
            nfSe.IdentificacaoRps.DataEmissao = DateTime.Now;
            nfSe.Situacao = SituacaoNFSeRps.Normal;
            nfSe.NaturezaOperacao = NaturezaOperacao.ABRASF.TributacaoNoMunicipio;
            nfSe.RegimeEspecialTributacao = RegimeEspecialTributacao.SimplesNacional;
            nfSe.IncentivadorCultural = NFSeSimNao.Nao;

            nfSe.IdentificacaoNFSe.DataEmissao = DateTime.Now;
            nfSe.IdentificacaoNFSe.Numero = "7";
            nfSe.IdentificacaoNFSe.Chave = "5B 88 56";
            nfSe.Servico.ItemListaServico = "01.07";
            nfSe.Servico.CodigoTributacaoMunicipio = "01.07.00 / 00010700";
            nfSe.Servico.CodigoCnae = "";
            nfSe.Servico.CodigoMunicipio = municipio.Codigo;
            nfSe.Servico.Discriminacao = "MANUTENCAO TÉCNICA / VOCÊ PAGOU APROXIMADAMENTE R$ 41,15 DE TRIBUTOS FEDERAIS, R$ 8,26 DE TRIBUTOS MUNICIPAIS, R$ 256,57 PELOS PRODUTOS/SERVICOS, FONTE: IBPT.";

            nfSe.Servico.Valores.ValorServicos = 100;
            nfSe.Servico.Valores.ValorDeducoes = 0;
            nfSe.Servico.Valores.ValorPis = 0;
            nfSe.Servico.Valores.ValorCofins = 0;
            nfSe.Servico.Valores.ValorInss = 0;
            nfSe.Servico.Valores.ValorIr = 0;
            nfSe.Servico.Valores.ValorCsll = 0;
            nfSe.Servico.Valores.IssRetido = SituacaoTributaria.Normal;
            nfSe.Servico.Valores.ValorIss = 0;
            nfSe.Servico.Valores.ValorOutrasRetencoes = 0;
            nfSe.Servico.Valores.BaseCalculo = 100;
            nfSe.Servico.Valores.Aliquota = 2;
            nfSe.Servico.Valores.ValorLiquidoNfse = 0;
            nfSe.Servico.Valores.ValorIssRetido = 0;
            nfSe.Servico.Valores.DescontoCondicionado = 0;
            nfSe.Servico.Valores.DescontoIncondicionado = 0;
            nfSe.ValorCredito = 0;

            nfSe.Tomador.CpfCnpj = "44854962283";
            nfSe.Tomador.InscricaoMunicipal = "";
            nfSe.Tomador.RazaoSocial = "Nome";

            nfSe.Tomador.Endereco.TipoLogradouro = "";
            nfSe.Tomador.Endereco.Logradouro = "INDEPENDENCIA";
            nfSe.Tomador.Endereco.Numero = "123";
            nfSe.Tomador.Endereco.Complemento = "SL 10";
            nfSe.Tomador.Endereco.Bairro = "VILA SEIXAS";
            nfSe.Tomador.Endereco.CodigoMunicipio = municipio.Codigo;
            nfSe.Tomador.Endereco.Municipio = municipio.Nome;
            nfSe.Tomador.Endereco.Uf = municipio.UF.ToString();
            nfSe.Tomador.Endereco.Cep = "14020010";
            nfSe.Tomador.Endereco.CodigoPais = 1058;
            nfSe.Tomador.Endereco.Pais = "BRASIL";

            nfSe.Tomador.DadosContato.DDD = "16";
            nfSe.Tomador.DadosContato.Telefone = "30111234";
            nfSe.Tomador.DadosContato.Email = "NOME@EMPRESA.COM.BR";
            var stream = ((DANFSeFastReport)acbrNFSe.DANFSe).ExportToStream();
            FileStream fileStream = new FileStream("teste.pdf", FileMode.Create, FileAccess.Write);
            stream.Position = 0;
            stream.CopyTo(fileStream);
            fileStream.Close();
            Process.Start("teste.pdf");
        }
    }
}
