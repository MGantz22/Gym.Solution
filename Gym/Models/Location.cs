using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Gym.Models
{
    public class Location
    {
        public int LocationId {get; set;}
        public string LocationName {get; set;}
        //address?
        //hours?
        public List<LocationInstructor> JoinEntities {get;}
    }
}