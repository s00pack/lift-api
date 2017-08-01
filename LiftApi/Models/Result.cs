using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiftApi.Models
{
    public class Result
    {
        /// <summary>
        /// Excercise performed
        /// </summary>
        public Excercise Excercise { get; set; }
        /// <summary>
        /// Amount/reps
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Weight in KG
        /// </summary>
        public decimal? Weight { get; set; }
        /// <summary>
        /// User
        /// </summary>
        public ApplicationUser User { get; set; }
        /// <summary>
        /// Date/Time of this achivement 
        /// </summary>
        public DateTime DateTime{ get; set; }

    }
}