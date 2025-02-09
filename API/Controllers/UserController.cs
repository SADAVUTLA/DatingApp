using System;
using System.Net;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]

public class UserController(DataContext context) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetUser()
    {
        var users = await context.Users.ToListAsync();

        if(users?.Count == 0)
            return StatusCode(404, new { message = "No data found"});

        return Ok(users);
    }

   [HttpGet("{id}")]
   public async Task<IActionResult> GetUser(int Id)
    {
        var user = await context.Users.FindAsync(Id);

        if(user == null)
        return StatusCode(404, new {message = $@"No Data found {Id}"});

        return Ok(user);
    }    
}
