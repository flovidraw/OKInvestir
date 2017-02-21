using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKInvestir.ViewModel;

namespace OKInvestir.Model
{
    public class User
    {
        public int Id { get; set; } // 1 for employee, 2 for administrator(Can add/modify/delete product)
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserLevel { get; set; }

        public User(int userLevel) // constructor for testing
        {
            this.Id = 1;
            this.UserLevel = userLevel;
            this.Username = "testName";
            this.Password = "testPassword";
        }

        public User() {

        }

    }
}
