using ScottPlot;
using ScottPlot.Colormaps;
using ScottPlot.Panels;
using ScottPlot.Plottables;
using System.Globalization;

namespace IDW
{
    public partial class FormPrincipal : Form
    {
        private List<double[]> valoresAdiconados = new List<double[]>();
        public List<double> PoligonoX = new List<double>();
        public List<double> PoligonoY = new List<double>();
        List<double[]> valoresAdicionadosCopia = new List<double[]>();
        private List<Ponto> ListaPonto = new List<Ponto>();
        private double[,] Mapa = new double[100, 100];
        private int[] MapaCalculado = new int[2];

        private int indexValoresAdicionados;
        private double Numerador;
        private double iP;
        private double iPIndividual;
        private double dP;
        private double SomatorioNumerador;
        private bool temPlanoPersonalizado = false;
        private int unidadeDeMedida;
        private int PPI = 96;

        private ColorBar _colorBar;

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
            int altura = mapa.GetLength(0);
            int largura = mapa.GetLength(1);
            
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
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

            if (_colorBar != null)
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
                if (ponto[1] == 0)
                {
                    Ponto novoPonto = new Ponto((int)ponto[0], Math.Abs((int)(PoligonoY.Max<double>()-1) - (int)ponto[1]), ponto[2]);
                    ListaPonto.Add(novoPonto);
                }
                else
                {
                    Ponto novoPonto = new Ponto((int)ponto[0], Math.Abs((int)(PoligonoY.Max<double>()) - (int)ponto[1]), ponto[2]);
                    ListaPonto.Add(novoPonto);
                }
                

               
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

            PainelPrincipal.Refresh();
        }
        void PreencheListView(ListView listview, string nome, string x, string y, string intensidade)
        {
            ListViewItem item = new ListViewItem(new[] { nome, x, y, intensidade });
            listview.Items.Add(item);
        }

        //PUBLIC
        public void GetInfo(List<double> PoliX, List<double> PoliY, int Unidade)
        {
            unidadeDeMedida = Unidade;

            if (unidadeDeMedida == 0)
            {
                toolStripStatusLabel1.Text = "Unidade de Medida: Centimetro";          //atualiza statusStrip
            }
            if (unidadeDeMedida == 1)
            {
                toolStripStatusLabel1.Text = "Unidade de Medida: Milimetro";
            }
            if (unidadeDeMedida == 2)
            {
                toolStripStatusLabel1.Text = "Unidade de Medida: Pixel";
            }

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
            if (PoligonoX.Count > 0)
            {
                Mapa = new double[(int)Math.Round(PoligonoY.Max<double>()), (int)Math.Round(PoligonoX.Max<double>())];
            }

            Heatmap hm = PainelPrincipal.Plot.Add.Heatmap(Mapa);

            var p = PainelPrincipal.Plot.Add.Polygon(PoligonoX, PoligonoY);
            p.LineWidth = 2;
            p.LineColor = Colors.White;
            p.FillColor = Colors.White;


            var yAxis2 = PainelPrincipal.Plot.Axes.AddLeftAxis();

            // add a new plottable and tell it to use the custom Y axis
            var sig2 = PainelPrincipal.Plot.Add.Signal(Generate.Cos(51, mult: 100));       //double[]
            sig2.Axes.XAxis = PainelPrincipal.Plot.Axes.Bottom; // standard X axis
            sig2.Axes.YAxis = yAxis2; // custom Y axis
            yAxis2.LabelText = "Secondary Y Axis";


            PainelPrincipal.Refresh();
            resetaListViewPrincipal();

            LiberaObjetosDisabled();
        }

        //EVENTOS TXB
        private void txbPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key.IntNumber_Ponto(e, sender);  // Classe Key nao permite letras nas txb 
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
                    var filePath = openFileDialog.OpenFile();

