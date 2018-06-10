using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers
{
    public class MakeController : Controller
    {
        public MakeController(VegaDbContext context)
        {
            this.context = context;
        }

        private readonly VegaDbContext context;

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await context.Makes.ToListAsync();
        }
    }
}