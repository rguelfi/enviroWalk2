using EnviroWalk.DataModel.Migrations;
using EnviroWalk.Model;
using System.Data.Entity;


namespace EnviroWalk.DataModel
{
    public class ContextEnviro: DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionAction> QuestionAction { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<RepQuestion> RepQuestion { get; set; }
        public DbSet<RepQuestionAction> RepQuestionAction { get; set; }
        public DbSet<RepQuestionCusAction> RepQuestionCusAction { get; set; }

        public ContextEnviro ()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ContextEnviro, Configuration>());
        }
    }
}
