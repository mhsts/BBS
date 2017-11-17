using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    [Serializable]
    public class ContantPerson : Person
    {
        public override bool CommitMutation()
        {
            if (!(currentMutation is Deposit))
            {
                decimal cost = this.currentMutation.GetCost();

                bool succ = base.CommitMutation();

                //reset balance with a deposit mutation (for bookkeeping)
                AddNewMutation(new Deposit(this, this, cost));
                CommitMutation();

                return succ;
            }
            else
                return base.CommitMutation();
        }

        public ContantPerson() : base("<<Contant>>", GetID()) 
        {
            this.Role = PersonRole.BAR;
        }

        public static ID GetID()
        {
            return new ID("99991111", "qq33");
        }

        public override bool ShowToUser()
        {
            return false;
        }
    }
}
