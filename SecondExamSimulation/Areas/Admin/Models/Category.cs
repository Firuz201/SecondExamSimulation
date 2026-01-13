using SecondExamSimulation.Areas.Admin.Models.Common;

namespace SecondExamSimulation.Areas.Admin.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = null!;
        public ICollection<Trainer> Trainers { get; set; } = [];
    }
}
