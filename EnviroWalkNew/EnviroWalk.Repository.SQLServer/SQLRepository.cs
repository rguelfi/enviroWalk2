using EnviroWalk.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using EnviroWalk.Model;
using EnviroWalk.DataModel;
using System.Data.Entity;
using EnviroWalk.Model.View;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace EnviroWalk.Repository.SQLServer
{
    public partial class SQLRepository : IReport
    {

        public void AddReport(ReportView reportView)
        {
            using (var context = new ContextEnv())
            {
                var report = Mapper.Map<ReportView, Report>(reportView);
                report.Date = DateTime.Now;

                foreach (var answerQuestion in report.AnswerQuestions)
                {
                    answerQuestion.Date = DateTime.Now;

                    foreach (var answerAction in answerQuestion.AnswerActions)
                    {
                        answerAction.Question_Id = answerQuestion.Question_Id;
                        answerAction.Date = DateTime.Now;
                    }
                }

                foreach (var customAction in report.CustomActions)
                {
                    customAction.Date = DateTime.Now;
                }

                context.Report.Add(report);
                context.SaveChanges();

            }
        }

        private void Ignore(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        public void DeleteReport(Report report)
        {
            throw new NotImplementedException();
        }

        public Report EmailReport(int UserID, string safeEmail)
        {
            throw new NotImplementedException();
        }

        public ReportView GetLastReport(int UserID)
        {
            using (var context = new ContextEnv())
            {
                var report = context.Report
                    .Include(r => r.AnswerQuestions)
                    .Include(r => r.AnswerQuestions.Select(aq => aq.AnswerActions))
                    .Include(r => r.CustomActions)
                    .Where(r => r.UserID == UserID)
                    .OrderByDescending(r => r.Id)
                    .ProjectTo<ReportView>()
                    .FirstOrDefault();

                return report;
            }
        }

        public ReportExportView GetReportExport(int UserID)
        {
            using (var context = new ContextEnv())
            {
                var categories = context.Category.ToList();
                var questions = context.Question.ToList();
                var questionActions = context.QuestionAction.ToList();
                var report = context.Report
                .Include(r => r.AnswerQuestions)
                .Include(r => r.AnswerQuestions.Select(aq => aq.AnswerActions))
                .Include(r => r.CustomActions)
                .Where(r => r.UserID == UserID)
                .OrderByDescending(r => r.Id)
                .FirstOrDefault();

                var reportExportView = new ReportExportView();
                reportExportView.Categories = categories;
                reportExportView.Questions = questions;
                reportExportView.QuestionActions = questionActions;
                reportExportView.Report = report;

                return reportExportView;
            }
        }


        public Report GetReport(int ID)
        {
            throw new NotImplementedException();
        }

        public Report SaveReport(Report report)
        {
            throw new NotImplementedException();
        }

        public void UpdateReport(Report report)
        {
            throw new NotImplementedException();
        }

        public void UpdateReports(IEnumerable<Report> reports)
        {
            throw new NotImplementedException();
        }

    }
}
