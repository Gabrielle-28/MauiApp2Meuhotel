using System;
using Microsoft.Maui.Controls;

namespace MauiApp2Meuhotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        public ContratacaoHospedagem()
        {
            InitializeComponent();
        }

        private async void OnSobreButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SobrePage());
        }
    }
}
