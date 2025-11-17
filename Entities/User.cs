using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace MiniBankApp.Entities
{
    public class User
    {
        public int Id { get; set; }

        private string Normalize(string value)
        {
            if(string.IsNullOrEmpty(value)) return value;
            return char.ToUpper(value[0]) + value.Substring(1).ToLower();
        }
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = Normalize(value);
        }
        private string _surname;
        public string Surname 
        {
            get => _surname;
            set => _surname = Normalize(value);
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<BankAccount> BankAccounts { get; set; }
    }
}
