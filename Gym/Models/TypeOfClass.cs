using System.Collections.Generic;
namespace Gym.Models;

public class TypeOfClass 
{
    public int TypeOfClassId {get;set;}
    public string TypeOfClassName {get; set;}
    public List<Class> Classes {get;set;}
}
