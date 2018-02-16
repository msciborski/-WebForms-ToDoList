using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoList.Models {
    public class ToDoList {

        [Key]
        public int ToDoListId { get; set; }

        [StringLength(160)]
        [DisplayName("Name")]
        [Required]
        public string ListName { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual ICollection<ListElement> ListElements { get; set; }
    }
}