using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Skill_CodeFirst_Project.Models.siniflar
{
    public class CONTEXT:DbContext
    {
        public DbSet<Yetenekler>Yeteneklers { get; set; }

    }
}