using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoList.Models {
    public class ListElement {
        [Key]
        public int ListElementId { get; set; }

        [Required]
        [StringLength(250)]
        public string ListElementText { get; set; }

        [Range(0, 6)]
        [DefaultValue(0)]
        public int Priority { get; set; }

        public int ToDoListId { get; set; }
        public virtual ToDoList List { get; set; }
        
    }
}