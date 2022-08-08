using System;
using System.Threading.Tasks;

namespace shopapp.data.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
         IProductRepository Products {get;}
         ICardRepository Cards{get;}
         ICategoryRepository Categories {get;}
         IOrderRepository Orders{get;}
         void Save();
         Task<int> SaveAsync();
    }
}