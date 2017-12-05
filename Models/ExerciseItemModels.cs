using System;

using Xamarin.Forms;
using System.Net;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace TapFitness.Models
{
    public static class ExerciseItemModels
    {
        public class ExerciseItem
        {
            public string workout { get; set; }
            public string workoutsession { get; set; }
            public string schedulestep { get; set; }
            public string schedule { get; set; }
            public string language { get; set; }
            public string daysofweek { get; set; }
            public string license { get; set; }

            public string exerciseinfo { get; set; }
            public string exercise { get; set; }
            public string equipment { get; set; }
            public string exercisecategory { get; set; }
            public string exerciseimage { get; set; }
            public string exercisecomment { get; set; }
            public string muscle { get; set; }
            public string ingredient { get; set; }
            public string weightunit { get; set; }
            public string ingredientweightunit { get; set; }
            public string nutritionplan { get; set; }
            public string meal { get; set; }
            public string mealitem { get; set; }
            public string weightentry { get; set; }
}
    }

}


