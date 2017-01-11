namespace EnviroWalk.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.QuestionActions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Sequence = c.Int(nullable: false),
                        Question_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.Question_Id)
                .Index(t => t.Question_Id);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        FarmName = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AnswerQuestions",
                c => new
                    {
                        Question_Id = c.Int(nullable: false),
                        Report_Id = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.Question_Id, t.Report_Id })
                .ForeignKey("dbo.Questions", t => t.Question_Id, cascadeDelete: true)
                .ForeignKey("dbo.Reports", t => t.Report_Id, cascadeDelete: true)
                .Index(t => t.Question_Id)
                .Index(t => t.Report_Id);
            
            CreateTable(
                "dbo.AnswerActions",
                c => new
                    {
                        QuestionAction_Id = c.Int(nullable: false),
                        Question_Id = c.Int(nullable: false),
                        Report_Id = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.QuestionAction_Id, t.Question_Id, t.Report_Id })
                .ForeignKey("dbo.AnswerQuestions", t => new { t.Question_Id, t.Report_Id }, cascadeDelete: true)
                .ForeignKey("dbo.QuestionActions", t => t.QuestionAction_Id, cascadeDelete: true)
                .Index(t => t.QuestionAction_Id)
                .Index(t => new { t.Question_Id, t.Report_Id });
            
            CreateTable(
                "dbo.CustomActions",
                c => new
                    {
                        CustomAction_Id = c.Int(nullable: false, identity: true),
                        Report_Id = c.Int(nullable: false),
                        Question_Id = c.Int(nullable: false),
                        Client_Id = c.Int(nullable: false),
                        Description = c.String(),
                        Answer = c.Boolean(nullable: false),
                        Sequence = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CustomAction_Id)
                .ForeignKey("dbo.Questions", t => t.Question_Id, cascadeDelete: true)
                .ForeignKey("dbo.Reports", t => t.Report_Id, cascadeDelete: true)
                .Index(t => t.Report_Id)
                .Index(t => t.Question_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomActions", "Report_Id", "dbo.Reports");
            DropForeignKey("dbo.CustomActions", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.AnswerQuestions", "Report_Id", "dbo.Reports");
            DropForeignKey("dbo.AnswerQuestions", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.AnswerActions", "QuestionAction_Id", "dbo.QuestionActions");
            DropForeignKey("dbo.AnswerActions", new[] { "Question_Id", "Report_Id" }, "dbo.AnswerQuestions");
            DropForeignKey("dbo.QuestionActions", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.Questions", "Category_Id", "dbo.Categories");
            DropIndex("dbo.CustomActions", new[] { "Question_Id" });
            DropIndex("dbo.CustomActions", new[] { "Report_Id" });
            DropIndex("dbo.AnswerActions", new[] { "Question_Id", "Report_Id" });
            DropIndex("dbo.AnswerActions", new[] { "QuestionAction_Id" });
            DropIndex("dbo.AnswerQuestions", new[] { "Report_Id" });
            DropIndex("dbo.AnswerQuestions", new[] { "Question_Id" });
            DropIndex("dbo.QuestionActions", new[] { "Question_Id" });
            DropIndex("dbo.Questions", new[] { "Category_Id" });
            DropTable("dbo.CustomActions");
            DropTable("dbo.AnswerActions");
            DropTable("dbo.AnswerQuestions");
            DropTable("dbo.Reports");
            DropTable("dbo.QuestionActions");
            DropTable("dbo.Questions");
            DropTable("dbo.Categories");
        }
    }
}
