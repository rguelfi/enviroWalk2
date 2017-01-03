using EnviroWalk.Model;
using EnviroWalk.Repository.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace EnviroWalk.WebAPI.Controllers
{
    public class ReportController : ApiController
    {
        // GET Report Default
        //Ex: localhost/api/Report/1
        public ReportShort Get(int id)
        {
            //report controller
            IReport report = RepositoryFactory.GetRepository<IReport>();
            //var reportJson = report.GetLastReport(id);
            //var reportString = reportJson.ToString();
            //var retorno = JsonConvert.SerializeObject(reportJson);
            return report.GetLastReport(id);

        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("datahora")]
        public HttpResponseMessage GetDataHoraServidor()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("report/create")]
        public HttpResponseMessage CreateDB()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, RepositoryFactory.GetRepository<IReport>().createDB());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("report/getlast/{id:int}")]
        public HttpResponseMessage GetLastReport(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, RepositoryFactory.GetRepository<IReport>().GetLastReport(id));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("report/save")]
        public HttpResponseMessage SaveReport(Report report)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, RepositoryFactory.GetRepository<IReport>().SaveReport(report));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("report/email")]
        public HttpResponseMessage EmailReport(UserTemp user)
        {
            try
            {
                /* 30/12 no final nadad disso era necessario */
                //var retortSerial = JsonConvert.SerializeObject(report, Formatting.Indented, new JsonSerializerSettings
                //    {
                //        ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                //        PreserveReferencesHandling = PreserveReferencesHandling.Objects
                //    });
                //var response = JsonConvert.DeserializeObject<Report>(retortSerial);
                //return Request.CreateResponse(HttpStatusCode.OK, response);
                return Request.CreateResponse(HttpStatusCode.OK, RepositoryFactory.GetRepository<IReport>().EmailReport(user.UserID, user.UserEmail));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        public class UserTemp
        {
            public int UserID { get; set; }
            public string UserEmail { get; set; }
        }

        public class ReturnMsg
        {
            public int Code { get; set; }
            public string Message { get; set; }
        }
    }
}