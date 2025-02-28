using ScottPlot;
using ScottPlot.Colormaps;
using ScottPlot.Panels;
using ScottPlot.Plottables;
using ScottPlot.TickGenerators.Financial;
using ScottPlot.WinForms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IDW
{
    public partial class FormPrincipal : Form
    {
        int TamanhoMapaX = 100;
        int TamanhoMapaY = 100;
        private List<double[]> valoresAdiconados = new List<double[]>();
        public List<double> PoligonoX = new List<double>();
        public List<double> PoligonoY = new List<double>();
        private List<Ponto> ListaPonto = new List<Ponto>();
        private double[,] Mapa = new double[100, 100];

        private int indexValoresAdicionados;
        private double Numerador;
        private double iP;
        private double iPIndividual;
        private double dP;
        private double SomatorioNumerador;

        private bool temPlanoPersonalizado = false;

        Ponto PontoA = new(25, 25, 80);
        Ponto PontoB = new(75, 25, 10);
        Ponto PontoC = new(75, 75, 10);
        Ponto PontoD = new(25, 75, 50);

        public FormPrincipal()
        {
            InitializeComponent();
        }

        //FUNÇOES VOID
        void resetaListViewPrincipal()
        {
            lsvValoresAdicionados.Clear();
            lsvValoresAdicionados.Columns.Add("Nome", 55, System.Windows.Forms.HorizontalAlignment.Center);
            lsvValoresAdicionados.Columns.Add("X", 55, System.Windows.Forms.HorizontalAlignment.Center);
            lsvValoresAdicionados.Columns.Add("Y", 55, System.Windows.Forms.HorizontalAlignment.Center);
            lsvValoresAdicionados.Columns.Add("Intensidade", 115, System.Windows.Forms.HorizontalAlignment.Center);
        }
        void Interpolate(double[,] mapa, List<Ponto> listaponto)
        {
            //Organizando  formula para ter valores nao pré definidos
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

                        iPIndividual = Math.Pow((1d / dP), Double.Parse(txbPeso.Text));

                        iP += iPIndividual;

                        Numerador = (ponto.Intensidade * iPIndividual);

                        Numerador = double.IsNaN(Numerador) ? 0 : Numerador;
                        Numerador = double.IsInfinity(Numerador) ? 0 : Numerador;

                        SomatorioNumerador += Numerador;

                        Mapa[ponto.Y, ponto.X] = ponto.Intensidade;
                    }

                    SomatorioNumerador /= iP;
                    mapa[y, x] = SomatorioNumerador;

                    iP = 0;
                    SomatorioNumerador = 0;

                }
            }

            Heatmap hm = PainelPrincipal.Plot.Add.Heatmap(Mapa);
            hm.Colormap = new Turbo();
            AtualizaPainel();





            double[] xs = { 50, 60, 70, 99.5, 99.5, -0.5, -0.5, 99.5, 99.5 };  //(-0.5,-0.5,99.5,-0.5) x inicio x final   igual o pygame
            double[] ys = { 30, 50, 30, -0.5, 99.5, 99.5, -0.5, -0.5, 30 }; //(-0.5,-0.5,-0.5,99.5) y inicio y final

            //var poligono = Painel.Plot.Add.Polygon(xs, ys);
            //poligono.LineWidth = 10;
            //poligono.LineColor = Colors.Blue;
            //poligono.FillColor = Colors.Blue;

            //hm.Smooth = true;

            //Painel.Plot.Add.ColorBar(hm);
            //ColorBar cb = new(hm);

            //RemoveCB(cb);
            //criar uma função que resgata o mapa atualizado

            //TALVES DA PRA COLOCAR UM REMOVE AIIIIIIII PAINEL.REMOVE(CB)
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
            Mapa = new double[TamanhoMapaX, TamanhoMapaY];
            Interpolate(Mapa, ListaPonto);

            //interpolar2(Mapa,PontoA,  PontoB,  PontoC, PontoD);

            PainelPrincipal.Refresh();
        }
        void PreencheListView(ListView listview, string nome, string x, string y, string intensidade)
        {
            ListViewItem item = new ListViewItem(new[] { nome, x, y, intensidade });
            listview.Items.Add(item);
        }

        //PUBLIC
        public void GetInfo(List<double> PoliX, List<double> PoliY)
        {
            PoligonoX.Clear(); PoligonoY.Clear();

            foreach (var poliX in PoliX)
            {
                PoligonoX.Add(poliX - 0.5);
            }
            foreach (var poliY in PoliY)
            {
                PoligonoY.Add(poliY - 0.5);
            }
        }
        public void AtualizaPainel()
        {
            PainelPrincipal.Plot.Clear();
            Heatmap hm = PainelPrincipal.Plot.Add.Heatmap(Mapa);

            var p = PainelPrincipal.Plot.Add.Polygon(PoligonoX, PoligonoY);
            p.LineWidth = 1;
            p.LineColor = Colors.White;
            p.FillColor = Colors.White;

            PainelPrincipal.Refresh();
        }


        //EVENTOS TXB
        private void txbPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key.IntNumber_Ponto(e, sender);
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
            CriaPontos();
            CriaGrafico();
        }
        private void btnCarregaCSV_Click(object sender, EventArgs e)
        {
            valoresAdiconados.Clear();
            resetaListViewPrincipal();

            string fileContent;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    var filePath = openFileDialog.OpenFile();


                    using (StreamReader sr = new StreamReader(filePath))
                    {


                        //talvez apagar o conteudo que esta na lista valores
                        while (!sr.EndOfStream)
                        {
                            string linha = sr.ReadLine(); // lê uma linha do csv
                            string[] valores = linha.Split(';'); // divide pelos separadores

                            valoresAdiconados.Add([Int32.Parse(valores[0]), Int32.Parse(valores[1]), Double.Parse(valores[2], CultureInfo.InvariantCulture)]);
                        }
                        indexValoresAdicionados = 0;

                        foreach (var values in valoresAdiconados)
                        {
                            indexValoresAdicionados++;
                            PreencheListView(lsvValoresAdicionados, $"Ponto {indexValoresAdicionados}", values[0].ToString(), values[1].ToString(), values[2].ToString());
                        }
                    }
                }
            }
            CriaPontos();
            CriaGrafico();
        }
        private void btnEnviarValores_Click(object sender, EventArgs e)
        {


            if (txbEixoX.Text == "" || txbEixoY.Text == "" || txbIntensidade.Text == "")
            {
                MessageBox.Show("Adicione Valores", "Atenção");
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

        //Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            resetaListViewPrincipal();



            Heatmap hm = PainelPrincipal.Plot.Add.Heatmap(Mapa);

            // hm.Position = new(0, 100, 0, 100);
            //hm.Colormap = new Turbo();
            //Painel.Plot.Add.Heatmap(Mapa);
            //Painel.Plot.Add.ColorBar(hm);


            //var poligono = Painel.Plot.Add.Polygon(xs, ys);
            // poligono.LineWidth = 0;
            //poligono.LineColor = Colors.Blue;
            // poligono.FillColor = Colors.Purple;

            // atualiza o gráfico


            PainelPrincipal.Refresh();




        }

        //Menu Bar
        private void personalizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPoligonoPersonalizado FormPersonalizadoInstancia = new(this);

            FormPersonalizadoInstancia.Show();
        }

        private void triânguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelPrincipal.Plot.Clear();
            Heatmap hm = PainelPrincipal.Plot.Add.Heatmap(Mapa);

            PoligonoX = new List<double>() { -0.5, 49.75, 99.5, 99.5, -0.5 };  // x inicio x final   igual o pygame
            PoligonoY = new List<double>() { -0.5, 99.5, -0.5, 99.5, 99.5 }; // y inicio y final

            var poligono = PainelPrincipal.Plot.Add.Polygon(PoligonoX, PoligonoY);
            poligono.LineWidth = 1;
            poligono.LineColor = Colors.White;
            poligono.FillColor = Colors.White;

            PainelPrincipal.Refresh();
        }

    }

}
