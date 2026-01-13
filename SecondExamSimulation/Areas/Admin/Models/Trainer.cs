using System.Net.Http.Headers;
using SecondExamSimulation.Areas.Admin.Models.Common;

namespace SecondExamSimulation.Areas.Admin.Models
{
    public class Trainer : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty ;
        public string ImagePath { get; set; } = string.Empty;

        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;
    }
}
