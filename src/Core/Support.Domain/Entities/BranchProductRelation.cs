using System.ComponentModel.DataAnnotations;

namespace Support.Domain.Entities
{
    public class BranchProductRelation
    {
        [Key]
        public int PKBranchProductRelationId { get; set; }
        public int FKBranchId { get; set; }
        public int FKProductId { get; set; }
    }
}
