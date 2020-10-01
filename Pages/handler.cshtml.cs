using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyTask.Pages;

namespace MyTask
{
    public class handlerModel : PageModel
    {
        List<String> employee_name = new List<String>();
        List<Employee> employee_data = new List<Employee>();
        public ActionResult OnGet()
        {
            List<Employee> employee_data = new List<Employee>();
            Employee e = new Employee();
            e.Id = 1;
            e.Name = "Anil Asavani";
            e.Salary = 26000;
            e.Loc = "Gandhinagar";
            e.Dep = "Developing";
            employee_data.Add(e);
            Employee e1 = new Employee();
            e1.Id = 2;
            e1.Name = "Sunil Asavani";
            e1.Salary = 35000;
            e1.Loc = "Ahmedabad";
            e1.Dep = "Testing";
            employee_data.Add(e1);
            /*employee_name.Add("Anil");
            employee_name.Add("Sunil");
            employee_name.Add("Jayesh");
            employee_name.Add("Manan");*/
            return Content(JsonSerializer.Serialize(employee_data));
        }
        public JsonResult OnGetEmployee_find(int salary)
        {
            Employee e = new Employee();
            e.Id = 1;
            e.Name = "Anil Asavani";
            e.Salary = 26000;
            e.Loc = "Gandhinagar";
            e.Dep = "Developing";
            employee_data.Add(e);
            Employee e1 = new Employee();
            e1.Id = 2;
            e1.Name = "Sunil Asavani";
            e1.Salary = 35000;
            e1.Loc = "Ahmedabad";
            e1.Dep = "Testing";
            employee_data.Add(e1);
            Employee es=employee_data.Find(x => x.Salary == salary);
            return new JsonResult(es);
        }
     
        public void onPost()
        {

        }
    }
}