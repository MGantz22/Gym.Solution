using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace Gym.Models;

public class Class
{
  public int ClassId { get; set; }
  public string ClassName { get; set; }
  // date
  // max members
  public int InstructorId {get; set;}
  public Instructor Instuctor {get; set;}
  public int LocationId {get; set;}
  public Location Location {get; set;}
  public List<ClassMember> JoinEntities {get;}
}