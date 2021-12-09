using Database.Data;
using Database.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace Database.Commands
{
    public class RunsController
    {
        public void AddRun(string pace, string distance, string caloriesLost, string organizer)
        {
            string calories = caloriesLost.Substring(0, caloriesLost.Length - 4);
            using EncounterMeContext context = new EncounterMeContext();
            Runs TempRun = new Runs()
            {
                Pace = pace,
                Distance = Decimal.Parse(distance),
                CaloriesLost = int.Parse(calories),
                User = organizer
            };
            context.Add(TempRun);
            context.SaveChanges();
        }
        public SortableBindingList<Runs> GetRuns(string CurrentUser)
        {
            using EncounterMeContext context = new EncounterMeContext();
            int number = context.Runs.Where(r => r.User ==  CurrentUser).Count();
            var RunsJoin =
                from users in context.Users
                join runs in context.Runs on users.Username equals runs.User
                select new { RunId = runs.RunId, Pace=runs.Pace, Distance=runs.Distance, CaloriesLost=runs.CaloriesLost, User=users.Username };

            List<Runs> Runs = new List<Runs>();
            SortableBindingList<Runs> RunList = new SortableBindingList<Runs>(Runs);

            if (number > 0)
            {
                var runs = context.Runs.Where(r => r.User == CurrentUser).Take(number);
                foreach (var item in runs)
                    RunList.Add(item);
                return RunList;
            }
            else
            {
                var runs = context.Runs.Where(r => r.User == CurrentUser).Skip(0);
                foreach (Runs item in runs)
                    RunList.Add(item);
                return RunList;
            }
                
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
        public int FindMostBurnedCalories(string CurrentUser)
        {
            int maxCal = 0;
            using EncounterMeContext context = new EncounterMeContext();
            if (context.Runs.Where(r => r.User == CurrentUser).Count() > 0)
                maxCal = context.Runs.Where(r => r.User == CurrentUser).Max(r => r.CaloriesLost);
            return maxCal;
        }
        public int FindAllBurnedCalories(string CurrentUser)
        {
            int allCal = 0;
            List<int> burnedCallorieArray = new List<int>();
            using EncounterMeContext context = new EncounterMeContext();
            if (context.Runs.Where(r => r.User == CurrentUser).Count() > 0)
                allCal = context.Runs.Where(r => r.User == CurrentUser).ToArray().Select(r => r.CaloriesLost).Aggregate((a,b) =>a+b);
            return allCal;
        }
        public decimal FindLongestPace(string CurrentUser, string pace)
        {
            using EncounterMeContext context = new EncounterMeContext();
            if(context.Runs.Where(r => r.User == CurrentUser).Where(r => r.Pace == pace).Count() > 0)
            {
                var max = context.Runs.GroupBy(x => new { x.User, x.Pace }).Select(g => new
                {
                    User = g.Key.User,
                    Pace = g.Key.Pace,
                    MaxDistance = g.Max(row => row.Distance)
                }).Where(r => r.User == CurrentUser);

                return max.Where(r => r.Pace == pace).Select(r => r.MaxDistance).Max();
            }
            return 0;
        }
    }
}
