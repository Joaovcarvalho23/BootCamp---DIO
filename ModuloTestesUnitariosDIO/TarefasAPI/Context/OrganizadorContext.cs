﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}