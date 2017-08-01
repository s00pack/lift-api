using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace LiftApi.Models
{
    public class Excercise
    {
        /// <summary>
        /// Name of Excercise
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of Excercise
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Type of Excercise, not mandatory
        /// </summary>
        public ExcerciseType ExcerciseType { get; set; }
    }
}