using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeBusyApplication
{
    class DataHolder
    {
        Dictionary<string, Employee> employees = new Dictionary<string,Employee>();

        public void AddEmployee(Employee emp)
        {
            this.employees.Add(emp.GetId(), emp);
        }

        public Employee GetEmployee(string id)
        {
            return this.employees[id];
        }
    }
}
