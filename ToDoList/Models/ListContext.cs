using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoList.Models {
    public class ListContext : DbContext{
        public ListContext()
            : base("ToDoListDb") { }

        public DbSet<ToDoList> Lists { get; set; }
        public DbSet<ListElement> ListElements { get; set; }
    }
}