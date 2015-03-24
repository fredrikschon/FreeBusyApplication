using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeBusyApplication
{
    public class Controller
    {
        DataHolder dh = new DataHolder();
        TimeChecker tc = new TimeChecker();

        OldData od = new OldData();

        public void LoadData()
        {
            od.LoadData(dh);
        }

        /// <summary>
        ///create emplyee
        /// </summary>
        public void CreateEmployee(Employee emp)
        {
            dh.AddEmployee(emp);
        }


        /// <summary>
        ///get employee
        /// </summary>
        public Employee GetEmployee(string id)
        {
            return dh.GetEmployee(id);
        }

        /// <summary>
        ///get list with available times for selected users
        /// </summary>
        public HashSet<DateTime> CheckTime(DateTime earliest, DateTime latest, double duration, string[] meeters, int officeHourStart, int officeHourEnd)
        {
            List<Employee> meeterList = new List<Employee>();
           
            foreach(string meeter in meeters)
            {
                meeterList.Add(dh.GetEmployee(meeter));
            }
            return tc.CheckTime(earliest, latest, duration, meeterList, officeHourStart, officeHourEnd);
        }
    }
}
