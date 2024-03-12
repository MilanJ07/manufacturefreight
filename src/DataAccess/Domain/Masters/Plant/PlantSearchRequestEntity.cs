namespace DataAccess.Domain.Masters.Plant
{
    public class PlantSearchRequestEntity
    {
        public string? PlantCode { get; set; }
        public int Offset { get; set; } = 0;
        public int Count { get; set; } = 50;
    }
}
