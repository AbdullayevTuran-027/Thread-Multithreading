using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Models
{
    class Employe
    {
        private int _id;
        public int Id { get; }
        private string Name { get; set; }
        private double Salary { get; set; }

        public Employe()
        {
            _id++;
            Id = _id;
            

        }
        public void ShowInfo()
        {
            Console.WriteLine($"id{Id}, Name{Name}, Salary{Salary}");
        }
    }
   

    
}
