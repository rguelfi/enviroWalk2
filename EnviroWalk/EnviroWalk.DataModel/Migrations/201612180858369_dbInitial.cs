namespace EnviroWalk.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbInitial : DbMigration
    {
        public override void Up()
        {
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
            
            CreateTable(
                "dbo.RepQuestionModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        QuestionID = c.Int(nullable: false),
                        RepQuestionAnswer = c.Boolean(nullable: false),
                        Report_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ReportModels", t => t.Report_ID)
                .Index(t => t.Report_ID);
            
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
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ReportModels", t => t.Report_ID)
                .Index(t => t.Report_ID);
            
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
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ReportModels", t => t.Report_ID)
                .Index(t => t.Report_ID);
            
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
        }
    }
}
