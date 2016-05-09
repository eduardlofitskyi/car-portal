using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Auto.Models
{
    public class UserLogin
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Town { get; set; }
        public string PhoneNumber { get; set; }
        public string Birth { get; set; }
        public bool IsAdmin { get; set; }

        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; }

        public virtual ShoppingCart ShoppingCarts { get; set; }


        public UserLogin(int id, string name, string surname, string town, string phoneNumber, string email, string password, string birth)
        {
           
            Id = id;
            Name = name;
            Surname = surname;
            Town = town;
            PhoneNumber = phoneNumber;
            Email = email;
            Password = password;
            Birth = birth;
        }

        public UserLogin(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public UserLogin()
        {
        }
    }
}