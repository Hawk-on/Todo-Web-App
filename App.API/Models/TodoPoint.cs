using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.API.Models
{
    public class TodoPoint
    {
        public int Id{ get; set; }
        [ForeignKey("UserForeignKey")]
        public User User { get; set; }
        public string Title{ get; set; }
        public string Description{ get; set; }
        public string Type{ get; set; }


    }
}