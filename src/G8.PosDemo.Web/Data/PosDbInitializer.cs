using Microsoft.EntityFrameworkCore;

namespace G8.PosDemo.Web.Data;

public static class PosDbInitializer
{
    public static async Task InitializeAsync(IServiceProvider services)
    {
        using var scope = services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<PosDbContext>();
        await db.Database.MigrateAsync();
    }
}
