using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_ASS_02
{
    #region Q1
    internal struct Person
        
    {
        string name;

        int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Name : {name},Age:{age}";
        }

}
    #endregion


}
