using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiftApi.Models
{
    /// <summary>
    /// Addidtional information about a user. Connects to ApplicationUser
    /// </summary>
    public class User
    {
        /// <summary>
        /// ID, do not set
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Identification / passsword class, Must be created before User
        /// </summary>
        public ApplicationUser ApplicationUser { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Birth date, not mandatory
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The users data and results are available to watch for all users
        /// </summary>
        public bool AllowPublicDisplay { get; set; }

        /// <summary>
        /// The users data and results are available to watch for all users in the groups the user is member of
        /// </summary>
        public bool AllowGroupDisplay { get; set; }

        /// <summary>
        /// The groups the user is member of
        /// </summary>
        public virtual ICollection<UserGroup> UserGroups { get; set; }

    }
}