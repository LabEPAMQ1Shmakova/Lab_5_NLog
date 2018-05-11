using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DevAttribute : System.Attribute
    {
        private string name;
        private int id;

        public DevAttribute(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public virtual string Name
        {
            get { return name; }
        }

        public virtual int ID
        {
            get { return id; }
        }
    }
}
