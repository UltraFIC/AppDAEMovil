using System.Threading.Tasks;
using AppDAEMovil.Models;
using System;
using System.Collections.Generic;


namespace AppDAEMovil.Interfaces.Inventarios
{
    public interface FicInterFaceReporteAcumuladosLista
    {
        Task<List<zt_inventarios_acumulados>>FicIMetGetListaAcumuladosWebApi(int FicPaIdInventario);
        //Task<zt_inventarios_acumulados> FicIMetGetAcumuladosListaWebApi(int FicPaIdInventario);
        //Task<string>FicIMetGetListaAcumuladosWebApi(int FicPaIdInventario);
    }
}
