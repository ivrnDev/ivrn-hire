namespace api.Domain
{
    public interface IBaseModel
    {
        string Id { get; set; }
        string CreatedAt { get; set; }
        string UpdatedAt { get; set; }
    }
}