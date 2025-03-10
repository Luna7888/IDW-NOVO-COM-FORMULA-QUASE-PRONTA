using ScottPlot;
using ScottPlot.Plottables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace IDW
{

    public partial class FormPoligonoPersonalizado : Form
    {
        private FormPrincipal _principal;
        int TamanhoMapaX = 100;
        int TamanhoMapaY = 100;
        private List<double[]> valoresAdiconados = new List<double[]>();

        private List<double> PoligonoX_Individual = new List<double> { };
        private List<double> PoligonoY_Individual = new List<double> { };

        private double[,] Mapa = new double[100, 100];

        private int indexValoresAdicionados;

        public FormPoligonoPersonalizado(FormPrincipal principal)
        {
            InitializeComponent();
            _principal = principal;
        }

        void GeraPoligono()
        {
            Painel.Plot.Clear();
            Heatmap hm = Painel.Plot.Add.Heatmap(Mapa);

            double[] xs = { 1, 50, 100, 100, 0 };
            double[] ys = { 1, 100, 0, 100, 100 };

            for (int i = 0; i < indexValoresAdicionados; i++)
            {
                var poligono = Painel.Plot.Add.Polygon(PoligonoX_Individual, PoligonoY_Individual);
                poligono.LineWidth = 2;
            }

            Painel.Refresh();
        }

        void LiberaBotaoPoligono()
        {
            if ((PoligonoX_Individual.Count()) < 3)
            {
                btnEnviaPoligono.Enabled = false;
            }
            else
            {
                btnEnviaPoligono.Enabled = true;
            }
        }

        private void PreencheListView(ListView listview, string nome, string x, string y)
        {
            ListViewItem item = new ListViewItem(new[] { nome, x, y });
            listview.Items.Add(item);
        }

        private void btnEnviarValores_Click(object sender, EventArgs e)
        {
            if (txbEixoX.Text == "" || txbEixoY.Text == "")
            {
                MessageBox.Show("Adicione Valores", "Atenção");
            }
            else
            {
                if (Double.Parse(txbEixoX.Text, CultureInfo.InvariantCulture) > 100 || Double.Parse(txbEixoY.Text, CultureInfo.InvariantCulture) > 100 ||
                    Double.Parse(txbEixoX.Text, CultureInfo.InvariantCulture) < 0 || Double.Parse(txbEixoY.Text, CultureInfo.InvariantCulture) < 0)
                {
                    MessageBox.Show("X ou Y maiores que 100 ou menores que 0");
                }
                else
                {
                    valoresAdiconados.Add([Double.Parse(txbEixoX.Text, CultureInfo.InvariantCulture), Double.Parse(txbEixoY.Text, CultureInfo.InvariantCulture)]);
                    PoligonoX_Individual.Add(Double.Parse(txbEixoX.Text, CultureInfo.InvariantCulture));
                    PoligonoY_Individual.Add(Double.Parse(txbEixoY.Text, CultureInfo.InvariantCulture));

                    txbEixoX.Text = "";
                    txbEixoY.Text = "";
                    lsvValoresAdicionados.Items.Clear();

                    indexValoresAdicionados = 0;
                    foreach (var values in valoresAdiconados)
                    {
                        indexValoresAdicionados++;
                        PreencheListView(lsvValoresAdicionados, $"Ponto {indexValoresAdicionados}", values[0].ToString(), values[1].ToString());
                    }

                }
            }
            GeraPoligono();

            //Deixar nao clicavel antes que a lista tenha no minimo 3
            LiberaBotaoPoligono();
        }

        private void FormPoligonoPersonalizado_Load(object sender, EventArgs e)
        {
            Heatmap hm = Painel.Plot.Add.Heatmap(Mapa);

            lsvValoresAdicionados.Columns.Add("Nome", 111, System.Windows.Forms.HorizontalAlignment.Center);
            lsvValoresAdicionados.Columns.Add("X", 111, System.Windows.Forms.HorizontalAlignment.Center);
            lsvValoresAdicionados.Columns.Add("Y", 111, System.Windows.Forms.HorizontalAlignment.Center);

            LiberaBotaoPoligono();
        }

        private void btnEnviaPoligono_Click(object sender, EventArgs e)
        {

            Close();
            int qnttPontos;
            qnttPontos = PoligonoX_Individual.Count();

            PoligonoX_Individual.Add(0);
            PoligonoX_Individual.Add(100);
            PoligonoX_Individual.Add(100);
            PoligonoX_Individual.Add(0);
            PoligonoX_Individual.Add(0);
            PoligonoX_Individual.Add(PoligonoX_Individual[qnttPontos - 1]);


            PoligonoY_Individual.Add(100);
            PoligonoY_Individual.Add(100);
            PoligonoY_Individual.Add(0);
            PoligonoY_Individual.Add(0);
            PoligonoY_Individual.Add(100);
            PoligonoY_Individual.Add(PoligonoY_Individual[qnttPontos - 1]);


            _principal.GetInfo(PoligonoX_Individual, PoligonoY_Individual);
            _principal.AtualizaPainel();

        }

        private void txbEixoX_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key.IntNumber_Ponto(e, sender);
        }

        private void txbEixoY_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key.IntNumber_Ponto(e, sender);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}