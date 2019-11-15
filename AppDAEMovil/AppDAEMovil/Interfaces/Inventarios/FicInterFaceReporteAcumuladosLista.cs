using System.Threading.Tasks;
using AppDAEMovil.Models;
using System.Collections.Generic;


namespace AppDAEMovil.Interfaces.Inventarios
{
    public interface FicInterFaceReporteAcumuladosLista
    {
        Task<List<zt_inventarios_acumulados>>FicIMetGetListaAcumuladosWebApi(int FicPaIdInventario);
        //Task<zt_inventarios_acumulados> FicIMetGetAcumuladosItemWebApi(int FicPaIdInventario, int FicPaIdSKU);
        //Task<string>FicIMetGetAcumuladosWebApi(int FicPaIdInventario);
    }
}
