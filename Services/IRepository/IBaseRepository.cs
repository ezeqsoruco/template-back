namespace Services
{
    public interface IBaseRepository
    {
        Task Save(CancellationToken cancellationToken);
    }
}