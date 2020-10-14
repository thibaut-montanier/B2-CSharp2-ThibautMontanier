using System;
using System.Collections.Generic;
using System.Text;

namespace B2MyLibForUT.Model {
    public class Personne {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public SexEnum Sex { get; set; }
        public enum SexEnum {
            Male,
            Female
        }
    }
}
