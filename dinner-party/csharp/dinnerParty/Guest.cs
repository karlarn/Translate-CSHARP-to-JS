using System;

namespace dinnerParty
{

    public class Guest
    {
        public string Name {get; set;}

        public string Occupation {get; set;}

        public string Bio {get; set;}
        

        public Guest(string _name, string _occ, string _bio)
        {
            Name = _name;
            Occupation = _occ;
            Bio = _bio;
        }
    }
}