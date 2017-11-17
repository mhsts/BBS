using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace BBS.View.DataLists.DataItems
{
    public class BalansPersonItem
    {
        private Person person;

        public BalansPersonItem(Person p)
        {
            person = p;
            Name = person.Name;
            Balance = String.Format("{0:0.00}", person.Balance);
            LastActive = person.LastActivity.ToShortDateString();
            
            if (person.Balance < 0m)
                BalanceRedSince = person.GetNegativeBalanceSinceTimeStamp().ToShortDateString();
            else
                BalanceRedSince = "";
            
            Email = p.EmailAddress;
            Role = Person.RoleToString(person.Role);
        }

        public Person GetPerson()
        {
            return person;
        }

        [DisplayName("Naam")]
        public string Name { get; private set; }

        [DisplayName("Balans")]
        public string Balance { get; private set; }

        [DisplayName("Laats actief")]
        public string LastActive { get; private set; }

        [DisplayName("Rood sinds")]
        public string BalanceRedSince { get; private set; }

        [DisplayName("Email")]
        public string Email { get; private set; }

        [DisplayName("Rol")]
        public string Role { get; private set; }
    }
}
