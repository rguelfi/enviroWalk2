using EnviroWalk.Model;
using System.Data.Entity;


namespace EnviroWalk.DataModel
{
    public class ContextEnv: DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionAction> QuestionAction { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<AnswerQuestion> RepQuestion { get; set; }
        public DbSet<AnswerAction> RepQuestionAction { get; set; }
        public DbSet<CustomAction> RepQuestionCusAction { get; set; }

        public ContextEnv ()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ContextEnviro, Configuration>());
            //this.Configuration.LazyLoadingEnabled = true;
        }
    }
}
