using System;
using System.Web.Mvc;
using System.Web.Routing;
using MTLibrary.MTInterface;
using MTLibrary.MTRepository;
using Ninject;

namespace MTWeb.Ninject
{
    public class NinjectControllersFactory : DefaultControllerFactory
    {
        private IKernel _ninjectKernel;

        public NinjectControllersFactory()
        {
            _ninjectKernel = new StandardKernel();
            AdBinding();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_ninjectKernel.Get(controllerType);
        }

        private void AdBinding()
        {
            _ninjectKernel.Bind<IUser>().To<UserReposity>();
        }
    }
}