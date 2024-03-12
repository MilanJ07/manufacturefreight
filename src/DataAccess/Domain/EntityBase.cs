using DataAccess.Interfaces;

namespace DataAccess.Domain
{
    public abstract class EntityBase : IEntity
    {
        public decimal Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
