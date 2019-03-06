namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUSers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6126e4c2-25d5-4733-8e6c-ede93bcda4a4', N'itsnouse132000@yahoo.com', 0, N'AOC1SBtn1o5E6YulOOOy6anDJlpFMEPEsTnNN/oz6mcJhlGrPxyfX/DtU9gYjqhAzw==', N'e901f161-de4e-4876-98ce-0dbd1a716ec9', NULL, 0, 0, NULL, 1, 0, N'itsnouse132000@yahoo.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a70498b0-12fe-4476-b56e-82db0301c7d2', N'nedelcu.tudor@yahoo.com', 0, N'AOMdogYfkz76cL8IoE7n7dIwtucA4PyhCTmjntp3RG+Bd90ahthJ6tNYC7N5J40yTA==', N'cb4e12b5-d275-4af8-b350-c1e479524e1e', NULL, 0, 0, NULL, 1, 0, N'nedelcu.tudor@yahoo.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'66752a80-b0cf-4d54-867a-f93f8e573f34', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6126e4c2-25d5-4733-8e6c-ede93bcda4a4', N'66752a80-b0cf-4d54-867a-f93f8e573f34')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
