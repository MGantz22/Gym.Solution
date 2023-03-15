namespace Gym.Models
{
    public class Instructor
    {
        public int InstructorId {get;set;}
        public string InstructorName {get;set;}
        public int ClassId {get;set;}
        public Class Class {get;set;}
    }
}