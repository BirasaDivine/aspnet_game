using System.Dynamic;
using aspnet_gameapi.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnet_gameapi.Data;


public class GameStoreContext (DbContextOptions<GameStoreContext> options): DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();
    public DbSet<Genre> Genres => Set<Genre>();
}
