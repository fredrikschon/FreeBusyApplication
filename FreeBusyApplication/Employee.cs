using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeBusyApplication
{
    public class Employee
    {
        private string name;
        private string id;
        private List<DateTime[]> schedule = new List<DateTime[]>();

        public Employee(string id, string name)
        {
            this.name = name;
            this.id = id;
            this.schedule.Add(new DateTime[]{DateTime.Now.AddMonths(-1), DateTime.Now.AddDays(-20) });
        }

        public Employee(string id, string name, DateTime[] dates)
        {
            this.name = name;
            this.id = id;
            this.schedule.Add(dates);
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public string GetId()
        {
            return this.id;
        }

        public void AddToSchedule(DateTime[] dates)
        {
            this.schedule.Add(dates);
        }

        public List<DateTime[]> GetSchedule()
        {
            
            return this.schedule;
        }
    }
}
