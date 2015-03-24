using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeBusyApplication
{
    class OldData
    {
        DataHolder dh;
        public void LoadData(DataHolder dh)
        {
            this.dh = dh;
            //declare file & variables
            StreamReader sr = new StreamReader("freebusy.txt");
            //list of all the rows
            ArrayList rows = new ArrayList();
            //list of id, name of employee
            Dictionary<string, string> people = new Dictionary<string, string>();
            string line;

            //Read all rows, saved in ArrayList rows
            while ((line = sr.ReadLine()) != null)
            {
                string[] lineSentence = line.Split(';');
                rows.Add(lineSentence);

                // every time an employee (ID;NAME) is found (only one semicolon in the row) save this person to a keyvalue-list
                if (lineSentence.Length == 2 && !lineSentence[1].Equals(""))
                {
                    try
                    {
                        people.Add(lineSentence[0], lineSentence[1]);
                    }
                    catch (Exception e)
                    {
                        //just ignore duplicates
                    }
                }

                //if its a date (ID;DATE;DATE;RUBBISH)
                if (lineSentence.Length > 2)
                {
                    for (int i = 1; i < lineSentence.Length - 1; i++)
                    {
                        //do something with dates (lineSentence[i])
                    }
                }
            }

            //loop through people and do stuff
            foreach (var peep in people)
            {
                string id = peep.Key;
                string name = peep.Value;
                dh.AddEmployee(new Employee(id, name));
                
                /*
                //loop through all rows
                foreach (string[] row in rows)
                {
                    //if its a date and it's equal to current person in loop (SQL join, kind of)
                    if (row[0].Equals(id) && row.Length > 2)
                    {
                        //do something like name - time
                        System.Windows.Forms.MessageBox.Show(name + " @ " + row[1] + " - " + row[2]);
                    }
                }*/
            }

            //loop through all rows
            foreach (string[] row in rows)
            {
                //if its a scheduled date
                if(row.Length > 2){
                   // System.Windows.Forms.MessageBox.Show(row[0] + " @ " + row[1] + " # " + row[2] + " # " + row[3]);
                    try
                    {
                        DateTime date1 = DateTime.ParseExact(row[1], "M/d/yyyy h:m:ss tt", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                        DateTime date2 = DateTime.ParseExact(row[2], "M/d/yyyy h:m:ss tt", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));

                        DateTime[] busy = new DateTime[2] { date1, date2 };
                        dh.GetEmployee(row[0]).AddToSchedule(busy);

                    }
                    catch (Exception e)
                    {
                        //ignore errors in txt-document
                    }
                }
            }
        }
    }
}
