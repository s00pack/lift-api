﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LiftApi.Models
{
    /// <summary>
    /// Group of similar Exercises
    /// </summary>
    public class ExerciseType
    {
        [Key]
        public int ExerciseTypeId { get; set; }
        /// <summary>
        /// Name of ExerciseType
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of ExerciseType
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// All Excercices in the ExerciseType. Not mandatory. PUT adds Exercises without removing those included. Delete does not delete Exercises.
        /// </summary>
        public virtual List<Exercise> Exercises { get; set; }

    }

    
}