using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LiftApi.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<LiftApi.Models.Exercise> Exercises { get; set; }

        public System.Data.Entity.DbSet<LiftApi.Models.ExerciseType> ExerciseTypes { get; set; }

        public System.Data.Entity.DbSet<LiftApi.Models.Result> Results { get; set; }

        public System.Data.Entity.DbSet<LiftApi.Models.UserInfo> UserInfos { get; set; }

        public System.Data.Entity.DbSet<LiftApi.Models.UserGroup> UserGroups { get; set; }
    }
}