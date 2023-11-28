using System.ComponentModel.DataAnnotations;

namespace testTask1.Models
{
    public class Footballer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Sex { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; } = DateTime.Now;
        public string TeamName { get; set; }
        public string Country { get; set; }
    }
}
