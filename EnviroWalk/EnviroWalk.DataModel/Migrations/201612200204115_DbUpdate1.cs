namespace EnviroWalk.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbUpdate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RepQuestionModels", "Report_ID", "dbo.ReportModels");
            DropForeignKey("dbo.RepQuestionActionModels", "Report_ID", "dbo.ReportModels");
            DropForeignKey("dbo.RepQuestionCusActionModels", "Report_ID", "dbo.ReportModels");
            DropIndex("dbo.RepQuestionModels", new[] { "Report_ID" });
            DropIndex("dbo.RepQuestionActionModels", new[] { "Report_ID" });
            DropIndex("dbo.RepQuestionCusActionModels", new[] { "Report_ID" });
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
            
            DropTable("dbo.ReportModels");
            DropTable("dbo.RepQuestionModels");
            DropTable("dbo.RepQuestionActionModels");
            DropTable("dbo.RepQuestionCusActionModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RepQuestionCusActionModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        QuestionID = c.Int(nullable: false),
                        RepQuestionCusActionAns = c.Boolean(nullable: false),
                        RepQuestionCusActionDate = c.DateTime(nullable: false),
                        RepQuestionAnswer = c.Boolean(nullable: false),
                        RepQuestionCusActionDescription = c.String(),
                        RepQuestionCusActionOrder = c.Int(nullable: false),
                        Report_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RepQuestionActionModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        QuestionActionID = c.Int(nullable: false),
                        RepQuestionActionAns = c.Boolean(nullable: false),
                        RepQuestionActionDate = c.DateTime(nullable: false),
                        Report_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RepQuestionModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        QuestionID = c.Int(nullable: false),
                        RepQuestionAnswer = c.Boolean(nullable: false),
                        Report_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ReportModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ReportFarmName = c.String(),
                        ReportDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
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
            DropTable("dbo.Reports");
            DropTable("dbo.RepQuestionActions");
            DropTable("dbo.QuestionActions");
            DropTable("dbo.Questions");
            DropTable("dbo.Categories");
            CreateIndex("dbo.RepQuestionCusActionModels", "Report_ID");
            CreateIndex("dbo.RepQuestionActionModels", "Report_ID");
            CreateIndex("dbo.RepQuestionModels", "Report_ID");
            AddForeignKey("dbo.RepQuestionCusActionModels", "Report_ID", "dbo.ReportModels", "ID");
            AddForeignKey("dbo.RepQuestionActionModels", "Report_ID", "dbo.ReportModels", "ID");
            AddForeignKey("dbo.RepQuestionModels", "Report_ID", "dbo.ReportModels", "ID");
        }
    }
}
