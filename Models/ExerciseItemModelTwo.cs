using System;
using System.Net;
using System.Collections.Generic;
//using TapFitness.Models;

using Newtonsoft.Json;
namespace TapFitness.Models
{
    public static class ExerciseItemModelTwo
    {
        public partial class ExerciseTwo
        {
            [JsonProperty("count")]
            public long Count { get; set; }

            [JsonProperty("next")]
            public string Next { get; set; }

            [JsonProperty("previous")]
            public object Previous { get; set; }

           // [JsonProperty("results")]
           // public Result[] Results { get; set; }
        }

        public partial class Result
        {
          //  [JsonProperty("category")]
          //  public Category Category { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

           // [JsonProperty("equipment")]
           // public Category[] Equipment { get; set; }

           // [JsonProperty("muscles")]
           // public Muscle[] Muscles { get; set; }

            [JsonProperty("muscles_secondary")]
            public Muscle[] MusclesSecondary { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public partial class Muscle
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("is_front")]
            public bool IsFront { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public partial class Category
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public partial class ExerciseTwo
        {
            
            public static ExerciseTwo FromJson(string json) => JsonConvert.DeserializeObject<ExerciseTwo>(json, Converter.Settings);
        }

        //public static class Serialize
        //{
           
        public static string ToJson(this ExerciseTwo self) => JsonConvert.SerializeObject(self, Converter.Settings);
		
        //}

        public class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }

    }
}

