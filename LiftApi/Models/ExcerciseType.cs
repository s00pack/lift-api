using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiftApi.Models
{
    /// <summary>
    /// Group of similar excercises
    /// </summary>
    public class ExcerciseType
    {
        /// <summary>
        /// Name of ExcerciseType
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of ExcerciseType
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// All Excercices in the ExcerciseType. Not mandatory. PUT adds excercises without removing those included. Delete does not delete Excercises.
        /// </summary>
        public IEnumerable<Excercise> Excercises { get; set; }

    }

    
}