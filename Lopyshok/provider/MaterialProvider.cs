using Lopyshok.models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lopyshok.provider
{
    public class MaterialProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=lopyshok;User Id=postgres;Password=0987");

        public List<Material> GetByProduct(int productId)
        {
            connection.Open();
            List<Material> materials = new List<Material>();
            var materialCommand = new NpgsqlCommand($"SELECT m.id, m.title, m.countinpack, m.unit, m.countinstock, " +
                $"m.mincount, m.cost, mt.title FROM productmaterial pm " +
                $"INNER JOIN material m ON m.id = pm.materialId " +
                $"INNER JOIN materialtype mt ON mt.id = m.materialtypeid " +
                $"WHERE pm.productID ={productId}", connection);
            var matReader = materialCommand.ExecuteReader();

            while (matReader.Read())
            {
                Material material = new Material();
                material.Id = matReader.GetInt32(0);
                material.Title = (string)matReader[1];
                material.CountInPack = matReader.GetInt32(2);
                material.Unit = (string)matReader[3];
                material.CountInStock = matReader.GetDouble(4);
                material.MinCount = matReader.GetDouble(5);
                material.Cost = decimal.Parse(matReader[6].ToString());
                material.MaterialTypeTitle = (string)matReader[7];
                materials.Add(material);
            }
            matReader.Close();
            connection.Close();

            foreach (var material in materials)
            {
                material.CountInCurrentProduct = GetCurrentCount(productId, material.Id);
            }

            return materials;
        }

        public double GetCurrentCount(int productId, int materialId)
        {
            connection.Open();
            var command = new NpgsqlCommand($"select count from productmaterial where productId = {productId} And materialId = {materialId}", connection);
            double count = (double) command.ExecuteScalar();
            connection.Close();
            return count; 
        }

        public Material GetByTitle(string title)
        {
            Material material = new Material();
            connection.Open();
            var materialCommand = new NpgsqlCommand($"SELECT  m.id, m.title, m.countinpack, m.unit, m.countinstock, m.mincount, m.cost, mt.title " +
                $"FROM material m " +
                $"INNER JOIN materialtype mt ON mt.id = m.materialtypeid " +
                $"WHERE m.title LIKE '%{title}%' ", connection);
            var matReader = materialCommand.ExecuteReader();

            while (matReader.Read())
            {
                material.Id = matReader.GetInt32(0);
                material.Title = (string)matReader[1];
                material.CountInPack = matReader.GetInt32(2);
                material.Unit = (string)matReader[3];
                material.CountInStock = matReader.GetDouble(4);
                material.MinCount = matReader.GetDouble(5);
                material.Cost = decimal.Parse(matReader[6].ToString());
                material.MaterialTypeTitle = (string)matReader[7];
            }
            matReader.Close();
            connection.Close();


            return material;
        }

        public List<string> GetAllMaterialsTitles()
        {
            List<string> titles = new List<string>();
            connection.Open();
            var command = new NpgsqlCommand("Select title From material", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                titles.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
            return titles;
        }
    }
}
