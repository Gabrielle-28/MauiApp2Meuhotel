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

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new HospedagemContratada());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
