namespace ITlab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedFriendModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FriendModels", "FriendModel_indeks", c => c.Int());
            CreateIndex("dbo.FriendModels", "FriendModel_indeks");
            AddForeignKey("dbo.FriendModels", "FriendModel_indeks", "dbo.FriendModels", "indeks");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FriendModels", "FriendModel_indeks", "dbo.FriendModels");
            DropIndex("dbo.FriendModels", new[] { "FriendModel_indeks" });
            DropColumn("dbo.FriendModels", "FriendModel_indeks");
        }
    }
}
