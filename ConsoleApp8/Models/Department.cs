using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Models
{
    class Department
    {
        private int _id;
        public int Id { get; }
        public List<Employe> _employees;

        public Department()
        {
            _id++;
            Id = _id;
            _employees = new List<Employe>();
        }
        public void AddEmployee(Employe employe)
        {
            _employees.Add(employe);
        }
    }
}
