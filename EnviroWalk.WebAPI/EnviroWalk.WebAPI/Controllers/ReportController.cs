using EnviroWalk.Model;
using EnviroWalk.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace EnviroWalk.WebAPI.Controllers
{
    public class ReportController : ApiController
    {
        // GET: Report
        public ReportModel Get(int id)
        {
            //report controller
            var teste = 0;
            IReport report = RepositoryFactory.GetRepository<IReport>();
            return report.GetLastReport(id);
            
        }
    }
    }