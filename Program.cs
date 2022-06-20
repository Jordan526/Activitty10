using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//
                             //Lydia's code - find the errors!
namespace CST117_IC08_console
{
    class Set
    {
        private List<int> elements;
        public Set()
        {
            elements = new List<int>();
        }
        public bool addElement(int val)
        {
            if (containsElement(val)) 
                return false;
            else
            {
                elements.Add(val); 
                return true;
            }

        }
        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i]) 
                    return true;
                //else return false; 
                //removing this statement as this is an invalid case due to the nature of how return statements work. Once we meet the requirements for the return statement, our code breaks. An example is ending the for-loop prematurely thus resulting in a wrong output. 
            }
            return false;
        }
        public override string ToString()
        {
            string str = ""; 
            foreach (int i in elements) 
            {
                str += i + " "; 
            }
            return str;
        }
        public void clearSet()
        {
            elements.Clear();
        }
        public Set Union(Set rhs)
        {
            //the pre-written union function produced a wrong update, below is an updated method. 
            //creating a temporary set to store the union in. 
            Set temp = new Set();
            //now, we iterate through the exisiting list and adding the elements to the temp Set if the element does not already exist. 
            for (int i = 0; i < elements.Count; i++)
            {
                if (!temp.containsElement(elements[i])) //if the element doesn't already exist in the unioun, the the element[i] is added to the union.
                {
                    temp.addElement(elements[i]);
                }
            }

            //now, we iterate through the passed in object's element list. 
             for (int i = 0; i < rhs.elements.Count; i++)
               {
                if (!temp.containsElement(rhs.elements[i])) //if the element doesn't already exist in the unioun, the the element[i] is added to the union.
                {
                    temp.addElement(rhs.elements[i]);
                }
            }
            //return rhs;
            //instead of return returning rhs, we now return the new temporary Set. 
            return temp;
            }

        }
    }
