using EncounterMeWF;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;



namespace BusinessLogic
{
    public class Json
    {
        string TrailJson;
        BindingList<Trail> TrailList = new BindingList<Trail>();

        public void JsonWrite(BindingList<Trail> TrailList)
        {
            TrailJson = JsonConvert.SerializeObject(TrailList);
            TrailList = JsonConvert.DeserializeObject<BindingList<Trail>>(TrailJson);
            File.WriteAllText(@"Trails.json", TrailJson);
        }

        public BindingList<Trail> JsonRead()
        {
            TrailJson = File.ReadAllText(@"Trails.json");
            TrailList = JsonConvert.DeserializeObject<BindingList<Trail>>(TrailJson);
            return TrailList;
        }

    }
}
