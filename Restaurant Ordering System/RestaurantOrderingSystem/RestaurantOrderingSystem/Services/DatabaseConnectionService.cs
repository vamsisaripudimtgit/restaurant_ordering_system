using Microsoft.EntityFrameworkCore;
using RestaurantOrderingSystem.Models;

namespace RestaurantOrderingSystem.Services
{
    public class DatabaseConnectionService { 
    private readonly ApplicationDbContext _context;

    public DatabaseConnectionService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> TestDatabaseConnection()
    {
        try
        {
            await _context.Database.OpenConnectionAsync();
            await _context.Database.CloseConnectionAsync();
            return true; // Connection successful
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Connection failed: {ex.Message}");
            return false; // Connection failed
        }
    }
    }
}
