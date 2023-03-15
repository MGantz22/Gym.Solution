using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace Gym.Models;

public class GymContext : DbContext
{
  public DbSet<Class> Classes { get; set; }
  public DbSet<Location> Locations { get; set; }
  public DbSet<Member> Members { get; set; }
  public DbSet<ClassMember> ClassMembers { get; set; }
  

  public GymContext(DbContextOptions options) : base(options) { }
}

