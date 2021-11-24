using System;
using System.Collections;
using System.Collections.Generic;
using Bogus;
using Bogus.DataSets;
using Bogus.Extensions;
using Newtonsoft.Json;

namespace Eurotestament
{
    public class Check
    {
        public string CheckNum { get; set; }
        public int Form { get; set; }
        public int Balance { get; set; }
        public int Currency { get; set; }


        public Faker<Check> generate()
        {
            var rnd = new Randomizer().Number(4);
            var CheckData = new Faker<Check>("ru")
            .CustomInstantiator(f => new Check())
            .RuleFor(u => u.CheckNum, f => f.Finance.Account(15))
            .RuleFor(u => u.Form, f => f.Random.Number(2))
            .RuleFor(u => u.Balance, f => f.Random.Number(100000))
            .RuleFor(u => u.Currency, f => f.Random.Number(1))
            .FinishWith((f, u) => { });



            return CheckData;
        }

    }


    public class User
    {

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string email { get; set; }
        public string PhoneNum { get; set; }




        public Faker<User> generate()
        {
            var UserData = new Faker<User>("ru")
            .CustomInstantiator(f => new User())
            .RuleFor(u => u.Id, f => f.Finance.Account(8))
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.Login, (f, u) => f.Internet.UserName(u.FirstName, u.LastName))
            .RuleFor(u => u.emal, f => f.Internet.Password())
            .RuleFor(u => u.PhoneNum, f => f.Phone.PhoneNumber())
            .FinishWith((f, u) => { });

            return UserData;
        }

        


    }

        
}


