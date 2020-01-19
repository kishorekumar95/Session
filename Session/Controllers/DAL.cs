using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Session.Controllers
{
    public class DAL : IDAL
    {

        private IMyComponent _myComponent = null;
        private static IHttpContextAccessor _contextAccessor;

        public DAL(IMyComponent myComponent, IHttpContextAccessor contextAccessor)
        {
            _myComponent = myComponent;
            _contextAccessor = contextAccessor;

        }
        public static DataSet PageLoad()
        {
            DataSet ret = new DataSet();
            //IUnityContainer container = new UnityContainer();
            //container.RegisterType<IMyComponent, MyComponent>();
            //container.RegisterType<DAL>(new InjectionConstructor(container.Resolve<IMyComponent>()));
            //container.RegisterType<DAL>(new InjectionConstructor(new object[] { new MyComponent(), _contextAccessor }));


            //container.RegisterType<IMyComponent, MyComponent>();// Map ICar with BMW 

            //var drv = container.Resolve<DAL>(_contextAccessor); //(new InjectionConstructor(new MyComponent()));
            //drv.run();
            return ret;
        }

        public void run()
        {
            _myComponent.SetSessionVariable();
        }
    }
}
