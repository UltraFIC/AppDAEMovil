using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppDAEMovil.ViewModels.Inventarios;

namespace AppDAEMovil.Views.Inventarios
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FicViReporteAcumuladosLista : ContentPage
	{
		public FicViReporteAcumuladosLista ()
		{
			InitializeComponent ();
            BindingContext = App.FicViewModelDependencyInjection.FicVmReporteAcumuladosLista;
        }

        protected override void OnAppearing()
        {
            //var FicViewModel = Fic
        }
        //FIC: Evento Clicked del boton consultar
        void FicButton_Clicked_Consultar(object sender, EventArgs args)
        {
            //FicGrid_IsVisible_Running.IsVisible = true;
            //FicActivityIndicator_Importar.IsVisible = true;
            //FicActivityIndicator_Importar.IsRunning = true;
            int FicIdInventario = Convert.ToInt32(FicEntry_IdInventario.Text);

            (BindingContext as FicVmReporteAcumuladosLista).FicLoMetGetListaAcumulados( FicIdInventario );
            
            //FicGrid_IsVisible_Running.IsVisible = false;
            //FicActivityIndicator_Importar.IsVisible = false;
            //FicActivityIndicator_Importar.IsRunning = false;
        }

        //FIC: Evento Clicked del boton cancelar
        async void FicButton_Clicked_Cancelar(object sender, EventArgs args)
        {
            bool FicConfirmar = await App.Current.MainPage.DisplayAlert
                                ("ALERTA", "¿Desea Limpiar la Busqueda?", "Sí", "No");
            if (FicConfirmar)
            {
                //FicGrid_IsVisible_Running.IsVisible = true;
                //FicActivityIndicator_Importar.IsVisible = true;
                //FicActivityIndicator_Importar.IsRunning = true;

                FicEntry_IdInventario.Text = "";
                
                //FicGrid_IsVisible_Running.IsVisible = false;
                //FicActivityIndicator_Importar.IsVisible = false;
                //FicActivityIndicator_Importar.IsRunning = false;
            }
        }
    }
}