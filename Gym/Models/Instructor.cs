using System.Collections.Generic;
namespace Gym.Models
{
    public class Instructor
    {
        public int InstructorId {get;set;}
        public string InstructorName {get;set;}
        public List<Class> Classes {get; set;}
        public List<LocationInstructor> JoinEntities {get;}
        
    }

}