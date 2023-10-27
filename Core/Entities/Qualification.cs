using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public abstract class Qualification
    {
        [Key]
        public int Id { get; init; }
        public int? SalesProgramId { get; set; }

        public SaleProgram? SaleProgram { get; set; }
    }
}
