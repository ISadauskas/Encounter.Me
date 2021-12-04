using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Data;
using Database.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Database.Commands
{
    public class TrailCmd
    {
        public void AddTrail(string name, string length, DateTime date, DateTime time, string location, string organizer)
        {
            using EncounterMeContext context = new EncounterMeContext();
            Trails TempTrail = new Trails()
            {
                Name = name,
                Length = Decimal.Parse(length),
                Timestamp = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, 00),
                Location = location,
                Organizer = organizer
            };
            context.Add(TempTrail);
            context.SaveChanges();
        }
        public BindingList<Trails> GetTrails()
        {
            using EncounterMeContext context = new EncounterMeContext();
            BindingList<Trails> TrailList = new BindingList<Trails>();
            var trails = context.Trails;
            foreach (Trails item in trails)
            {
                TrailList.Add(item);
            }
            return TrailList;
        }
        public BindingList<Trails> SearchTrails(string from, string to)
        {
            using EncounterMeContext context = new EncounterMeContext();
            BindingList<Trails> TrailList = new BindingList<Trails>();
            var trails = context.Trails
                .Where(t => t.Length > int.Parse(from))
                .Where(t => t.Length < int.Parse(to));
            foreach (Trails item in trails)
            {
                TrailList.Add(item);
            }
            return TrailList;
        }
        public void DeleteTrail(int index)
        {
            using EncounterMeContext context = new EncounterMeContext();
            var TempTrail = context.Trails
                .Where(t => t.TrailId == index)
                .FirstOrDefault();
            if(TempTrail is Trails)
            {
                context.Remove(TempTrail);
            }
            context.SaveChanges();
        }
        public void UpdateTrail(int index, string name, string length, DateTime date, DateTime time, string location)
        {
            using EncounterMeContext context = new EncounterMeContext();
            var TempTrail = context.Trails
                .Where(p => p.TrailId == index)
                .FirstOrDefault();
            if (TempTrail is Trails)
            {
                TempTrail.Name = name;
                TempTrail.Length = Decimal.Parse(length);
                TempTrail.Timestamp = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, 00);
                TempTrail.Location = location;
            }
            context.SaveChanges();
        }
    }
}
