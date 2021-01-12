using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    public class ProjectContexclst:DbContext
    {
        public ProjectContexclst():base("name=ProjectContext")
        {

        }
        public DbSet<product> products { set; get; }
        public DbSet<order> orders { set; get; }
    }
}