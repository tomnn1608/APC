using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A.Assignment2
{
    public  class News : INews
    {

        private int id; 
        private string title;   
        private string publishdate;
        private string author;
        private string content;
        private float averageRate;

        public News(int id,string title,string publishdate,string author, string content,float averageRate) 
        {
            this.id = id;
            this.title = title;
            this.publishdate = publishdate;
            this.author = author;
            this.content = content;
            this.averageRate = averageRate;
        }

        public int Id 
        {
            get => this.id;
            set => this.id = value;
        }

        public string Title 
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Publishdate 
        {
            get { return this.publishdate; }
            set { this.publishdate = value; }
        }


        public string Author 
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public string Content 
        {
            get { return this.content; }
            set{this.content = value;}
        }

        public float AverageRate
        {
            get { return this.averageRate; }
        }

        public void Display() 
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("PublishDate: " + publishdate);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Content: " + content);
            Console.WriteLine("AverageRate: " + averageRate);
        }

        int[] RateList = new int[3];

        public void Calculate()
        {
            int sum = 0;
            for (int i = 0; i < RateList.Length; i++)
            {
                sum += RateList[i];
            }
            Console.WriteLine(sum);
            averageRate = (float)sum / RateList.Length;
        }
    }
}
