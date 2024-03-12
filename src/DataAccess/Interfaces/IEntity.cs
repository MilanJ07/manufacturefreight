namespace DataAccess.Interfaces
{
    public interface IEntity
    {
        decimal Id { get; set; }
        string? CreatedBy { get; set; }
        DateTime? CreatedOn { get; set; }
        string? ModifiedBy { get; set; }
        DateTime? ModifiedOn { get; set; }
    }
}
