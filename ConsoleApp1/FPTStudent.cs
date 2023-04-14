using System;

namespace T2207A
{
    public class FPTStudent : Student
    {
        private string className;
        public FPTStudent() 
        {
            this.Name = "Anh";
        } 
        public FPTStudent(string name,string email, int age,
            string telephone,string className) : base(name, email, age, telephone)
        {
            this.className = className;
        }
        public override void Run()
        {
            base.Learn();
        }
        public new void Learn()//khi khong co virtual ma van phai override
        {

        }
    }
}
