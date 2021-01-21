using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace E10_spar_rechner
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            solution1Label.Text = " ";

            Entry entry = (Entry)sender;
            double result;
            entry.TextColor = Double.TryParse(entry.Text, out result) ? Color.Default : Color.Red;

            solveButton.IsEnabled = Double.TryParse(entry.Text, out result);
        }

        private void entry_Completed(object sender, EventArgs e)
        {
            if (solveButton.IsEnabled)
            {
                rechner();
            }
        }

        private void solveButton_Clicked(object sender, EventArgs e)
        {

        }

        private void rechner()
        {
            double E95Preis = double.Parse(entry.Text);
            double maxPreisE10;
            //theoretischer Mehrverbrauch von ~2% bei der Verwendung von E10 stattE5
            maxPreisE10 = 0.98 * E95Preis;
            solution1Label.Text = "Für eine Ersparnis darf E10 nicht mehr als" + maxPreisE10 + " Cent kosten";
        }
    }
}
