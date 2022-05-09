using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecifiction : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecifiction()
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);

        }

        public ProductsWithTypesAndBrandsSpecifiction(int id ) 
        : base (x => x.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);

        }
    }
}