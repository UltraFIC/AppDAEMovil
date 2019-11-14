
using AppDAEMovil.Interfaces.Inventarios;
using AppDAEMovil.Services.Inventarios;
//using AppDAEMovil.Services.Navigation;
using AppDAEMovil.ViewModels.Inventarios;
using Autofac;

namespace AppDAEMovil.ViewModels.Base
{
    public class FicViewModelDependencyInjection
    {
        private static IContainer FicIContainer;

        public FicViewModelDependencyInjection()
        {
            var FicContainerBuilder = new ContainerBuilder();

            //-------------------------------- VIEW MODELS ------------------------------------------------------

            //FIC: aqui se registran las View Models de las Vistas
            //FicContainerBuilder.RegisterType<FicVmInventariosList>();
            //FicContainerBuilder.RegisterType<FicVmInventarioConteoList>();
            //FicContainerBuilder.RegisterType<FicVmInventarioConteosItem>();
            FicContainerBuilder.RegisterType<FicVmReporteAcumuladosLista>();


            //------------------------- INTERFACE SERVICES OF THE INTERFACES -----------------------------------
            //FIC: aqui se relaciona la implementacion de los metodos de cada servicio con cada interface
            //FicContainerBuilder.RegisterType<FicServiceNavigation>().As<IFicServiceNavigation>().SingleInstance();
            //FicContainerBuilder.RegisterType<FicSrvInventariosList>().As<IFicSrvInventariosList>().SingleInstance();
            //FicContainerBuilder.RegisterType<FicSrvInventariosConteosItem>().As<IFicSrvInventariosConteosItem>().SingleInstance();
            //FicContainerBuilder.RegisterType<FicSrvInventariosConteoList>().As<IFicSrvInventariosConteoList>().SingleInstance();
            FicContainerBuilder.RegisterType<FicSrvReporteAcumuladosLista>().As <FicInterFaceReporteAcumuladosLista>().SingleInstance();
            
            if (FicIContainer != null) FicIContainer.Dispose();

            FicIContainer = FicContainerBuilder.Build();
        }//BUILDER

        //-------------------- CONTROL ------------------------
        //public FicVmInventariosList FicVmInventariosList { get { return FicIContainer.Resolve<FicVmInventariosList>(); } }
        //public FicVmInventarioConteoList FicVmInventarioConteoList { get { return FicIContainer.Resolve<FicVmInventarioConteoList>(); } }
        //public FicVmInventarioAcumuladoList FicVmInventarioAcumuladoList { get { return FicIContainer.Resolve<FicVmInventarioAcumuladoList>(); } }

        public FicVmReporteAcumuladosLista FicVmReporteAcumuladosLista { get { return FicIContainer.Resolve<FicVmReporteAcumuladosLista>(); } }

        
    }//CLASS
}//NAMESPACE
