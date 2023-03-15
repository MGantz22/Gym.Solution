using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Gym.Models
{
    public class Member
    {
        public int MemberId {get; set;}
        public string MemberName {get; set;}
        public List<ClassMember> JoinEntities {get;set;}
    }
}