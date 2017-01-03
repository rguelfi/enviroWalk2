namespace EnviroWalk.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryDescription = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionID = c.Int(nullable: false, identity: true),
                        QuestionDescription = c.String(),
                        Category_CategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.QuestionID)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryID)
                .Index(t => t.Category_CategoryID);
            
            CreateTable(
                "dbo.QuestionActions",
                c => new
                    {
                        QuestionActionID = c.Int(nullable: false, identity: true),
                        QuestionActionDescription = c.String(),
                        QuestionActionOrder = c.Int(nullable: false),
                        Question_QuestionID = c.Int(),
                    })
                .PrimaryKey(t => t.QuestionActionID)
                .ForeignKey("dbo.Questions", t => t.Question_QuestionID)
                .Index(t => t.Question_QuestionID);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        ReportID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ReportFarmName = c.String(),
                        ReportDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReportID);
            
            CreateTable(
                "dbo.RepQuestionActions",
                c => new
                    {
                        RepQuestionActionID = c.Int(nullable: false, identity: true),
                        RepQuestionActionAns = c.Boolean(nullable: false),
                        RepQuestionActionDate = c.DateTime(nullable: false),
                        QuestionAction_QuestionActionID = c.Int(),
                        Report_ReportID = c.Int(),
                    })
                .PrimaryKey(t => t.RepQuestionActionID)
                .ForeignKey("dbo.QuestionActions", t => t.QuestionAction_QuestionActionID)
                .ForeignKey("dbo.Reports", t => t.Report_ReportID)
                .Index(t => t.QuestionAction_QuestionActionID)
                .Index(t => t.Report_ReportID);
            
            CreateTable(
                "dbo.RepQuestionCusActions",
                c => new
                    {
                        RepQuestionCusActionID = c.Int(nullable: false, identity: true),
                        RepQuestionCusActionAns = c.Boolean(nullable: false),
                        RepQuestionCusActionDate = c.DateTime(nullable: false),
                        RepQuestionCusActionDescription = c.String(),
                        RepQuestionCusActionOrder = c.Int(nullable: false),
                        Question_QuestionID = c.Int(),
                        Report_ReportID = c.Int(),
                    })
                .PrimaryKey(t => t.RepQuestionCusActionID)
                .ForeignKey("dbo.Questions", t => t.Question_QuestionID)
                .ForeignKey("dbo.Reports", t => t.Report_ReportID)
                .Index(t => t.Question_QuestionID)
                .Index(t => t.Report_ReportID);
            
            CreateTable(
                "dbo.RepQuestions",
                c => new
                    {
                        RepQuestionID = c.Int(nullable: false, identity: true),
                        RepQuestionAnswer = c.Boolean(nullable: false),
                        Question_QuestionID = c.Int(),
                        Report_ReportID = c.Int(),
                    })
                .PrimaryKey(t => t.RepQuestionID)
                .ForeignKey("dbo.Questions", t => t.Question_QuestionID)
                .ForeignKey("dbo.Reports", t => t.Report_ReportID)
                .Index(t => t.Question_QuestionID)
                .Index(t => t.Report_ReportID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RepQuestions", "Report_ReportID", "dbo.Reports");
            DropForeignKey("dbo.RepQuestions", "Question_QuestionID", "dbo.Questions");
            DropForeignKey("dbo.RepQuestionCusActions", "Report_ReportID", "dbo.Reports");
            DropForeignKey("dbo.RepQuestionCusActions", "Question_QuestionID", "dbo.Questions");
            DropForeignKey("dbo.RepQuestionActions", "Report_ReportID", "dbo.Reports");
            DropForeignKey("dbo.RepQuestionActions", "QuestionAction_QuestionActionID", "dbo.QuestionActions");
            DropForeignKey("dbo.QuestionActions", "Question_QuestionID", "dbo.Questions");
            DropForeignKey("dbo.Questions", "Category_CategoryID", "dbo.Categories");
            DropIndex("dbo.RepQuestions", new[] { "Report_ReportID" });
            DropIndex("dbo.RepQuestions", new[] { "Question_QuestionID" });
            DropIndex("dbo.RepQuestionCusActions", new[] { "Report_ReportID" });
            DropIndex("dbo.RepQuestionCusActions", new[] { "Question_QuestionID" });
            DropIndex("dbo.RepQuestionActions", new[] { "Report_ReportID" });
            DropIndex("dbo.RepQuestionActions", new[] { "QuestionAction_QuestionActionID" });
            DropIndex("dbo.QuestionActions", new[] { "Question_QuestionID" });
            DropIndex("dbo.Questions", new[] { "Category_CategoryID" });
            DropTable("dbo.RepQuestions");
            DropTable("dbo.RepQuestionCusActions");
            DropTable("dbo.RepQuestionActions");
            DropTable("dbo.Reports");
            DropTable("dbo.QuestionActions");
            DropTable("dbo.Questions");
            DropTable("dbo.Categories");
        }
    }
}
