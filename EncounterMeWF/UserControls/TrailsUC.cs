using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EncounterMeWF.UserControls
{
    public partial class TrailsUC : UserControl
    {
        public TrailsUC()
        {
            InitializeComponent();
            string TrailJson;
            //string TrailJson = JsonConvert.SerializeObject(trail1);

            TrailJson = File.ReadAllText(@"Try.json");

            List<Trail> TrailString = JsonConvert.DeserializeObject<List<Trail>>(TrailJson);
            //DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(TrailJson, (typeof(DataTable)));
            TrailGridView.DataSource = TrailString;
        }

        List<Trail> trails1 = new List<Trail>();  

        private void button1_Click(object sender, EventArgs e)
        {
            var trails = new List<Trail>
            {
                new Trail
                {
                    ID = 1,
                    Name = "Vingis",
                    Length = 15,
                    //Struct (x,y,name)
                    //Atskiri objectai
                    //map component
                    Coordinates = new List<string>{"54.756950621066615, 25.2863662915624",
                        "54.748480401844894, 25.292460270498772"}
                },
                new Trail
                {
                    ID = 2,
                    Name = "Zirmunai",
                    Length = 10,
                    //Delete = new Button()
                    Coordinates = new List<string>{"54.73812550515925, 25.278469868151888",
                        "54.719500681990226, 25.287847582779122",
                        "54.696638924403125, 25.273524397653002"}
                },
                new Trail
                {
                    ID = 3,
                    Name = "Zujunai",
                    Length = 7.5,
                    //Delete = new Button()
                    Coordinates = new List<string>{"54.690465443303005, 25.207249320713487"}
                }
            };

            var trail1 = new List<Trail>
            {
                new Trail
                {
                ID = 4,
                Name = "Pavilniai",
                Length = 8.2,
                //Delete = new Button()
                Coordinates = new List<string>{"54.74476483437141, 25.247742481402298",
                    "54.73084081011139, 25.253922291027916"}
                }
            };

            string TrailJson = JsonConvert.SerializeObject(trails);
            //string TrailJson = JsonConvert.SerializeObject(trail1);
            File.WriteAllText(@"Try.json", TrailJson);


            TrailJson = String.Empty;
            TrailJson = File.ReadAllText(@"Try.json");

            List<Trail> TrailString = JsonConvert.DeserializeObject<List<Trail>>(TrailJson);
            //DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(TrailJson, (typeof(DataTable)));
            TrailGridView.DataSource = TrailString;
        }

        private void CreateEntryButton_Click(object sender, EventArgs e)
        {
            Trail tttrail = new Trail
            {
                ID = int.Parse(TrailIdTextBox.Text),
                Name = TrailNameTextbox.Text,
                Length = int.Parse(TrailLengthTextbox.Text),
                //Struct (x,y,name)
                //Atskiri objectai
                //map component
                Coordinates = new List<string>{"54.756950621066615, 25.2863662915624",
                        "54.748480401844894, 25.292460270498772"}
            };
            trails1.Add(tttrail);

            string TrailJson = JsonConvert.SerializeObject(trails1);
            //string TrailJson = JsonConvert.SerializeObject(trail1);
            File.WriteAllText(@"Try.json", TrailJson);


            TrailJson = String.Empty;
            TrailJson = File.ReadAllText(@"Try.json");

            List<Trail> TrailString = JsonConvert.DeserializeObject<List<Trail>>(TrailJson);
            //DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(TrailJson, (typeof(DataTable)));
            TrailGridView.DataSource = TrailString;
        }
    }
}
