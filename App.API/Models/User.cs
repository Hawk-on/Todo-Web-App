using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt{ get; set; }
        public List<TodoPoint> ToDoPoints { get; set; }
        public string Name { get; set; }
        public string Email{ get; set; }
    }
}