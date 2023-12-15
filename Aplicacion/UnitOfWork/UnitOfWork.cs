using Aplicacion.Repository;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApiContext _context;

    private RolRepository _Rol;
    private UserRepository _usuarios;

    public UnitOfWork(ApiContext context)
    {
        _context = context;
    }
    
    public IRol Rols
    {
        get{
            if(_Rol== null)
            {
                _Rol= new RolRepository(_context);
            }
            return _Rol;
        }
    }
    
    public IUser Users
    {
        get{
            if(_usuarios== null)
            {
                _usuarios= new UserRepository(_context);
            }
            return _usuarios;
        }
    }



    private ICategory _Category;
    public ICategory Categories
    {
        get { 
            _Category ??= new CategoryRepository(_context);
                return _Category;
            }
    }

    private IOption _Option;
    public IOption Options
    {
        get { 
            _Option ??= new OptionRepository(_context);
                return _Option;
            }
    }

    private IOrder _Order;
    public IOrder Orders
    {
        get { 
            _Order ??= new OrderRepository(_context);
                return _Order;
            }
    }

    private IOrderDetail _OrderDetail;
    public IOrderDetail OrderDetails
    {
        get { 
            _OrderDetail ??= new OrderDetailRepository(_context);
                return _OrderDetail;
            }
    }

    private IProduct _Product;
    public IProduct Products
    {
        get { 
            _Product ??= new ProductRepository(_context);
                return _Product;
            }
    }

    private IProductOption _ProductOption;
    public IProductOption ProductOptions
    {
        get { 
            _ProductOption ??= new ProductOptionRepository(_context);
                return _ProductOption;
            }
    }

    private IProductCategory _ProductCategory;
    public IProductCategory ProductCategories
    {
        get { 
            _ProductCategory ??= new ProductCategoryRepository(_context);
                return _ProductCategory;
            }
    }

    private IRefreshToken _RefreshToken;
    public IRefreshToken RefreshTokens
    {
        get { 
            _RefreshToken ??= new RefreshTokenRepository(_context);
                return _RefreshToken;
            }
    }

    public void Dispose()
    {
        _context.Dispose();
    }
    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
