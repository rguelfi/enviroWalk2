namespace EnviroWalk.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Report",
                c => new
                    {
                        ReportID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ReportFarmName = c.String(),
                        ReportDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReportID);

            CreateTable(
                "dbo.Category",
                c => new
                {
                    CategoryID = c.Int(nullable: false, identity: true),
                    ReportFarmName = c.String(),
                })
                .PrimaryKey(t => t.CategoryID);

            CreateTable(
                "dbo.Question",
                c => new
                {
                    QuestionID = c.Int(nullable: false, identity: true),
                    QuestionDescription = c.String(),
                    Category_ID = c.Int(),
                })
                .PrimaryKey(t => t.QuestionID)
                .ForeignKey("dbo.Category", t => t.Category_ID)
                .Index(t => t.Category_ID);

            CreateTable(
                "dbo.QuestionAction",
                c => new
                {
                    QuestionActionID = c.Int(nullable: false, identity: true),
                    QuestionActionDescription = c.String(),
                    QuestionActionOrder = c.Int(nullable: false),
                    Question_ID = c.Int(),
                })
                .PrimaryKey(t => t.QuestionActionID)
                .ForeignKey("dbo.Question", t => t.Question_ID)
                .Index(t => t.Question_ID);

            CreateTable(
                "dbo.RepQuestion",
                c => new
                    {
                        RepQuestionID = c.Int(nullable: false, identity: true),
                        RepQuestionAnswer = c.Boolean(nullable: false),
                        Question_ID = c.Int(),
                        Report_ID = c.Int(),
                    })
                .PrimaryKey(t => t.RepQuestionID)
                .ForeignKey("dbo.Report", t => t.Report_ID)
                .ForeignKey("dbo.Question", t => t.Question_ID)
                .Index(t => t.Report_ID)
                .Index(t => t.Question_ID);
            
            CreateTable(
                "dbo.RepQuestionAction",
                c => new
                    {
                        RepQuestionActionID = c.Int(nullable: false, identity: true),
                        RepQuestionActionAns = c.Boolean(nullable: false),
                        RepQuestionActionDate = c.DateTime(nullable: false),
                        Report_ID = c.Int(),
                        QuestionAction_ID = c.Int(),
                    })
                .PrimaryKey(t => t.RepQuestionActionID)
                .ForeignKey("dbo.Report", t => t.Report_ID)
                .ForeignKey("dbo.QuestionAction", t => t.QuestionAction_ID)
                .Index(t => t.Report_ID)
                .Index(t => t.QuestionAction_ID);
            
            CreateTable(
                "dbo.RepQuestionCusAction",
                c => new
                    {
                        RepQuestionCusActionID = c.Int(nullable: false, identity: true),
                        RepQuestionCusActionAns = c.Boolean(nullable: false),
                        RepQuestionCusActionDate = c.DateTime(nullable: false),
                        RepQuestionCusActionDescription = c.String(),
                        RepQuestionCusActionOrder = c.Int(nullable: false),
                        Report_ID = c.Int(),
                        Question_ID = c.Int(),
                    })
                .PrimaryKey(t => t.RepQuestionCusActionID)
                .ForeignKey("dbo.Report", t => t.Report_ID)
                .ForeignKey("dbo.Question", t => t.Question_ID)
                .Index(t => t.Report_ID)
                .Index(t => t.Question_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RepQuestionCusActionModels", "Report_ID", "dbo.ReportModels");
            DropForeignKey("dbo.RepQuestionActionModels", "Report_ID", "dbo.ReportModels");
            DropForeignKey("dbo.RepQuestionModels", "Report_ID", "dbo.ReportModels");
            DropIndex("dbo.RepQuestionCusActionModels", new[] { "Report_ID" });
            DropIndex("dbo.RepQuestionActionModels", new[] { "Report_ID" });
            DropIndex("dbo.RepQuestionModels", new[] { "Report_ID" });
            DropTable("dbo.RepQuestionCusActionModels");
            DropTable("dbo.RepQuestionActionModels");
            DropTable("dbo.RepQuestionModels");
            DropTable("dbo.ReportModels");

            DropForeignKey("dbo.RepQuestionCusAction", "Report_ID", "dbo.Report");
            DropForeignKey("dbo.RepQuestionCusAction", "Question_ID", "dbo.Question");
            DropForeignKey("dbo.RepQuestionAction", "Report_ID", "dbo.Report");
            DropForeignKey("dbo.RepQuestionAction", "QuestionAction_ID", "dbo.QuestionAction");
            DropForeignKey("dbo.RepQuestion", "Report_ID", "dbo.Report");
            DropForeignKey("dbo.RepQuestion", "Question_ID", "dbo.Question");
            DropForeignKey("dbo.QuestionAction", "Question_ID", "dbo.Question");
            DropForeignKey("dbo.Question", "Category_ID", "dbo.Category");

            DropIndex("dbo.RepQuestionCusAction", new[] { "Report_ID" });
            DropIndex("dbo.RepQuestionCusAction", new[] { "Question_ID" });
            DropIndex("dbo.RepQuestionAction", new[] { "Report_ID" });
            DropIndex("dbo.RepQuestionAction", new[] { "QuestionAction_ID" });
            DropIndex("dbo.RepQuestion", new[] { "Report_ID" });
            DropIndex("dbo.RepQuestion", new[] { "Question_ID" });
            DropIndex("dbo.QuestionAction", new[] { "Question_ID" });
            DropIndex("dbo.Question", new[] { "Category_ID" });

            DropTable("dbo.RepQuestionCusAction");
            DropTable("dbo.RepQuestionAction");
            DropTable("dbo.RepQuestion");
            DropTable("dbo.Report");
            DropTable("dbo.Question");
            DropTable("dbo.QuestionAction");
            DropTable("dbo.Category");
        }
    }
}
