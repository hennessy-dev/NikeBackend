namespace Dominio.Interfaces;
public interface IUnitOfWork
{
    IRol Rols { get; }
    IUser Users { get; }
    

    Task<int> SaveAsync();
}
