namespace MovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'124b59d0-ece0-4d8c-8905-1bffdd3d7b19', N'admin@movieapp.com', 0, N'ADkxMXB2JkxM3niqVcEpyZrGce16YHi5RqPPWM8wTcedOyuDjARzznDu+A3BhDUkyg==', N'df904ec3-9f48-417e-8346-98a3f8022d96', NULL, 0, 0, NULL, 1, 0, N'admin@movieapp.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'19a01f0b-6551-4ba1-b78e-33419785402a', N'member@movieapp.com', 0, N'ADuQymf65HZle3Zb88KiJorrFd5kEI7k1GlD7Zapt6shKiFYignIF49CUvTX6cqXOA==', N'f4f2f41d-fe73-4d3c-9449-7dd8bb088c6d', NULL, 0, 0, NULL, 1, 0, N'member@movieapp.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c697861b-aed6-495d-ac71-ac9bcb2b7435', N'guest@movieapp.com', 0, N'ACEf76zBNuKCbH66MpKX1QyPNcRnyLn9dpg6a/UuY4okOkgCib6ClwUa5W+jf+VNqQ==', N'646be20c-8168-40d7-b105-50f54e025aa0', NULL, 0, 0, NULL, 1, 0, N'guest@movieapp.com')

                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'20b39eb0-5dd4-4dbe-a2d9-dd261e0f49d9', N'CanManageMovies')

                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'19a01f0b-6551-4ba1-b78e-33419785402a', N'20b39eb0-5dd4-4dbe-a2d9-dd261e0f49d9')
            ");

        }
        
        public override void Down()
        {
        }
    }
}
