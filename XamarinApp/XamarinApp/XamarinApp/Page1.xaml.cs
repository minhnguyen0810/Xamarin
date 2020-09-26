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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void onClick1(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "minh" && txtMatKhau.Text =="123"){
                Navigation.PushAsync(new TinhTong());
            }
            else
            {
                DisplayAlert("Dang nhap khong thanh cong", "ok", "ok");
            }
        }
    }
}