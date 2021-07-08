using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Homework1.Models
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            Hobbies = new List<string>();
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public List<string> Hobbies { get; set; }
        public List<string> FavBooks { get; set; }

        //public string NameLastName
        //{
        //    get
        //    {
        //        return $"{Name} {LastName} adlı kullanı hoşgeldin";
        //    }
        //}
        public string NameLastName => $"{Name} {LastName} adlı kullanıcı hoşgeldin";
    }
}
