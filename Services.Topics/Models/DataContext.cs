using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Newtonsoft.Json;

namespace Services.Topics.Models {

    public class DataContext : DbContext {

        public DataContext(DbContextOptions<DataContext> options) : base(options) {

            // Nothing to do here
        }

        //public DbSet<Topic> Topics { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Technology> Technologies { get; set; }
    }

    /*
    public class Topic {

        public Guid ID { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }
    }
    */

    public class Category {

        [Key]
        public string Value { get; set; }
    }

    public class Technology {

        [Key]
        public string Value { get; set; }
    }
}
