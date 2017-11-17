using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    [Serializable]
    public class NamedObject
    {
        protected String name;
        public String Name { get { return name; } set { name = value;} }
    }
}
