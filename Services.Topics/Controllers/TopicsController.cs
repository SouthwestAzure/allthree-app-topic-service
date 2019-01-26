using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Services.Topics.Models;

namespace Services.Topics.Controllers {

    [ApiController]
    public class TopicsController : ControllerBase {

        private readonly DataContext Context;

        public TopicsController(DataContext context) {

            this.Context = context;
        }

        [HttpGet("api/technologies")]
        public async Task<ActionResult<IEnumerable<string>>> GetAllTechnologiesAsync() {

            var values = await this.Context.Technologies.ToListAsync();
            return values.Select(x => x.Value).ToList();
            //return values;
        }

        [HttpGet("api/categories")]
        public async Task<ActionResult<IEnumerable<string>>> GetAllCategiesAsync() {

            var values = await this.Context.Categories.ToListAsync();
            return values.Select(x => x.Value).ToList();
            //return values;
        }
    }
}
