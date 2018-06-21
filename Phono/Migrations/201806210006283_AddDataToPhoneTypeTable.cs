namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToPhoneTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [PhoneTypes] ([Type], [OS]) VALUES ('Smart', 'Android')");
            Sql("INSERT INTO [PhoneTypes] ([Type], [OS]) VALUES ('Smart', 'IOS')");
            Sql("INSERT INTO [PhoneTypes] ([Type], [OS]) VALUES ('Bar', 'NA(not available)')");
            Sql("INSERT INTO [PhoneTypes] ([Type], [OS]) VALUES ('Flip', 'NA(not availabel)')");
        }
        
        public override void Down()
        {
        }
    }
}
