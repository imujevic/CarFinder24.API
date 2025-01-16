using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Account
{
    // UserDto.cs
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateCreated { get; set; }
    }

    // UserCreateDto.cs
    public class UserCreateDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Šifrovana lozinka biće obrađena na serverskoj strani
        public string PhoneNumber { get; set; }
    }

    // UpdateUserDto.cs
    public class UpdateUserDto
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string? Password { get; set; } // Polje za lozinku je opcionalno, ako korisnik želi da je promeni
    }
}
