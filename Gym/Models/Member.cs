using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Gym.Models
{
    public class Member
    {
        public int MemberId {get; set;}
        public int ClassId {get; set;}
        public Class Class {get; set;}
        

    }
}