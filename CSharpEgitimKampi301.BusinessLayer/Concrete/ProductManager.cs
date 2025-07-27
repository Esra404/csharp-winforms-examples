using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

      
        public List<object> TGetProductsWithCategory()
        {
          return _productDal.GetProductsWithCategory();
        }

        void IGenericService<Product>.TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

         List<Product> IGenericService<Product>.TGetAll()
        {
            return _productDal.GetAll();
        }

        Product IGenericService<Product>.TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        void IGenericService<Product>.TInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        void IGenericService<Product>.TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
