using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPersistence
{
    public class FileManager
    {
        private readonly string path = "productos.txt";

        //Metodo que retorna una lista de productos tomada del archivo de texto
        public List<Product> ReadProducts()
        {
            var productos = new List<Product>();

            if (!File.Exists(path))
                return productos;

            foreach (var linea in File.ReadAllLines(path))
            {
                var datos = linea.Split(',');
                productos.Add(new Product
                {
                    ID = int.Parse(datos[0]),
                    name = datos[1],
                    price = double.Parse(datos[2]),
                    stock = int.Parse(datos[3])
                });
            }

            return productos;
        }

        public void SaveProduct( Product product)
        {
            //Guardar el productos en el archivo de texto
            var linea = $"{product.ID},{product.name},{product.price},{product.stock}";
            File.AppendAllLines(path, new[] { linea });
        }
    }
}
