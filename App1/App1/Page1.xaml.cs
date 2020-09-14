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

        private void Limpar()
        {
            id.Text = "";
            pass.Text = "";

        }

       

        private async void Creditos(object sender, EventArgs e)
        {
            Limpar();
            await Navigation.PushAsync(new Page3());

        }
        private void BtnLimpar(object sender, EventArgs e)
        {
            Limpar();
            id.CursorPosition = 1;
        }
        private async void Entrar(object sender, EventArgs e)
        {            
            if (id.Text != "admin" || pass.Text != "@dmin") {
                await DisplayAlert("Alert", "Usuário não autorizado", "OK");
                return;
            }

            Limpar();
            
            await Navigation.PushAsync(new Page2());

        }
    }
}