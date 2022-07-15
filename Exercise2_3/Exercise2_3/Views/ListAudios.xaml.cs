using Exercise2_3.Models;
using MediaManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercise2_3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListAudios : ContentPage
    {
        public ListAudios()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ListaAudio.ItemsSource = await App.BaseDatos.GetListAudios();//LLENAR LA LISTAA DE COLLECTION
        }
        private async void SwipeItem_Invoked(object sender, EventArgs e)
        {
            SwipeItem item = sender as SwipeItem;//OBTENER EL ITEM DE SWIPE
            Audio item2 = (Audio)item.BindingContext; //CONVERTIR SU BINDING A AUDIO
            await CrossMediaManager.Current.Play(item2.path); //USAR ESE AUDIO PARA MANDAR EL PATH A REPRODUCIR
        }
        protected async override void OnDisappearing()
        {
            base.OnDisappearing();
            await CrossMediaManager.Current.Stop();
        }

    }
}