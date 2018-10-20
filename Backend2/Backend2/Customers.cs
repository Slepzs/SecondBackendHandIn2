using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend2
{
    public class Customers
    {
        private string name;
        private int age;
        private int zipcode;
        private string password;
        private string region;

        private string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int Age
        {
            get { return age; }
            set { age = value; }
        }

        private int Zipcode
        {
            get { return zipcode; }
            set { zipcode = value; }
        }

        private string Password
        {
            get { return password; }
            set { password = value;  }
        }

        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        public Customers(string name, int age, int zipcode, string password, string region)
        {
            this.Name = name;
            this.Age = age;
            this.Zipcode = zipcode;
            this.Password = password;
            this.Region = region;

        }

        public static List<Customers> customerlist = new List<Customers>();

        public override string ToString()
        {
            return "Name: " + name + " Age: " + age + " zipcode " + zipcode + " Region " + region;
        }



    }
}