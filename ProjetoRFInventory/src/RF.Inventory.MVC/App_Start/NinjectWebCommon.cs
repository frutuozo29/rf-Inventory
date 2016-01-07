[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(RF.Inventory.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(RF.Inventory.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace RF.Inventory.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Application.Interfaces;
    using Application;
    using Domain.Interfaces.Services;
    using Domain.Services;
    using Domain.Interfaces;
    using Data.Repositories;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IEmpresaAppService>().To<EmpresaAppService>();
            kernel.Bind<IGrupoProdutoAppService>().To<GrupoProdutoAppService>();
            kernel.Bind<IImportacaoAppService>().To<ImportacaoAppService>();
            kernel.Bind<ISituacaoDiefAppService>().To<SituacaoDiefAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IEmpresaService>().To<EmpresaService>();
            kernel.Bind<IGrupoProdutoService>().To<GrupoProdutoService>();
            kernel.Bind<IImportacaoService>().To<ImportacaoService>();
            kernel.Bind<ISituacaoDiefService>().To<SituacaoDiefService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IEmpresaRepository>().To<EmpresaRepository>();
            kernel.Bind<IGrupoProdutoRepository>().To<GrupoProdutoRepository>();
            kernel.Bind<IImportacaoRepository>().To<ImportacaoRepository>();
            kernel.Bind<ISituacaoDiefRepository>().To<SituacaoDiefRepository>();
        }        
    }
}
