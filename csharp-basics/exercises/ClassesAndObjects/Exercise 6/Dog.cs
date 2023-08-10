using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class Dog
    {
        private string name;
        private string sex;
        private Dog mother;
        private Dog father;

        public Dog(string name, string sex)
        {
            this.name = name;
            this.sex = sex;
        }

        public string Name { get { return name; } }
        public string Sex { get { return sex; } }

        public void SetMother(Dog mother)
        {
            this.mother = mother;
        }

        public void SetFather(Dog father)
        {
            this.father = father;
        }

        public string FathersName()
        {
            if (father == null)
            {
                return "Unknown";
            }
            return father.Name;
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            if (mother == null || otherDog.mother == null)
            {
                return false;
            }
            return mother.Name == otherDog.mother.Name;
        }
    }
}