using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop.ViewModels
{
    public class SignUpViewModel
    {
        public User u { get; set; }

        public List<User> uList {get; set;}

    }
}