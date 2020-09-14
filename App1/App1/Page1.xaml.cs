using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
        private void Button_Clicked1(object sender, EventArgs e)
        {
            id.Text = "";
            pass.Text = "";
        }
        private async void Button_Clicked2(object sender, EventArgs e)
        {            
            if (id.Text != "Aluno") {
                await DisplayAlert("Alert", "Id inválido", "OK");
                return;
            }
            if (pass.Text != "123")
            {
                await DisplayAlert("Alert", "Senha inválida", "OK");
                return;
            }

            await Navigation.PushAsync(new Page2());

        }
    }
}