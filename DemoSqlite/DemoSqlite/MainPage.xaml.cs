using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoSqlite
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Cmdthemloaihoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageThemLoaiHoa());
        }

        private void Cmddsloaihoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageDsLoaiHoa());
        }
    }
}
