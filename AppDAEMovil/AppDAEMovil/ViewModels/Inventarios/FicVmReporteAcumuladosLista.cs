using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using AppDAEMovil.Interfaces.Inventarios;
using AppDAEMovil.Models;
//using AppEvaMovilRoot.ViewModels.Base;
//using AppDAEMovil.Interfaces.Navigation;

namespace AppDAEMovil.ViewModels.Inventarios
{
    public class FicVmReporteAcumuladosLista : INotifyPropertyChanged
    {
        //FIC: Declaracion de Navegacion y Servicios ==============================
        //private IFicServiceNavigation IFicSrvNavigationInventario;
        private FicInterFaceReporteAcumuladosLista FicIFSrvReporteAcumuladosLista;

        //FIC: Declaracion de comandos ===========================================
        // aqui van las declaraciones de comandos si hubiera

        //FIC:Controles ==========================================================
        private ObservableCollection<zt_inventarios_acumulados> FicOcSfDataGrid_ItemSource_Acumulado;
        public ObservableCollection<zt_inventarios_acumulados> FicSfDataGrid_ItemSource_Acumulado
        {
            get { return FicOcSfDataGrid_ItemSource_Acumulado; }
            //set
            //{
            //    if (value != null) FicOcSfDataGrid_ItemSource_Acumulado = value;
            //    RaisePropertyChanged("FicLabel_Binding_Bitacora");
            //}
        }

        //FIC: Constructor
        public FicVmReporteAcumuladosLista(FicInterFaceReporteAcumuladosLista FicPaIFSrvReporteAcumuladosLista)
        {
            FicIFSrvReporteAcumuladosLista = FicPaIFSrvReporteAcumuladosLista;
        }

        public void OnAppearing()
        {
            //FIC: aqui se ejecutan los servicios que vayan a llenara algun componente
            //de la vista al abrirse o regresarse.
        }

        public async void FicLoMetGetListaAcumulados(int FicPaIdInventario)
        {
            try
            {
                var FicListaAcumulados = await FicIFSrvReporteAcumuladosLista
                    .FicIMetGetListaAcumuladosWebApi(FicPaIdInventario);

                //FIC: Actualizar el binding de la fuente que llena el grid
                FicOcSfDataGrid_ItemSource_Acumulado = new ObservableCollection<zt_inventarios_acumulados>();
                //FIC: se realiza ciclo for para llenar la fuente del grid
                foreach (zt_inventarios_acumulados acu in FicListaAcumulados)
                {
                    FicOcSfDataGrid_ItemSource_Acumulado.Add(acu);
                }
                //FIC: Se refresca la fuente del grid en la vista
                RaisePropertyChanged("FicSfDataGrid_ItemSource_Acumulado");

            }
            catch (Exception e)
            {
                await App.Current.MainPage.DisplayAlert("Alerta", e.Message.ToString(), "Ok");
            }

        }


        //========================================================================================
        #region  INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }

    
}
