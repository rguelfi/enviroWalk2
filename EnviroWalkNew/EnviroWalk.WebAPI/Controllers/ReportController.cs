using EnviroWalk.Model.View;
using EnviroWalk.Repository.Interface;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Linq;
using CsvHelper;
using System.IO;
using Amazon.S3;
using Amazon.S3.Transfer;
using Amazon.S3.Model;
using System.Text;

namespace EnviroWalk.WebAPI.Controllers
{
    public class ReportController : ApiController
    {

        static string existingBucketName = "envirowalk";
        static string keyName;
        static string urlReport;

        const string accessKeyId = "";
        const string secretAccessKey = "";


        static String FROM = "rguelfi@gmail.com";
        static String TO = "rguelfi@gmail.com,romulorochabr@hotmail.com,vict.azevedo@gmail.com";
        static String SUBJECT = "Enviro Walk - Report";
        const String SMTP_USERNAME = "";  
        const String SMTP_PASSWORD = "";  
        const String HOST = "email-smtp.us-west-2.amazonaws.com";
        const int PORT = 587;



        public ReportView Get(int id)
        {
            //report controller
            IReport repoReport = RepositoryFactory.GetRepository<IReport>();

            var report = repoReport.GetLastReport(id);

            return report;

        }

        public HttpResponseMessage Post([FromBody]ReportView reportView)
        {
            try
            {
                IReport orderRepository = RepositoryFactory.GetRepository<IReport>();
                orderRepository.AddReport(reportView);
                var reportExportView = orderRepository.GetReportExport(reportView.userID);

                using (var memoryStream = new MemoryStream())
                {

                    using (TextWriter sw = new StreamWriter(memoryStream, Encoding.UTF8))
                    using (var csvWriter = new CsvWriter(sw))
                    {
                        csvWriter.WriteHeader<ExportFileTemplate>();

                        foreach (var question in reportExportView.Questions)
                        {

                            bool answerQuestion = reportExportView.Report.AnswerQuestions.Any(aq => aq.Question_Id == question.Id);

                            foreach (var qa in reportExportView.QuestionActions)
                            {

                                csvWriter.WriteField(reportExportView.Report.UserID);
                                csvWriter.WriteField(reportExportView.Report.FarmName);
                                csvWriter.WriteField(reportExportView.Report.Date);

                                csvWriter.WriteField(question.Category.Description);

                                csvWriter.WriteField(question.Description);
                                csvWriter.WriteField(answerQuestion);
                                csvWriter.WriteField(qa.Description);

                                var answerAction = reportExportView.Report.AnswerQuestions
                                    .SelectMany(aq => aq.AnswerActions)
                                    .Any(aa => aa.QuestionAction_Id == qa.Id);
                                csvWriter.WriteField(answerAction.ToString());

                                csvWriter.NextRecord();

                            }

                            foreach (var customAction in reportExportView.Report.CustomActions)
                            {
                                csvWriter.WriteField(reportExportView.Report.UserID);
                                csvWriter.WriteField(reportExportView.Report.FarmName);
                                csvWriter.WriteField(reportExportView.Report.Date);

                                csvWriter.WriteField(question.Category.Description);

                                csvWriter.WriteField(question.Description);
                                csvWriter.WriteField(answerQuestion);

                                csvWriter.WriteField(customAction.Description);
                                csvWriter.WriteField(customAction.Answer);
                                csvWriter.NextRecord();
                            }

                        }

                        sw.Flush();
                        //memoryStream.Seek(0, SeekOrigin.Begin);
                        using (var client = new AmazonS3Client(accessKeyId,secretAccessKey, Amazon.RegionEndpoint.APSoutheast2))
                        {

                            keyName = reportExportView.Report.UserID.ToString() + "report.csv";

                            PutObjectRequest putRequest = new PutObjectRequest
                            {
                                BucketName = existingBucketName,
                                Key = keyName,
                                ContentType = "application/text",
                                InputStream = memoryStream
                            };
                            //putRequest.Metadata.Add("x-amz-meta-title", "someTitle");
                            PutObjectResponse response = client.PutObject(putRequest);

                            GetPreSignedUrlRequest request = new GetPreSignedUrlRequest();
                            request.BucketName = existingBucketName;
                            request.Key = keyName;
                            request.Expires = DateTime.Now.AddDays(10);
                            request.Protocol = Protocol.HTTP;
                            urlReport = client.GetPreSignedURL(request);

                        }

                    }

                }


                using (System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient(HOST, PORT))
                {
                    client.Credentials = new System.Net.NetworkCredential(SMTP_USERNAME, SMTP_PASSWORD);
                    client.EnableSsl = true;

                    try
                    {
                        client.Send(FROM,TO, SUBJECT, urlReport);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }


                return Request.CreateResponse(HttpStatusCode.Created, reportView.userID);

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }

    }

    public sealed class ExportFileTemplate
    {
        public string User { get; set; }
        public string Farm { get; set; }
        public string Date { get; set; }
        public string Category { get; set; }
        public string Question { get; set; }
        public string Answer_Question { get; set; }
        public string Action { get; set; }
        public string Answer_Action { get; set; }
    }


}