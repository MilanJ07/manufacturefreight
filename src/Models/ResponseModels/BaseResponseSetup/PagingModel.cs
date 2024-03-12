namespace Models.ResponseModels.BaseResponseSetup
{
    public class PagingModel
    {
        public string? NextOffset { get; set; }
        public int Results { get; set; }
        public long Total { get; set; }
    }
}
