using System;
using System.Net;
using System.Collections.Generic;
//using TapFitness.Models;

using Newtonsoft.Json;
namespace TapFitness.Models
{
	public static class ExerciseItemModel
	{
		public partial class Exercise
		{
			[JsonProperty("count")]
			public long Count { get; set; }

			[JsonProperty("next")]
			public object Next { get; set; }

			[JsonProperty("previous")]
			public object Previous { get; set; }

			[JsonProperty("results")]
			public Result[] Results { get; set; }
		}

		public partial class Result
		{
			[JsonProperty("date")]
			public string Date { get; set; }

			[JsonProperty("id")]
			public long Id { get; set; }

			[JsonProperty("weight")]
			public string Weight { get; set; }
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
