namespace Gym.Models
{
    public class LocationInstructor
    {
        public int LocationInstructorId {get; set;}
        public int LocationId {get; set;}
        public int InstructorId {get; set;}
        public Location Location {get; set;}
        public Instructor Instructor {get; set;}
        public List<LocationInstructor> JoinEntities {get;}
    }
}