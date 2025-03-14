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

        private ColorBar _colorBar;

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
            int j = mapa.GetLength(0);
            int h = mapa.GetLength(1);
            //Organizando  formula para ter valores nao pré definidos
            for (int y = 0; y < j; y++)
            {
                for (int x = 0; x < h; x++)
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

            if(_colorBar != null)
            {
                PainelPrincipal.Plot.Remove(_colorBar);
            }
            Heatmap hm = PainelPrincipal.Plot.Add.Heatmap(Mapa);
            hm.Colormap = new Turbo();
            hm.Smooth = true;
            _colorBar = PainelPrincipal.Plot.Add.ColorBar(hm);
            PainelPrincipal.Refresh();

            CortaPlano();

        }
        void CriaPontos()
        {
            ListaPonto.Clear();
            foreach (var ponto in valoresAdiconados)
            {
                Ponto novoPonto = new Ponto((int)ponto[0], Math.Abs((int)PoligonoY.Max<double>() - (int)ponto[1]), ponto[2]);
                ListaPonto.Add(novoPonto);

            }
        }
        void CortaPlano()
        {
            var p = PainelPrincipal.Plot.Add.Polygon(PoligonoX, PoligonoY);
            p.LineWidth = 2;
            p.LineColor = Colors.White;
            p.FillColor = Colors.White;

            PainelPrincipal.Refresh();
        }
        void LiberaBotaoPoligono()
        {
            if ((valoresAdiconados.Count()) < 2)
            {
                btnCriarGrafico.Enabled = false;
            }
            else
            {
                btnCriarGrafico.Enabled = true;
            }
        }
        void LiberaObjetosDisabled()
        {
            btnCarregaCSV.Enabled = true;
            btnEnviarValores.Enabled = true;
            txbEixoX.Enabled = true;
            txbEixoY.Enabled = true;
            txbIntensidade.Enabled = true;
            txbPeso.Enabled = true;
        }
        void CriaGrafico()
        {
            PainelPrincipal.Plot.Clear();

            if (PoligonoX.Count() > 0)
            {
                Mapa = new double[(int)Math.Round(PoligonoY.Max<double>()), (int)Math.Round(PoligonoX.Max<double>())];
            }
            else
            {
                Mapa = new double[100, 100];
            }
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
            //PainelPrincipal.Plot.Clear();
            if (PoligonoX.Count > 0)
            {
                Mapa = new double[(int)Math.Round(PoligonoY.Max<double>()), (int)Math.Round(PoligonoX.Max<double>())];
            }

            Heatmap hm = PainelPrincipal.Plot.Add.Heatmap(Mapa);

            var p = PainelPrincipal.Plot.Add.Polygon(PoligonoX, PoligonoY);
            p.LineWidth = 2;
            p.LineColor = Colors.White;
            p.FillColor = Colors.White;

            PainelPrincipal.Refresh();
            resetaListViewPrincipal();

            LiberaObjetosDisabled();
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
                else
                {
                    return;
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
            LiberaBotaoPoligono();
        }

        //Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            resetaListViewPrincipal();

            PainelPrincipal.Refresh();

            LiberaBotaoPoligono();


        }

        //Menu Bar
        private void personalizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPoligonoPersonalizado FormPersonalizadoInstancia = new(this);

            FormPersonalizadoInstancia.Show();
        }

    }

}
