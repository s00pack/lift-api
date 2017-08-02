namespace LiftApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Users : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserGroups",
                c => new
                    {
                        UserGroupId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.UserGroupId);
            
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        UserInfoId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(),
                        AllowPublicDisplay = c.Boolean(nullable: false),
                        AllowGroupDisplay = c.Boolean(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserInfoId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.UserInfoUserGroups",
                c => new
                    {
                        UserInfo_UserInfoId = c.Int(nullable: false),
                        UserGroup_UserGroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserInfo_UserInfoId, t.UserGroup_UserGroupId })
                .ForeignKey("dbo.UserInfoes", t => t.UserInfo_UserInfoId, cascadeDelete: true)
                .ForeignKey("dbo.UserGroups", t => t.UserGroup_UserGroupId, cascadeDelete: true)
                .Index(t => t.UserInfo_UserInfoId)
                .Index(t => t.UserGroup_UserGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInfoUserGroups", "UserGroup_UserGroupId", "dbo.UserGroups");
            DropForeignKey("dbo.UserInfoUserGroups", "UserInfo_UserInfoId", "dbo.UserInfoes");
            DropForeignKey("dbo.UserInfoes", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.UserInfoUserGroups", new[] { "UserGroup_UserGroupId" });
            DropIndex("dbo.UserInfoUserGroups", new[] { "UserInfo_UserInfoId" });
            DropIndex("dbo.UserInfoes", new[] { "ApplicationUser_Id" });
            DropTable("dbo.UserInfoUserGroups");
            DropTable("dbo.UserInfoes");
            DropTable("dbo.UserGroups");
        }
    }
}
