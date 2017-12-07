using System;

using Xamarin.Forms;
using System.Net;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace TapFitness.Models
{
    public static class ExerciseItemModels
    {
        // To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
        //
        //    using QuickType;
        //
        //    var data = Exercise.FromJson(jsonString);
        //


        public partial class Exercise
        {
            [JsonProperty("count")]
            public long Count { get; set; }

            [JsonProperty("next")]
            public string Next { get; set; }

            [JsonProperty("previous")]
            public object Previous { get; set; }

            [JsonProperty("results")]
            public Result[] Results { get; set; }
        }

        public partial class Result
        {
            [JsonProperty("category")]
            public Category Category { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("equipment")]
            public Category[] Equipment { get; set; }

            [JsonProperty("muscles")]
            public Muscle[] Muscles { get; set; }

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

        public partial class Exercise
        {
            public static Exercise FromJson(string json) => JsonConvert.DeserializeObject<Exercise>(json, Converter.Settings);
        }

       
            public static string ToJson(this Exercise self) => JsonConvert.SerializeObject(self, Converter.Settings);


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


