using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class GetRoom
    {
        //FIELDS
        private string _name;
        private string _description;
        

        //PROPERTIES
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        //CONSTRUCTORS

        //Fully-Qualified
        public GetRoom(string name, string description)
        {
            //Assignment:
            //Property = parameter;
            Name = name;
            Description = description;

        }

        //METHODS

    }
}



