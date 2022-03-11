using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.data.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        Product GetByIdWithCategories(int id);
        Product GetProductDetails(string url);
        List<Product> GetProductByCategory(string name, int page,int pageSize);
        List<Product> GetSearchResult(string searchstring);
        List<Product> GetHomePageProducts();
        void Update(Product entity, int[] categoryIds);
        int GetCountByCategory(string category);
       
    }
}