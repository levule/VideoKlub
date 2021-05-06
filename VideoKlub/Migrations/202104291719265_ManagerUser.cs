namespace VideoKlub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManagerUser : DbMigration
    {
        public override void Up()
        {
            Sql(
                @"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'faee26ef-9ce1-4e69-939e-3d2e9d666732', N'admin@videoklub.com', 0, N'AIP/9ZfQD3us1A84Tn2TRMJFxFoN5cHIF6fl5qGuG06VH51ZmSg96JeKAwMvp7xE7Q==', N'39294938-4ef4-42c5-a756-a6aca7c05055', NULL, 0, 0, NULL, 1, 0, N'admin@videoklub.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'08de365b-d170-4505-9706-e4bee1226f9a', N'MoviesManager')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'faee26ef-9ce1-4e69-939e-3d2e9d666732', N'08de365b-d170-4505-9706-e4bee1226f9a')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
