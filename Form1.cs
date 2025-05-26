using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Versioning;
using System.Windows.Forms;
using System.IO;

namespace JANTARDOSFILOSOFOSNET
{
    [SupportedOSPlatform("windows")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Iniciando carregamento do formulário...");
                Program.FormInstace = this;
                Console.WriteLine("FormInstance definido");

                // Carregar imagens iniciais
                string resourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
                button1.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "AlanTuringPensando.png"));
                button2.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "AdaPensando.png"));
                button3.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "Filosofo2Pensando.png"));
                button4.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "DjikstraPensando.png"));
                button5.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "computer_science_philosopher_320x320.png"));

                Program.Iniciar();
                for (int i = 0; i < Program.filosofos.Length; i++)
                {
                    if (Program.filosofos[i].ThreadState == ThreadState.Unstarted)
                    {
                        Program.filosofos[i].Start();
                        Console.WriteLine($"Thread {Program.filosofos[i].Name} iniciada automaticamente no load.");
                    }
                }
                Console.WriteLine("Iniciar() concluído");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro detalhado: {ex}");
                MessageBox.Show($"Erro ao carregar: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
            }
        }

        public void AtualizarEstadoBotao(int id, string estado)
        {
            if (InvokeRequired)
            {
                if (this.IsHandleCreated && !this.IsDisposed && !this.Disposing)
                {
                    Invoke(new Action(() => AtualizarEstadoBotao(id, estado)));
                }
                return;
            }

            Button? botao = null;

            switch (id)
            {
                case 0: botao = button1; break;
                case 1: botao = button2; break;
                case 2: botao = button3; break;
                case 3: botao = button4; break;
                case 4: botao = button5; break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(id), "Invalid button ID provided.");
            }

            if (botao == null)
            {
                throw new InvalidOperationException($"Button with ID {id} is not initialized.");
            }
            botao.FlatStyle = FlatStyle.Flat;
            botao.FlatAppearance.BorderSize = 6;

            string nomeFilosofo = Program.filosofos[id]?.Name ?? "Filosofo Desconhecido";
            string resourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

            switch (estado)
            {
                case "pensando":
                    botao.BackColor = Color.Yellow;
                    botao.FlatAppearance.BorderColor = Color.Yellow;
                    switch (nomeFilosofo)
                    {
                        case "Alan Turing": botao.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "AlanTuringPensando.png")); break;
                        case "Ada Lovelace": botao.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "AdaPensando.png")); break;
                        case "Filosofo 2": botao.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "Filosofo2Pensando.png")); break;
                        case "Djikstra": botao.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "DjikstraPensando.png")); break;
                        case "Filosofo 3": botao.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "Naoseionomedelapensando.png")); break;
                    }
                    break;
                case "comendo":
                    botao.BackColor = Color.LightGreen;
                    botao.FlatAppearance.BorderColor = Color.LightGreen;
                    switch (nomeFilosofo)
                    {
                        case "Alan Turing": botao.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "AlanTuringComendo.png")); break;
                        case "Ada Lovelace": botao.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "AdaComendo.png")); break;
                        case "Filosofo 2": botao.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "Filosofo2Comendo.png")); break;
                        case "Djikstra": botao.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "DjikstraComendo.png")); break;
                        case "Filosofo 3": botao.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "Naoseionomedelacomendo.png")); break;
                    }
                    break;
                case "faminto":
                    botao.BackColor = Color.Red;
                    botao.FlatAppearance.BorderColor = Color.Red;
                    switch (nomeFilosofo)
                    {
                        case "Alan Turing": botao.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "AlanTuringFaminto.png")); break;
                        case "Ada Lovelace": botao.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "AdaFaminta.png")); break;
                        case "Filosofo 2": botao.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "Filosofo2Faminto.png")); break;
                        case "Djikstra": botao.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "DjikstraFaminto.png")); break;
                        case "Filosofo 3": botao.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "Naoseionomedelafaminta.png")); break;
                    }
                    break;
                default:
                    botao.BackColor = SystemColors.Control;
                    botao.BackgroundImage = Image.FromFile(Path.Combine(resourcePath, "computer_science_philosopher_320x320.png"));
                    break;
            }
            botao.Text = $"{Program.filosofos[id].Name} - {estado}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StartThread(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StartThread(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartThread(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartThread(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartThread(4);
        }
        private void StartThread(int id)
        {
            var thread = Program.filosofos[id];
            Console.WriteLine($"Estado atual da thread {id}: {thread.ThreadState}");

            if (thread.ThreadState == ThreadState.Unstarted)
            {
                thread.Start();
                MessageBox.Show($"Thread {thread.Name} iniciada.");
            }
            else
            {
                MessageBox.Show($"Thread {thread.Name} já está em execução.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}