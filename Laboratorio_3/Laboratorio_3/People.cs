using System;
namespace Laboratorio_3
{
    public class People
    {
        protected string name;
        protected string lastname;
        protected string id;
        protected string nationality;
        public People(string name, string lastname, string id, string nationality)
        {
            this.name = name;
            this.lastname = lastname;
            this.id = id;
            this.nationality = nationality;
        }
        public string Name {
            get { return name; }
        }
        public string Lastname
        {
            get { return lastname; }
        }
        public string ID
        {
            get { return id; }
        }
        public string Nationality
        {
            get { return nationality; }
        }
    }
}
