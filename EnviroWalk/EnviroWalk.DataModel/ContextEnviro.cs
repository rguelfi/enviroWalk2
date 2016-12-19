using EnviroWalk.Model;
using System.Data.Entity;


namespace EnviroWalk.DataModel
{
    public class ContextEnviro: DbContext
    {
        public DbSet<ReportModel> Reports { get; set; }
        public DbSet<RepQuestionModel> RepQuestion { get; set; }
        public DbSet<RepQuestionActionModel> RepQuestionAction { get; set; }
        public DbSet<RepQuestionCusActionModel> RepQuestionCusAction { get; set; }

    }
}
