using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTask.Pages
{
    public class Employee
    {
        int id, salary;
        String name, loc, dep;

        public int Id { get => id; set => id = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Name { get => name; set => name = value; }
        public string Loc { get => loc; set => loc = value; }
        public string Dep { get => dep; set => dep = value; }
    }
}
