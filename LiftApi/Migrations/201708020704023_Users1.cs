namespace LiftApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Users1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserInfoes", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.UserInfoes", new[] { "ApplicationUser_Id" });
            AddColumn("dbo.UserInfoes", "ApplicationUserId", c => c.Int(nullable: false));
            DropColumn("dbo.UserInfoes", "ApplicationUser_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserInfoes", "ApplicationUser_Id", c => c.String(maxLength: 128));
            DropColumn("dbo.UserInfoes", "ApplicationUserId");
            CreateIndex("dbo.UserInfoes", "ApplicationUser_Id");
            AddForeignKey("dbo.UserInfoes", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
