﻿using Microsoft.EntityFrameworkCore;

namespace Bma_home_login_menu.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
