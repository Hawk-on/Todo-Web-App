using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public List<TodoPoint> ToDoPoints { get; set; }
        public string Name { get; set; }
        public string Email{ get; set; }
        public string Password{ get; set; }
    }
}