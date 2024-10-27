using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TASK6
{
    public class Book
    {

        [JsonIgnore]
        public int PublishingHouseId { get; set; }

        [JsonPropertyName("Title")]
        public string Name { get; set; }
        public PublishingHouse PublishingHouse { get; set; }
        

       
    }
}
