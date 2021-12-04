using Database.Data;
using Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Commands
{
    public class RunsListCmd
    {
        public void AddRun(string pace, string distance, string caloriesLost, string organizer)
        {
            using EncounterMeContext context = new EncounterMeContext();
            Runs TempRun = new Runs()
            {
                Pace = pace,
                Distance = Decimal.Parse(distance),
                CaloriesLost = int.Parse(caloriesLost),
                User = organizer
            };
            context.Add(TempRun);
            context.SaveChanges();
        }
        public BindingList<Runs> GetRuns(string CurrentUser)
        {
            using EncounterMeContext context = new EncounterMeContext();
            BindingList<Runs> RunList = new BindingList<Runs>();
            var runs = context.Runs
                .Where(r => r.User == CurrentUser);
            foreach (Runs item in runs)
            {
                RunList.Add(item);
            }
            return RunList;
        }
        public void DeleteRun(int index)
        {
            using EncounterMeContext context = new EncounterMeContext();
            var TempRun = context.Runs
                .Where(p => p.RunId == index)
                .FirstOrDefault();
            if (TempRun is Runs)
            {
                context.Remove(TempRun);
            }
            context.SaveChanges();
        }
        public decimal FindMostBurnedCalories(string CurrentUser)
        {
            decimal maxCal = 0;
            using EncounterMeContext context = new EncounterMeContext();
            if(context.Runs.Where(r => r.User == CurrentUser).Count()>0)
                maxCal = context.Runs.Where(r => r.User == CurrentUser).Max(r => r.CaloriesLost);
            return maxCal;
        }
        public decimal FindAllBurnedCalories(string CurrentUser)
        {
            decimal allCal = 0;
            using EncounterMeContext context = new EncounterMeContext();
            if (context.Runs.Where(r => r.User == CurrentUser).Count() > 0)
                allCal = context.Runs.Where(r => r.User == CurrentUser).Sum(r => r.CaloriesLost);
            return allCal;
        }
        public decimal FindLongestPace(string CurrentUser, string pace)
        {
            decimal allCal = 0;
            using EncounterMeContext context = new EncounterMeContext();
            if (context.Runs.Where(r => r.User == CurrentUser).Where(r => r.Pace == pace).Count() > 0)
                allCal = context.Runs.Where(r => r.User == CurrentUser).Where(r => r.Pace == pace).Max(r => r.Distance);
            return allCal;
        }
    }
}
