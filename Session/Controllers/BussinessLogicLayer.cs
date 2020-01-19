using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Session.Controllers
{
    public class BussinessLogicLayer
    {
        private readonly DataAccessLayer _dataAccessLayer;

        public BussinessLogicLayer(DataAccessLayer dataAccessLayer)
        {
            _dataAccessLayer = dataAccessLayer;
        }
        public DataSet PageLoad()
        {
            return _dataAccessLayer.PageLoad();
        }
        public string PageLoadOne()
        {
            return _dataAccessLayer.PageLoadOne();
        }
    }
}
