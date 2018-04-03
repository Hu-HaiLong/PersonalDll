using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

namespace HHL
{
    public class JsonManager : SingleTon<JsonManager>
    {

        public List<T> Json2List<T>(T t, string jsonName) where T : class
        {

            string jsonText = ((TextAsset)Resources.Load(@"json\" + jsonName)).text;

            List<T> list = JsonConvert.DeserializeObject<List<T>>(jsonText);

            return list;

        }

        public List<T> Json2List<T>(string jsonName) where T : class
        {

            string jsonText = ((TextAsset)Resources.Load(@"json\" + jsonName)).text;

            List<T> list = JsonConvert.DeserializeObject<List<T>>(jsonText);

            return list;

        }

        public string JsonObj2String<T>(T t)
        {
            return JsonConvert.SerializeObject(t);
        }


        public T JsonString2Obj<T>(string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
    }
}
