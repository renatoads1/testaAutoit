using System;
using System.IO;
using AutoItX3Lib;
using System.Threading;

namespace testaAutoit
{
    class Program
    {
        public static void Main(string[] args)
        {
            AutoItX3 au = new AutoItX3();

            
            if (!File.Exists(@"C:\nQuestor\nfis.exe") {
                Console.WriteLine("caminho do questor errado");
            }
            
            

           Thread.Sleep(5000);

            // Verifica tela de Seleção
            if (VerificaTela("Seleção", 20))
            {
                throw new ArgumentException("Não foi possível verificar a tela após o login no Questor");
            }
            


            if (GrupoMatur.Contains(empresa.CodigoEmpresaQuestor.ToString()))
            {
                if (empresa.CodigoEmpresaQuestor == 2431) empresa.CodigoEmpresaQuestor = 19;
                else if (empresa.CodigoEmpresaQuestor == 2430) empresa.CodigoEmpresaQuestor = 18;
                else if (empresa.CodigoEmpresaQuestor == 2388) empresa.CodigoEmpresaQuestor = 17;
                else if (empresa.CodigoEmpresaQuestor == 2236) empresa.CodigoEmpresaQuestor = 14;
                else if (empresa.CodigoEmpresaQuestor == 2417) empresa.CodigoEmpresaQuestor = 24;
            }

            // Digita o código da empresa
            Thread.Sleep(500);
            au.Send(empresa.CodigoEmpresaQuestor.ToString());

            // Digita o código estab da empresa
            Thread.Sleep(500);
            AutoItX.Send("{TAB}" + empresa.CodigoEstabQuestor.ToString());

            // Digita a Data início
            Thread.Sleep(500);
            AutoItX.Send("{TAB}" + dataInicio.Replace(".", ""));

            // Digita a Data fim
            Thread.Sleep(500);
            AutoItX.Send("{TAB}" + dataFim.Replace(".", ""));
            AutoItX.Send("{TAB}{ENTER}");

            Thread.Sleep(5000);

            // Acessa o menu Arquivos > Municipais > Importar NFSe
            AutoItX.MouseClick("LEFT", TamanhoTela.MetadeLargura + 125, TamanhoTela.MetadeAltura - 351, 1);
            AutoItX.MouseClick("LEFT", TamanhoTela.MetadeLargura + 171, TamanhoTela.MetadeAltura - 293, 1);
            AutoItX.MouseClick("LEFT", TamanhoTela.MetadeLargura + 271, TamanhoTela.MetadeAltura - 223, 1);

            // Verifica tela de Importar NFSe
            if (VerificaTela("Fiscal - Questor - [Importar NFSe]", 15)) {
                throw new ArgumentException("Não foi possível verificar a tela após acessar o menu Importar NFSe");
            }
            

            // Digita a Data início no campo Data inicial
            AutoItX.Send(dataInicio.Replace(".", ""));

            // Digita a Data fim no campo Data Final
            AutoItX.Send("{TAB}");
            AutoItX.Send(dataFim.Replace(".", ""));

            // Digita Recebidas no campo Movimento
            AutoItX.Send("{TAB}");
            AutoItX.Send("Recebidas");

            // Digita Data de Emissão no campo Data Importação
            AutoItX.Send("{TAB}");
            AutoItX.Send("Data de Emissão");

            // Digita Outras no campo Integrar
            AutoItX.Send("{TAB}");
            AutoItX.Send("Outras");

            // Digita Sim no campo Utiliza Relacionamento
            AutoItX.Send("{TAB}");
            AutoItX.Send("Sim");

            // Digita Não no campo Sugerir Relacionamento Baseado na Descrição do Serviço
            AutoItX.Send("{TAB}");
            AutoItX.Send("Não");

            // Digita Não no campo Importar Pis/Cofins/Outros
            AutoItX.Send("{TAB}");
            AutoItX.Send("Não");

            if (empresa.PossuiRegraEspecifica || NovoGrupoMatur.Contains(empresa.CodigoEmpresaQuestor))
            {
                // Digita Não no campo Importar Produto Padrão
                AutoItX.Send("{TAB}");
                AutoItX.Send("Não");
            }
            else
            {
                // Digita Sim no campo Importar Produto Padrão
                AutoItX.Send("{TAB}");
                AutoItX.Send("Sim");

                // Digita 0 no campo Produto Padrão
                AutoItX.Send("{TAB}");
                AutoItX.Send("0");
            }

        }
    }
}
