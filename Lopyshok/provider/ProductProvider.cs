using Lopyshok.models;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Lopyshok.provider
{
    public class ProductProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=lopyshok;User Id=postgres;Password=0987");
        private MaterialProvider materialProvider = new MaterialProvider();

        public List<Product> getAllProducts()
        {
            List<Product> products = new List<Product>();

            connection.Open();
            var command = new NpgsqlCommand("SELECT p.id, p.title, p.description, p.articlenumber, pt.title, " +
                "p.image, p.productionworkshopnumber, p.productionpersoncount, p.mincostforagent FROM product p " +
                "INNER JOIN producttype pt ON pt.id = p.producttypeid", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.Id = reader.GetInt32(0);
                product.Title = (string) reader[1];
                product.Description = (string)reader[2];
                product.Article = (string)reader[3];
                product.ProductTypeName = (string)reader[4];
                product.ImagePath = (string)reader[5];
                product.WorkShopNumber = reader.GetInt32(6);
                product.CountOfPeople = reader.GetInt32(7);
                product.MinimumCost = decimal.Parse(reader[8].ToString());
                products.Add(product);
            }
            reader.Close();

            foreach (Product product1 in products)
            {
                List<Material> materials = materialProvider.GetByProduct(product1.Id);

                product1.Materials = materials;
            }
            connection.Close();

            return products;
        }

        public List<string> GetAllProductTypes()
        {
            connection.Open();
            var command = new NpgsqlCommand("select title from producttype", connection);
            var reader = command.ExecuteReader();

            List<string> types = new List<string>();

            while (reader.Read())
            {
                types.Add((string)reader["title"]);
            }

            reader.Close();
            connection.Close();

            return types;
        }

        public bool existsByArticle(string article)
        {
            connection.Open();
            var command = new NpgsqlCommand($"SELECT EXISTS (SELECT 1 FROM product WHERE articlenumber = '%{article}%')", connection);
            bool exists = (bool) command.ExecuteScalar();
            connection.Close();
            return exists;
        }

        public void ChangeCost(int productId, decimal cost)
        {
            connection.Open();
            var command = new NpgsqlCommand($"UPDATE product SET mincostforagent = {cost} WHERE id = {productId}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public bool isSoldLastMonth(int productId)
        {
            connection.Open();
            var command = new NpgsqlCommand("SELECT EXISTS (" +
                "SELECT 1 " +
                "FROM productsale " +
                $"WHERE productid = {productId} " +
                $"AND DATE_PART('month', saledate) = DATE_PART('month', CURRENT_DATE) " +
                $"AND DATE_PART('year', saledate) = DATE_PART('year', CURRENT_DATE))", connection);
            bool isSold = (bool) command.ExecuteScalar();
            connection.Close();
            return isSold;
        }

        public void DeleteProduct(int productId)
        {
            connection.Open();
            var command = new NpgsqlCommand($"DELETE FROM product WHERE id = {productId}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateProduct(Product product)
        {
            connection.Open();
            var command = new NpgsqlCommand($"UPDATE product SET title = '{product.Title}', producttypeid = {GetTypeId(product.ProductTypeName)}, articleNumber = '{product.Article}', " +
                $"description = '{product.Description}', image = '{product.ImagePath}', productionpersoncount = {product.CountOfPeople}, " +
                $"productionworkshopnumber = {product.WorkShopNumber}, mincostforagent = {product.MinimumCost} " +
                $"WHERE id = {product.Id}", connection);
            command.ExecuteNonQuery();
            ClearProductMaterials(product.Id);
            InsertProductMaterials(product.Id, product.Materials);
            connection.Close();
        }

        public void InsertProduct(Product product)
        {
            connection.Open();
            var command = new NpgsqlCommand($"INSERT INTO product VALUES (default, '{product.Title}', {GetTypeId(product.ProductTypeName)}, '{product.Article}', " +
                $"'{product.Description}', '{product.ImagePath}', {product.CountOfPeople}, {product.WorkShopNumber}, {product.MinimumCost}) RETURNING id", connection);
            var id = (int) command.ExecuteScalar();
            InsertProductMaterials(id, product.Materials);
            connection.Close();
        }

        public int GetTypeId(string title)
        {
            var command = new NpgsqlCommand($"select id from producttype WHERE title LIKE '%{title}%'", connection);
            var id = (int) command.ExecuteScalar();
            return id;
        }

        private void InsertProductMaterials(int productId, List<Material> materials)
        {
            foreach (Material material in materials)
            {
                var command = new NpgsqlCommand($"INSERT INTO productMaterial VALUES ({productId}, {material.Id}, {material.CountInCurrentProduct})", connection);
                command.ExecuteNonQuery();
            }
        }

        private void ClearProductMaterials(int productId)
        {
            var command = new NpgsqlCommand($"DELETE FROM productMaterial where productid = {productId}", connection);
            command.ExecuteNonQuery();
        }
    }
}
