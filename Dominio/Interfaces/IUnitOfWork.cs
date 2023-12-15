namespace Dominio.Interfaces;
public interface IUnitOfWork
{
    IRol Rols { get; }
    IUser Users { get; }
    ICategory Categories { get; }
    IOption Options { get; }
    IOrder Orders { get; }
    IOrderDetail OrderDetails { get; }
    IProduct Products { get; }
    IProductCategory ProductCategories { get; }
    IRefreshToken RefreshTokens { get; }

    Task<int> SaveAsync();
}
