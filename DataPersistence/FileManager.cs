using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPersistence
{
    public class FileManager
    {
        //Metodo que retorna una lista de productos tomada del archivo de texto
        public List<Product> ReadProducts()
        {
            
            var products = new List<Product>();
            return products;
        }

        public void SaveProduct( Product product)
        {
            //Guardar el productos en el archivo de texto
        }
    }
}
