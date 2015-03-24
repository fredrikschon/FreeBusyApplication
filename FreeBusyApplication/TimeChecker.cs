using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeBusyApplication
{
    public class TimeChecker
    {

        /// <summary>
        /// Method for getting a HashSet list of available dates when the Employee's aren't already scheduled
        /// </summary>
        /// <param name="earliest">DateTime for date starting point in search for intersecting available time</param>
        /// <param name="latest">DateTime for date ending point in search for intersecting available time</param>
        /// <param name="duration">double duration of meeting in minutes</param>
        /// <param name="meeters">List of Employee; containing the Employees whos schedule to be intersected</param>
        /// <param name="officeHourStart">int start scope of schedule search</param>
        /// <param name="officeHourEnd">int end scope of schedule search</param>
        public HashSet<DateTime> CheckTime(DateTime earliest, DateTime latest, double duration, List<Employee> meeters, int officeHourStart, int officeHourEnd){
            
            //list of the different employees available dates
            List<HashSet<DateTime>> listEmpDates = new List<HashSet<DateTime>>();

            //the interval we check for available dates (in minutes)
            const int marginInterval = 10;
            
            //loop through every selected employee
            foreach (Employee emp in meeters)
            {
                //List available dates for employee's schedule's date 
                List<List<DateTime>> listListDates = new List<List<DateTime>>();

                //loop through every date in employee schedule
                foreach(DateTime[] date in emp.GetSchedule())
                {
                    //reset the checker (tmpEarliest) to its starting point
                    DateTime tmpEarliest = earliest;

                    //list of available times per date in schedule
                    List<DateTime> dateDate = new List<DateTime>();

                    //loop through the time span
                    while (tmpEarliest < latest)
                    {
                        //if current checker-date(tmpEarliest)+duration of meeting isn't crossing the line to an already scheduled meeting and is within officeHours
                        if (tmpEarliest.Hour >= officeHourStart && tmpEarliest.Hour < officeHourEnd && tmpEarliest.AddMinutes(duration).Hour < officeHourEnd && tmpEarliest.CompareTo(date[0]) == tmpEarliest.AddMinutes(duration).CompareTo(date[0]) && tmpEarliest.CompareTo(date[1]) == tmpEarliest.AddMinutes(duration).CompareTo(date[1]) && tmpEarliest.CompareTo(date[0]) != 0)
                        {
                            //and isn't completely within a scheduled meeting's time span
                            if ((tmpEarliest > date[0] && tmpEarliest < date[1]) || (tmpEarliest.AddMinutes(duration) > date[0] && tmpEarliest.AddMinutes(duration) < date[1]))
                            {
                                //add the interval of minutes and try again
                                tmpEarliest = tmpEarliest.AddMinutes(marginInterval);   
                            }
                            else
                            {
                                //if the time isnt crossing any lines or is within the time span of a meeting we add this time as an available meeting time
                                dateDate.Add(tmpEarliest);
                                //and add the inteval of minutes to see if the meeting can be scheduled later, for more options
                                tmpEarliest = tmpEarliest.AddMinutes(marginInterval);
                            }
                        }
                        else
                        {
                            //add the interval of minutes and try again
                            tmpEarliest = tmpEarliest.AddMinutes(marginInterval);
                        }
                    }
                    //add the list of available times for this date in the schedule in the list 
                    listListDates.Add(dateDate);
                    
                }
                //intersect all the dates to get dates available for all the selected employees
                HashSet<DateTime> commonDateDates = listListDates.Skip(1).Aggregate(new HashSet<DateTime>(listListDates.First()), (h, e) => { h.IntersectWith(e); return h; });
                //add that intersected list to employees available dates list
                listEmpDates.Add(commonDateDates);
            }

            //intersect employees available dates and get one list of times available for all the employees
            HashSet<DateTime> common = listEmpDates.Skip(1).Aggregate(new HashSet<DateTime>(listEmpDates.First()),(h, e) => { h.IntersectWith(e); return h; });

            try
            {
                //if times available
                return common;
            }
            catch (Exception e)
            {
                //if no times available
                return null;
            }
        }

        
    }
}
