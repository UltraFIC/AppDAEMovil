using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AppDAEMovil.Interfaces.SQLite;
using AppDAEMovil.Data;
using AppDAEMovil.Interfaces.Inventarios;
using AppDAEMovil.Models;

namespace AppDAEMovil.Services.Inventarios
{
    public class FicSrvReporteAcumuladosLista : FicInterFaceReporteAcumuladosLista
    {
        private FicDBContext FicLocalDBContext;
        private readonly HttpClient FicHttpClient;
        //FIC: Constructor
        public FicSrvReporteAcumuladosLista()
        {
            FicLocalDBContext = new FicDBContext(DependencyService.Get<IFicDataBasePathSQLite>().FicGetDataBasePath());
            FicHttpClient = new HttpClient();
        }
        //FIC: Implementar los metodos definidos en la Inteface del Servicio.
        //FIC: Metodo que obtiene los registros de todos los catalogos de la nube ======================================
        public async Task<List<zt_inventarios_acumulados>>FicIMetGetListaAcumuladosWebApi(int FicPaIdInventario)
        {
            //                    https://localhost:44300/api/inventarios/inv_acumulados_list?FicPaIdInventario=21
            //const string url = "https://localhost:44300/api/inventarios/inv_acumulados_list?FicPaIdInventario=21";
            string FicURL = FicAppSettings.FicUrlBase.ToString() + "api/inventarios/inv_acumulados_list" +
                                                                "?FicPaIdInventario=" + FicPaIdInventario;
            try
            {
                var FicResponse = await FicHttpClient.GetAsync(FicURL);
                
                return FicResponse.IsSuccessStatusCode ? JsonConvert.DeserializeObject<List<zt_inventarios_acumulados>>(await FicResponse.Content.ReadAsStringAsync()) : null;
            }
            catch (Exception e)
            {
                await new Page().DisplayAlert("ERROR", e.Message.ToString(), "Ok");
                return null;
            }
        }


    }
}
