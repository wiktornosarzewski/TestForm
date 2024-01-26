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

namespace WindowsForms
{
    public partial class FormOKNO : Form
    {
        public FormOKNO()
        {
            InitializeComponent();

            listBox.Items.Add(2);
            listBox.Items.Add("DOM");
            listBox.Items.Add(2.3+3.4);
            listBox.Items.Add(false);
            listBox.Items.Add(new Animal("Reksio"));

            chart.Series.Clear();

            Series s = new Series();
            Series s2 = new Series();
            chart.Series.Add(s);
            chart.Series.Add(s2);
            s.ChartType = SeriesChartType.Line;
            s2.ChartType = SeriesChartType.Line;

            s.Name = "Wykres";
            s.Color = Color.Red;
            s.BorderWidth = 6;

            for (int x = -10; x<=10; x++)
            {
                s.Points.AddXY(x, x*x);
                s2.Points.AddXY(x, x*x-2*x-2);
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                int l1 = Convert.ToInt32(this.textBoxL1.Text);
                int l2 = Convert.ToInt32(this.textBoxL2.Text);
                int wynik = l1 + l2;

                MessageBox.Show($"Wynik operacji to: {wynik}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Podałeś błędne liczby ({ex.Message})");
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            /*            if (listBox.SelectedItem is int)
                        {
                            MessageBox.Show("INT");
                        }
                        else if (listBox.SelectedItem is bool)
                        {
                            MessageBox.Show("BOOL");
                        }
                        else if (listBox.SelectedItem is double)
                        {
                            MessageBox.Show("DOUBLE");
                        }
                        else if (listBox.SelectedItem is Animal)
                        {
                            MessageBox.Show("hau");
                        }
            */
            MessageBox.Show(
$@"Wybraliśmy z listy element typu
{listBox.SelectedItem.GetType().FullName}
o wartości
{listBox.SelectedItem.ToString()}");
        }
    }
}
