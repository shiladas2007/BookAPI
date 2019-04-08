using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAlertRobot.Models
{
    class BookFromCatalog
    {
        [JsonProperty("BookId")]
        public int BookId { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Edition")]
        public int Edition { get; set; }

        [JsonProperty("ISBN")]
        public string ISBN { get; set; }

        [JsonProperty("Publisher")]
        public string Publisher { get; set; }

        [JsonProperty("Price")]
        public double Price { get; set; }

        [JsonProperty("Condition")]
        public string Condition;

        [JsonProperty("StudyAreaName")]
        public string StudyAreaName;

        [JsonProperty("InstitutionBranchName")]
        public string InstitutionBranchName;


    }
}
