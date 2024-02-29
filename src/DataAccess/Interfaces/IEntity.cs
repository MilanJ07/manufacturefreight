namespace DataAccess.Interfaces
{
    public interface IEntity
    {
        Guid Id { get; set; }
        Guid? CreatedBy { get; set; }
        DateTime? CreatedOn { get; set; }
        Guid? ModifiedBy { get; set; }
        DateTime? ModifiedOn { get; set; }
    }
}
