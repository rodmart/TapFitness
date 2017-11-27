using System;

using Xamarin.Forms;
using System.Net;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace TapFitness.Models
{
    public class ExerciseItemModels : ContentPage
    {
        //public ExerciseItemModels()
        //{
        //    Content = new StackLayout
        //    {
        //        Children = {
        //            new Label { Text = "Hello ContentPage" }
        //        }
        //    };
        //}
        // To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
        //
        //    using QuickType;
        //
        //    var data = GettingStarted.FromJson(jsonString);


        public partial class GettingStarted
        {
            [JsonProperty("greeting")]
            public string Greeting { get; set; }

            [JsonProperty("instructions")]
            public string[] Instructions { get; set; }
        }

        public partial class GettingStarted
        {
            public static GettingStarted FromJson(string json) => JsonConvert.DeserializeObject<GettingStarted>(json, Converter.Settings);
        }

        public static class Serialize
        {
            public static string ToJson(this GettingStarted self) => JsonConvert.SerializeObject(self, Converter.Settings);
        }

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


