using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITlab3.Models
{
    public class FriendContext:DbContext
    {
        public DbSet<FriendModel> Friends { get; set; }
        public FriendContext() : base("DefaultConnection") { }
        public static FriendContext Create()
        {
            return new FriendContext();
        }
    }
}