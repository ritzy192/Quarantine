namespace Udemy_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'25955b5a-2a89-4c6f-a9f5-d9fd5f8af431', N'Guest@vidly.com', 0, N'AP3Ofo20SRMyimORjkMKDdT+OSjnD5lvifgcBicxiH9qP4HfSgE01HNepg8PeIABag==', N'0d1ee3a9-12d1-4721-bd7a-341dea7cf98e', NULL, 0, 0, NULL, 1, 0, N'Guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ed9b6a8d-be9d-4ef3-ba9b-0ee498b98250', N'Admin@vidly.com', 0, N'AITgucR7gLJSSuR9Wy1Ev4HtzbTmzIHHoIY5PClMgr1xY++u0u2iQphpLY0a7VWXSA==', N'ac1f3ef8-3c8c-4411-8029-e00f79c445b1', NULL, 0, 0, NULL, 1, 0, N'Admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3c4a7462-9493-4a93-a5d4-09dcf8f93dea', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ed9b6a8d-be9d-4ef3-ba9b-0ee498b98250', N'3c4a7462-9493-4a93-a5d4-09dcf8f93dea')
");
        }
        
        public override void Down()
        {
        }
    }
}
