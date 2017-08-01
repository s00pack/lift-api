using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace LiftApi.Models
{
    public class Exercise
    {
        /// <summary>
        /// Name of Exercise
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of Exercise
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Type of Exercise, not mandatory
        /// </summary>
        public ExerciseType ExerciseType { get; set; }
    }
}