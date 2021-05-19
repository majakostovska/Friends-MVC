namespace ITlab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FriendModels",
                c => new
                    {
                        indeks = c.Int(nullable: false, identity: true),
                        id = c.Int(nullable: false),
                        ime = c.String(nullable: false),
                        mestonaziveenje = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.indeks);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FriendModels");
        }
    }
}
