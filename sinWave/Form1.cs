using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using wfa_complex;
using static System.Threading.Thread;
namespace sinWave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            signal = new List<double>();
            chartSygnal.Series.Add("Series1");
            chartHz.Series.Add("Series1");
        }
        List<double> signal;
      
        private void WyswietlSygnal(List<double> signal)
        {
            foreach(var obj in signal)
            {
                chartSygnal.Series["Series1"].Points.Add(obj);
            }
        }

        private void GenerujSygnal(int value,int rodzaj)
        {
           List<Waves> listOfWaves = new List<Waves>();
           GenerujListeSygnalow(listOfWaves,value,rodzaj);
           WyznaczWartosciSygnalu(listOfWaves);
        }

        private void WyznaczWartosciSygnalu(List<Waves> listOfWaves)
        {
            signal.Clear();
            signal = Waves.InverseFourier(10000,listOfWaves.ToArray());

        }

        private void GenerujListeSygnalow(List<Waves> listOfWaves, int value, int rodzaj)
        {
            //Jeżeli zostanie wywołany rodzaj 3 sygnału, 'iterator' będzie generował sygnały o każdej częstotliwości.
            int iterator = rodzaj == 3 ? 1: 2;
            //jeżeli rodzaj generowanego sygnału = 3, zmień wartość na 1, aby generować sygnał od 1 hz. 
            rodzaj=rodzaj==3?1:rodzaj;

            Random rand = new Random();
            for (double i = rodzaj; i < value; i += iterator)
            {
                if (iterator == 1)
                {
                    listOfWaves.Add(new Waves(Time: 1, Phase: 0, Amplitude: 6 / (0.5 + rand.NextDouble()), i));
                }
                else
                listOfWaves.Add(new Waves(Time: 1, Phase: 0, Amplitude: 6 /i , i));
            }
        }
        private void btnGenProsto_Click(object sender, EventArgs e)
        {
            chartSygnal.ChartAreas[0].AxisY.Maximum = 10;
            chartSygnal.Series["Series1"].Points.Clear();
            GenerujSygnal(tbZakres.Value, 1);
            WyswietlSygnal(signal);
        }
        private void btnGenPilo_Click(object sender, EventArgs e)
        {
            chartSygnal.ChartAreas[0].AxisY.Maximum = 10;
            chartSygnal.Series["Series1"].Points.Clear();
            GenerujSygnal(tbZakres.Value, 2);
            WyswietlSygnal(signal);
        }

        private void btnGenLosowy_Click(object sender, EventArgs e)
        {
            chartSygnal.ChartAreas[0].AxisY.Maximum = tbZakres.Value *5;
            chartSygnal.Series["Series1"].Points.Clear();
            GenerujSygnal(tbZakres.Value, 3);
            WyswietlSygnal(signal);
        }

        private void btnWyznaczHz_Click(object sender, EventArgs e)
        {
            chartHz.Series["Series1"].Points.Clear();
            for (int i = 0;i<tbZakres.Value;i++)
            {
                chartHz.Series["Series1"].Points.AddXY(i, Waves.CalcDotProductWithSampledSignal(out double angle,new Waves(Frequency:i), signal, 10000));
            }
        }
    }
}
