using System;
using API.Entities;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
   public DbSet<AppUser> Users{get; set;}

}
