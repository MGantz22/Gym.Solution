using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace Gym.Models;

public class Class
{
  public int ClassId { get; set; }
  public string Name { get; set; }
  // date
  // max members
  public int InstructorId {get; set;}
  public Instructor Instructor {get; set;}
  public int LocationId {get; set;}
  public Location Location {get; set;}
  public List<ClassMember> JoinEntities {get;}
  // public LocationInstructor placetimething {get;set;}
}