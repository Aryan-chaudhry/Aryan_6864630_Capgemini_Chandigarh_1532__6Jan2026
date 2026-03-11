using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    internal class Person
    {
        string PersonName;
        string PersonPhoneNumber;
        string PersonLocation;
        int PersonAge;

        public string Name
        {
            get
            {
                return PersonName;
            }

            set
            {
                PersonName = value;
            }
        }

        public int Age
        {
            get
            {
                return PersonAge;
            }

            set
            {
				PersonAge = value;
            }
        }

        public string Number
        {
            get
            {
                return PersonPhoneNumber;
            }

            set
            {
				PersonPhoneNumber = value;
            }
        }

        public string Location
        {
            get
            {
                return PersonLocation;
            }
            set
            {
				PersonLocation = value;
            }
        }

    }
}
