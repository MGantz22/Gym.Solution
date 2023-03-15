using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Gym.Models
{
    public class Location
    {
        public int LocationId {get; set;}
        public string LocationName {get; set;}
        public int ClassId {get; set;}
        public Class Class {get; set;}
        public int InstructorId {get; set;}
        public Instructor Instructor {get; set;}
        
    }
}