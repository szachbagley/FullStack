namespace FullStackAPI.Data
{
    public interface IFoodRepository
    {
        IEnumerable<MarriottFood> Foods { get; }
    }
}