                    using (StreamReader sr = new StreamReader(filePath))
                    {
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
            btnCriarGrafico.Enabled = true;
        }
        private void btnEnviarValores_Click(object sender, EventArgs e)
        {

            if (txbEixoX.Text == "" || txbEixoY.Text == "" || txbIntensidade.Text == "")
            {
                MessageBox.Show("Adicione Valores", "Atenção");
                return;
            }

            else
            {
                double X = Int32.Parse(txbEixoX.Text);
                double Y = Int32.Parse(txbEixoY.Text);

                if (unidadeDeMedida == 0)
                {

                    MapaCalculado[0] = (int)Math.Round(Mapa.GetLength(1) / (PPI / 2.54));
                    MapaCalculado[1] = (int)Math.Round(Mapa.GetLength(0) / (PPI / 2.54));

                    if (Int32.Parse(txbEixoX.Text) >= MapaCalculado[0] || Int32.Parse(txbEixoY.Text) >= MapaCalculado[1])
                    {
                        MessageBox.Show($"Os valores de Index de X vão de 0 até {MapaCalculado[0] - 1}\nOs valores de Index de Y vão de 0 até {MapaCalculado[1] - 1}", "Atenção | Limites do Mapa");
                        return;
                    }

                    if (Int32.Parse(txbEixoX.Text) > MapaCalculado[0] || Int32.Parse(txbEixoY.Text) > MapaCalculado[1])
                    {
                        MessageBox.Show("Valores de X ou Y maiores que o mapa fornecido", "Atenção");
                        return;
                    }
                    else
                    {
                        statusStrip1.Text = "Unidade de Medida: Cm";
                        X = Double.Parse(txbEixoX.Text) * (PPI / 2.54);
                        Y = Double.Parse(txbEixoY.Text) * (PPI / 2.54);

                    }


                }
                if (unidadeDeMedida == 1)
                {
                    MapaCalculado[0] = (int)Math.Round(Mapa.GetLength(1) / (PPI / 2.54) * 10);
                    MapaCalculado[1] = (int)Math.Round(Mapa.GetLength(0) / (PPI / 2.54) * 10);

                    if (Int32.Parse(txbEixoX.Text) >= MapaCalculado[0] || Int32.Parse(txbEixoY.Text) >= MapaCalculado[1])
                    {
                        MessageBox.Show($"Os valores de Index de X vão de 0 até {MapaCalculado[0] - 1}\nOs valores de Index de Y vão de 0 até {MapaCalculado[1] - 1}", "Atenção | Limites do Mapa");
                        return;
                    }

                    if (Int32.Parse(txbEixoX.Text) > MapaCalculado[0] || Int32.Parse(txbEixoY.Text) > MapaCalculado[1])
                    {
                        MessageBox.Show("Valores de X ou Y maiores que o mapa fornecido", "Atenção");
                        return;
                    }
                    else
                    {
                        statusStrip1.Text = "Unidade de Medida: Mm";
                        Y = (Double.Parse(txbEixoY.Text) * (PPI / 2.54) / 10);
                        X = (Double.Parse(txbEixoX.Text) * (PPI / 2.54) / 10);

                    }

                }
                if (unidadeDeMedida == 2)
                {

                    MapaCalculado[0] = Mapa.GetLength(1);
                    MapaCalculado[1] = Mapa.GetLength(0);

                    if (Int32.Parse(txbEixoX.Text) >= MapaCalculado[0] || Int32.Parse(txbEixoY.Text) >= MapaCalculado[1])
                    {
                        MessageBox.Show($"Os valores de Index de X vão de 0 até {MapaCalculado[0] - 1}\nOs valores de Index de Y vão de 0 até {MapaCalculado[1] - 1}", "Atenção | Limites do Mapa");
                        return;
                    }

                    if (Int32.Parse(txbEixoX.Text) > MapaCalculado[0] || Int32.Parse(txbEixoY.Text) > MapaCalculado[1])
                    {
                        MessageBox.Show("Valores de X ou Y maiores que o mapa fornecido", "Atenção");
                        return;
                    }
                    else
                    {
                        statusStrip1.Text = "Unidade de Medida: Px";
                        X = Double.Parse(txbEixoX.Text);
                        Y = Double.Parse(txbEixoY.Text);
                    }

                }

                valoresAdicionadosCopia.Add([Int32.Parse(txbEixoX.Text), Int32.Parse(txbEixoY.Text), Double.Parse(txbIntensidade.Text, CultureInfo.InvariantCulture)]);
                valoresAdiconados.Add([(int)X, (int)Y, Double.Parse(txbIntensidade.Text, CultureInfo.InvariantCulture)]);

                txbEixoX.Text = "";
                txbEixoY.Text = "";
                txbIntensidade.Text = "";
                lsvValoresAdicionados.Items.Clear();

                indexValoresAdicionados = 0;
                foreach (var values in valoresAdicionadosCopia)
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
