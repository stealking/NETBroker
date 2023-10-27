using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class CommissionConfigurationType
    {
        public CommissionConfigurationType(int id, string? name)
        {
            Id = id;
            Name = name;
        }

        [Key]
        public int Id { get; init; }
        [Required]
        public string? Name { get; set; }

        public ICollection<CommisionType>? CommisionTypes { get; set; }
    }
}
