using System;

namespace WNVData.Models
{
    public class CovidCount
    {
        public int Id { get; set; }
        public DateTime Day { get; set; }
        public int TotalCases { get; set; }
        public int Confirmed { get; set; }
        public int Recovered { get; set; }
        public int Deaths { get; set; }
        public RegionalCount RegionalCount { get; set; }

        public AgeGroupCount AgeGroupCount { get; set; }
    }
}
