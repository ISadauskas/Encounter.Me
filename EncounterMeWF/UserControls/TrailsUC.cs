using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncounterMeWF.UserControls
{
    public partial class TrailsUC : UserControl
    {
        public TrailsUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var trails = new List<Trail>
            {
                new Trail
                {
                    ID = 1,
                    Name = "Alex",
                    DateOfBirth=DateTime.Now,
                    Address="New York Street 18"
                },
                new Trail
                {
                    ID = 2,
                    Name = "Bob",
                    DateOfBirth = DateTime.Now,
                    Address = "Vilnius avenue 15"
                },
                new Trail
                {
                    ID = 3,
                    Name = "Cassandra",
                    DateOfBirth = DateTime.Now,
                    Address = "Panevezio kaimas 32"
                }
            };

            var trail1 = new Trail
            {
                ID = 4,
                Name = "Diana",
                DateOfBirth = DateTime.Now,
                Address = "Ryto gatve 2"
            };

            string TrailJson = JsonConvert.SerializeObject(trails);
            File.WriteAllText(@"Try.json", TrailJson);
            

            TrailJson = String.Empty;
            TrailJson = File.ReadAllText(@"Try.json");

            List<Trail> TrailString = JsonConvert.DeserializeObject<List<Trail>>(TrailJson);
            //DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(TrailJson, (typeof(DataTable)));
            TrailGridView.DataSource = TrailString;
            /*var TrailString1 = JsonConvert.DeserializeObject<IDictionary>(TrailJson);
            foreach (DictionaryEntry entry in TrailString1)
            {
                JsonText.Text += entry.Key + ": "+ entry.Value+"\r\n";
            }*/

            //JsonText.Text = TrailString.ToString();
        }
    }
}
