namespace JakubFaldaszLab4Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseName = c.String(nullable: false),
                        TeacherName = c.String(nullable: false),
                        CodeOfGroup = c.String(nullable: false),
                        Term = c.String(nullable: false),
                        ECTS = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mark = c.Single(nullable: false),
                        Date = c.DateTime(nullable: false),
                        CourseId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        BirthDate = c.DateTime(nullable: false),
                        Faculty = c.String(nullable: false, maxLength: 30),
                        FieldOfStudy = c.String(nullable: false, maxLength: 30),
                        Level = c.String(nullable: false),
                        StudentIDNumber = c.Int(nullable: false),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        From = c.String(nullable: false),
                        Subject = c.String(nullable: false),
                        MessageContent = c.String(),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Single(nullable: false),
                        Status = c.String(nullable: false),
                        PaymentDeadline = c.DateTime(nullable: false),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Messages", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Grades", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Grades", "CourseId", "dbo.Courses");
            DropIndex("dbo.Payments", new[] { "StudentId" });
            DropIndex("dbo.Messages", new[] { "StudentId" });
            DropIndex("dbo.Grades", new[] { "StudentId" });
            DropIndex("dbo.Grades", new[] { "CourseId" });
            DropTable("dbo.Payments");
            DropTable("dbo.Messages");
            DropTable("dbo.Students");
            DropTable("dbo.Grades");
            DropTable("dbo.Courses");
        }
    }
}
