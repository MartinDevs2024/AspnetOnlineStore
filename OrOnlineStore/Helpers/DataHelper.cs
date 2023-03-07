using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrOnlineStore.DataAccess.Data;
using System;
using System.Threading.Tasks;

namespace OrOnlineStore.Helpers
{
    public static class DataHelper
    {
        public static async Task ManageDataAsync(IServiceProvider svcProvider)
        {
            //Service: An instance of db context
            var dbContextSvc = svcProvider.GetRequiredService<ApplicationDbContext>();

            //Migration: This is the programmatic equivalent to Update-Database
            await dbContextSvc.Database.MigrateAsync();
        }
    }
}
