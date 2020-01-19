using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Session.Controllers
{
    public class BAL
    {
        public static DataSet PageLoad()
        {
            return DAL.PageLoad();
        }
    }
}
