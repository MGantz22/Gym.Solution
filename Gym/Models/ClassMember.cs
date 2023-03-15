using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace Gym.Models
{
    public class ClassMember
    {
        public int ClassMemberId {get;set;}
        public int ClassId {get; set;}
        public int MemberId {get; set;}
        public Member Member {get; set;}
        public Class Class {get; set;}

    }
}
