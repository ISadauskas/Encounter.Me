using EncounterMeWF;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;



namespace BusinessLogic
{
    public class TrailJson
    {
        string TrailListJson;
        BindingList<Trail> TrailList = new BindingList<Trail>();

        public void JsonWrite(BindingList<Trail> TrailList)
        {
            TrailListJson = JsonConvert.SerializeObject(TrailList);
            TrailList = JsonConvert.DeserializeObject<BindingList<Trail>>(TrailListJson);
            File.WriteAllText(@"Try.json", TrailListJson);
        }

        public BindingList<Trail> JsonRead()
        {
            TrailListJson = File.ReadAllText(@"Try.json");
            TrailList = JsonConvert.DeserializeObject<BindingList<Trail>>(TrailListJson);
            return TrailList;
        }

    }
}
