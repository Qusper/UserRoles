namespace UserRoles.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class initaddtableconnection : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.roles");
            DropPrimaryKey("dbo.users");
            AlterColumn("dbo.roles", "id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.users", "id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.users", "email", c => c.String(maxLength: 2147483647,
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "UniqueAttribute",
                        new AnnotationValues(oldValue: "SQLite.CodeFirst.UniqueAttribute", newValue: null)
                    },
                }));
            AddPrimaryKey("dbo.roles", "id");
            AddPrimaryKey("dbo.users", "id");
            CreateIndex("dbo.users", "role_id", name: "IX_users_role_id");
            AddForeignKey("dbo.users", "role_id", "dbo.roles", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.users", "role_id", "dbo.roles");
            DropIndex("dbo.users", "IX_users_role_id");
            DropPrimaryKey("dbo.users");
            DropPrimaryKey("dbo.roles");
            AlterColumn("dbo.users", "email", c => c.String(maxLength: 2147483647,
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "UniqueAttribute",
                        new AnnotationValues(oldValue: null, newValue: "SQLite.CodeFirst.UniqueAttribute")
                    },
                }));
            AlterColumn("dbo.users", "id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.roles", "id", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.users", "id");
            AddPrimaryKey("dbo.roles", "id");
        }
    }
}
