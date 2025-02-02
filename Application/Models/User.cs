﻿using System.ComponentModel.DataAnnotations;

namespace Server.Application.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Authentication { get; set; }


        public User(string FirstName, string LastName, string Email, string Password, string Authentication)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Password = Password;
            this.Authentication = Authentication;
        }
    }
}
