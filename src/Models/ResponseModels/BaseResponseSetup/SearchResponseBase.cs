namespace Models.ResponseModels.BaseResponseSetup
{
    public abstract class SearchResponseBase<TEntity> : ResponseMessage
    {
        public List<TEntity> Results { get; set; } = new List<TEntity>();
        public PagingModel Paging { get; set; } = new PagingModel();
    }
}
