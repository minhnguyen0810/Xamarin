using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TinhTong : ContentPage
    {
        public TinhTong()
        {
            InitializeComponent();
        }

        void phepTinhTong()
        {
            double soA=0;
            double soB =0;
            double.TryParse(txtSoA.Text,out soA);
            double.TryParse(txtSoB.Text,out soB);
            txtKq.Text = (soA + soB).ToString();
        }
        private void tinhTong(object sender, EventArgs e)
        {
            double soA, soB;
            soA = double.Parse(txtSoA.Text);
            soB = double.Parse(txtSoB.Text);
            txtKq.Text = (soA + soB).ToString();
        }

        private void txtSoA_TextChanged(object sender, TextChangedEventArgs e)
        {
            phepTinhTong();
        }
        private void txtSoB_TextChanged(object sender, TextChangedEventArgs e)
        {
            phepTinhTong();
        }
    }
}