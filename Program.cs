using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Versioning;

namespace JANTARDOSFILOSOFOSNET
{
    [SupportedOSPlatform("windows")]
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        public static Form1 FormInstace = null!;
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        [STAThread]
        static void Main()
        {
            try
            {
                Console.WriteLine("Iniciando aplicação...");
                if (!AllocConsole())
                {
                    MessageBox.Show("Não foi possível alocar o console");
                }
                Console.WriteLine("Console alocado com sucesso");
                
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Console.WriteLine("Configurações do Windows Forms aplicadas");
                
                var form = new Form1();
                Program.FormInstace = form;
                Console.WriteLine("Formulário criado e FormInstance definido");
                
                Application.Run(form);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro fatal: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
            }
        }

        public static readonly object[] garfos = new object[5];
        public static readonly Thread[] filosofos = new Thread[5];

        public static void Iniciar()
        {
            string[] nomesFilosofos = { "Alan Turing", "Ada Lovelace", "Filosofo 2", "Djikstra", "Filosofo 3" };
            
            for (int i = 0; i < garfos.Length; i++)
            {
                garfos[i] = new object();
            }

            for (int i = 0; i < filosofos.Length; i++)
            {
                int id = i;
                filosofos[i] = new Thread(() => Filosofos(id))
                {
                    Name = nomesFilosofos[i]
                };
            }
        }

        private static void Filosofos(int id)
        {

            while (true)
            {
                FormInstace?.AtualizarEstadoBotao(id, "pensando");
                Thread.Sleep(new Random().Next(1000, 3000));

                FormInstace?.AtualizarEstadoBotao(id, "faminto");
                 
                int garfoEsquerda = id;
                int garfoDireita = (id + 1) % garfos.Length;

                if(id == garfos.Length - 1)
                {
                    int temp = garfoEsquerda;
                    garfoEsquerda = garfoDireita;
                    garfoDireita = temp;
                }

                lock (garfos[garfoEsquerda])
                {
                    lock (garfos[garfoDireita])
                    {
                        FormInstace?.AtualizarEstadoBotao(id, "comendo");
                        Thread.Sleep(new Random().Next(1000, 3000));
                    }
                }
            }
        }

    }
}
