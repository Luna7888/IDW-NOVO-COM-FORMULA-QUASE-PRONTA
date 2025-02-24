using ScottPlot;
using ScottPlot.Colormaps;
using ScottPlot.Panels;
using ScottPlot.Plottables;
using ScottPlot.TickGenerators.Financial;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IDW
{
    public partial class Form1 : Form
    {
        private List<double[]> valoresAdiconados = new List<double[]>();
        private List<Ponto> ListaPonto = new List<Ponto>();
        private double[,] Mapa = new double[100, 100]; // Pelos visto vou ter que mudar o tamanho , se quiser que o painel seja fluido

        private int indexValoresAdicionados;
        private double numerador;
        private double iP;
        private double ipSeparado;
        private double dP;
        private double intensidadeAtual;
        private double numerador2;
        private int rodado;

        Ponto PontoA = new(25, 25, 80);
        Ponto PontoB = new(75, 25, 10);
        Ponto PontoC = new(75, 75, 10);
        Ponto PontoD = new(25, 75, 50);


        //FUN�OES
        void Interpolate(double[,] mapa, List<Ponto> listaponto)
        {
            //Organizando  formula para ter valores nao pr� definidos

            for (int y = 0; y < mapa.GetLength(0); y++)
            {
                for (int x = 0; x < mapa.GetLength(1); x++)
                {
                    foreach (var ponto in listaponto)
                    {
                        dP = Math.Sqrt(Math.Pow(ponto.X - x, 2) + Math.Pow(ponto.Y - y, 2));

                        if (txbPeso.Text == "")
                        {
                            txbPeso.Text = "1";
                        }

                        ipSeparado = Math.Pow((1d / dP), Double.Parse(txbPeso.Text)); //Colocar uma variavvel no forms

                        iP += ipSeparado;

                        numerador = (ponto.Intensidade * ipSeparado);

                        numerador = double.IsNaN(numerador) ? 0 : numerador;
                        numerador = double.IsInfinity(numerador) ? 0 : numerador;

                        numerador2 += numerador;

                        Mapa[ponto.Y, ponto.X] = ponto.Intensidade;
                    }

                    numerador2 /= iP;
                    mapa[y, x] = numerador2;

                    iP = 0;
                    numerador2 = 0;

                }
            }

            Heatmap hm = Painel.Plot.Add.Heatmap(Mapa);
            hm.Colormap = new Turbo();
            hm.Smooth = true;

            //Painel.Plot.Add.ColorBar(hm);
            //ColorBar cb = new(hm);

            //RemoveCB(cb);
            //criar uma fun��o que resgata o mapa atualizado

            //TALVES DA PRA COLOCAR UM REMOVE AIIIIIIII PAINEL.REMOVE(CB)
        }

        void RemoveCB(ColorBar cb)
        {
            Painel.Plot.Remove(cb);
        }
        void AddCB(Heatmap hm)
        {
            Painel.Plot.Add.ColorBar(hm);
        }

        void CriaPontos()
        {
            ListaPonto.Clear();
            foreach (var ponto in valoresAdiconados)
            {
                Ponto novoPonto = new Ponto((int)ponto[0], (int)ponto[1], ponto[2]);
                ListaPonto.Add(novoPonto);

            }
        }
        void CriaGrafico()
        {

            //Painel.Plot.Clear();
            Mapa = new double[100, 100];
            Interpolate(Mapa, ListaPonto);

            //interpolar2(Mapa,PontoA,  PontoB,  PontoC, PontoD);

            Painel.Refresh();
        }
        private void PreencheListView(ListView listview, string nome, string x, string y, string intensidade)
        {
            ListViewItem item = new ListViewItem(new[] { nome, x, y, intensidade });
            listview.Items.Add(item);
        }


        public Form1()
        {
            InitializeComponent();
        }



        //EVENTOS TXB
        private void txbPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key.IntNumber_Ponto(e,sender);
        }
        private void txbEixoX_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key.IntNumber(e);
        }

        private void txbEixoY_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key.IntNumber(e);
        }

        private void txbIntensidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key.IntNumber_Ponto(e, sender);
        }

        //EVENTOS BTN
        private void btnCriarGrafico_Click(object sender, EventArgs e)
        {
            rodado += 1;
            Mapa = new double[100, 100];


            CriaPontos();
            CriaGrafico();
        }

        private void btnEnviarValores_Click(object sender, EventArgs e)
        {


            if (txbEixoX.Text == "" || txbEixoY.Text == "" || txbIntensidade.Text == "")
            {
                MessageBox.Show("Adicione Valores", "Aten��o");
            }
            else
            {
                if (Int32.Parse(txbEixoX.Text) > 99 || Int32.Parse(txbEixoY.Text) > 99 || Int32.Parse(txbEixoX.Text) < 0 || Int32.Parse(txbEixoY.Text) < 0)
                {
                    MessageBox.Show("X ou Y maiores que 99 ou menores que 0");
                }
                else
                {
                    valoresAdiconados.Add([Int32.Parse(txbEixoX.Text), Int32.Parse(txbEixoY.Text), Double.Parse(txbIntensidade.Text, CultureInfo.InvariantCulture)]);

                    txbEixoX.Text = "";
                    txbEixoY.Text = "";
                    txbIntensidade.Text = "";
                    lsvValoresAdicionados.Items.Clear();

                    indexValoresAdicionados = 0;
                    foreach (var values in valoresAdiconados)
                    {
                        indexValoresAdicionados++;
                        PreencheListView(lsvValoresAdicionados, $"Ponto {indexValoresAdicionados}", values[0].ToString(), values[1].ToString(), values[2].ToString());
                    }
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsvValoresAdicionados.Columns.Add("Nome", 55, System.Windows.Forms.HorizontalAlignment.Center);
            lsvValoresAdicionados.Columns.Add("X", 55, System.Windows.Forms.HorizontalAlignment.Center);
            lsvValoresAdicionados.Columns.Add("Y", 55, System.Windows.Forms.HorizontalAlignment.Center);
            lsvValoresAdicionados.Columns.Add("Intensidade", 115, System.Windows.Forms.HorizontalAlignment.Center);

            Heatmap hm = Painel.Plot.Add.Heatmap(Mapa);
            hm.Colormap = new Turbo();
            //Painel.Plot.Add.Heatmap(Mapa);
            Painel.Plot.Add.ColorBar(hm);


            //Variaveis de inicializa��o do Scott, nao esta aparecendo valored no cb


        }


    }

}
