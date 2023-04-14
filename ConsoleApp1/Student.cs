using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class Student
    {
        private string name;
        private string email;
        private int age;
        private string telephone;
        public Student()
        {
            this.Run();
            Learn();
        }
        public Student(string name, string email, int age,string telephone)
        {
            this.name = name;
            this.email = email;
            this.age = age;
            this.telephone = telephone;
        }  
        public string Name// property
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public int Age
        {
           get => this.age;
           set => this.age = value;
        }
        public int Telephone
        {
            get => this.Telephone; 
            set => this.Telephone = value;   
        }
        public virtual void Run()
        {
            Console.WriteLine(this.name +"Running...");
        }
        public void Learn()
        {
            Console.WriteLine("Learning...");
        }
        public void Learn(String s)
        {
            Console.WriteLine("Learning..."+s);
        }
    }
}