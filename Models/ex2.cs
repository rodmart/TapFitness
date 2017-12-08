
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

			[JsonProperty("results")]
			public Result[] Results { get; set; }
		}

		public partial class Result
		{
			[JsonProperty("category")]
			public long Category { get; set; }

			[JsonProperty("creation_date")]
			public string CreationDate { get; set; }

			[JsonProperty("description")]
			public string Description { get; set; }

			[JsonProperty("equipment")]
			public long[] Equipment { get; set; }

			[JsonProperty("id")]
			public long Id { get; set; }

			[JsonProperty("language")]
			public long Language { get; set; }

			[JsonProperty("license")]
			public long License { get; set; }

			[JsonProperty("license_author")]
			public string LicenseAuthor { get; set; }

			[JsonProperty("muscles")]
			public long[] Muscles { get; set; }

			[JsonProperty("muscles_secondary")]
			public long[] MusclesSecondary { get; set; }

			[JsonProperty("name")]
			public string Name { get; set; }

			[JsonProperty("name_original")]
			public string NameOriginal { get; set; }

			[JsonProperty("status")]
			public string Status { get; set; }

			[JsonProperty("uuid")]
			public string Uuid { get; set; }
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

