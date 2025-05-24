using DataPersistence;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProductManager
    {
        public void AddProduct(Product product)
        {
            Validate(product);
        }
        public List<ProductManager> GetProducts()
        {
            var products = new List<ProductManager>();
            return products;
        }
        public static void Validate(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            if (product.price <= 0)
                throw new ArgumentException("El precio debe ser mayor a 0.");

            if (product.stock < 0)
                throw new ArgumentException("El stock no puede ser negativo.");

            if (string.IsNullOrWhiteSpace(product.name))
                throw new ArgumentException("El nombre no debe estar vacío.");

            var fm = new FileManager();
            fm.SaveProduct(product);

        }

    }
}
