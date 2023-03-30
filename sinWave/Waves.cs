using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace wfa_complex
{
    internal class Waves:IDisposable
    {
        private double time;
        private double phase;
        private double amplitude;
        private double frequency;
        public Waves(double Time = 1, double Phase = 0, double Amplitude = 1, double Frequency = 1)
        {
            this.time = Time;
            this.phase = Phase;
            this.amplitude = Amplitude;
            this.frequency = Frequency;
        }

        internal void Show(Chart chart1,string seriesName )
        {
            string newName = seriesName;
            try
            {
                    chart1.Series.Add(newName);
                    chart1.Series[newName].ChartType = SeriesChartType.Point;
                    chart1.Series[newName].MarkerSize = 3;

                for (double i = phase; i < time; i += 0.0001)
                {
                    double value = amplitude * Math.Sin(i*2*Math.PI*frequency);
                    chart1.Series[newName].Points.AddXY(i, value);
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message);}
           // chart1.Series.Remove(chart1.Series[seriesName]);
        }
        public static List<double> InverseFourier(double samplingFrequency, params Waves[] waves)
        {
            List<double> valuesOfNewWave = new List<double>();
            valuesOfNewWave.Add(samplingFrequency);
            for (double i = 0; i < waves[0].time; i += 1/samplingFrequency)
            {
                double value=0;
                foreach (var obj in waves)
                {
                    value += obj.amplitude * Math.Sin(i * Math.PI*2 * obj.frequency + obj.phase);
                }
                valuesOfNewWave.Add(value);
            }
            return valuesOfNewWave;
        }

        public void Dispose()
        {
           
        }

        internal static void CalcAvgOfValues(List<Waves> waves,double samplingFrequency = 1000,Chart chart=null)
        {
            double value;
            chart.Series.Add("Series1");
            foreach (var obj in waves)
            {
               value=0;
                for (double i = 0; i < waves[0].time; i += 1 / samplingFrequency)
                {

                    value += obj.amplitude * Math.Sin(i * 2 * Math.PI * obj.frequency + obj.phase) / (samplingFrequency * waves[0].time);

                }
                chart.Series["Series1"].Points.AddXY(obj.frequency, value);
            }
            
          }
        
    internal static double CalcDotProduct(Waves wave1,Waves wave2, double samplingFrequency = 1000)
    {
            double value = 0;
            for (double i = 0; i < 2*Math.PI * wave1.time; i += 2 * Math.PI / samplingFrequency)
            {

                value += (wave1.amplitude * Math.Sin(wave1.phase + 2 * Math.PI * wave1.frequency * i))
                       * (wave2.amplitude * Math.Sin(wave2.phase + 2*Math.PI*wave2.frequency*i));
            }
            return value;
    }
        internal static double CalcDotProductWithSampledSignal(out double angle, Waves wave1, List<double> wave2, double samplingFrequency = 1000)
        {
            double sinValue = 0;
            double cosValue = 0;
            double output;
            int j = 1;
            double time = wave2.Count / wave2[0];
            for (double currentvalue = 0; currentvalue < wave2.Count-1; currentvalue += 1)
            {

                sinValue += (wave1.amplitude * Math.Sin(wave1.phase + 2 * Math.PI * currentvalue / wave2[0] * wave1.frequency))
                          *wave2[j];
                cosValue += (wave1.amplitude * Math.Cos(wave1.phase + 2*Math.PI * currentvalue / wave2[0]*wave1.frequency))
                          *wave2[j];
                j++;
            }
            output = Math.Sqrt(Math.Pow(sinValue,2) + Math.Pow(cosValue,2));
            if (output/wave2.Count/3 >0.01)
            {
                angle = Math.Atan2(cosValue, sinValue);
            }
            else angle = 0;
            return output/(wave2.Count-1)/3;
        }

        internal static void drawOnComplex(double v1, double v2)
        {
            double aTan = Math.Atan(v2/v1);
            aTan = 360 * aTan / (2 * Math.PI);
            double magnitude = Math.Sqrt(Math.Pow(v1, 2) + Math.Pow(v2, 2));
            MessageBox.Show($"phase:{aTan}, magnitude:{magnitude}");
        }
    }
}

