﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LiftApi.Models
{
    public class Result
    {
        [Key]
        public int ResultId { get; set; }
        /// <summary>
        /// Exercise performed
        /// </summary>
        public Exercise Exercise { get; set; }
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