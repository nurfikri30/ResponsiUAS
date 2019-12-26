using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ProductCatalog.Model.Entity;


namespace ProductCatalog.Model.Repository
{
    public class ProductRestApiRepository
    {
        /// <summary>
        /// Method untuk pencarian data product berdasarkan nama product
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        public List<Product> ReadByProductName(string productName)
        {
            string baseUrl = "http://latihan.buatdevelop.com:5000/";
            string endpoint = "api/product?product_Name=" + productName;

            // membuat objek rest client
            var client = new RestClient(baseUrl);

            // membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            // kirim request ke server
            var response = client.Execute<List<Product>>(request);

            return response.Data;
        }

        /// <summary>
        /// Method untuk pencarian data product berdasarkan category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public List<Product> ReadByCategory(string category)
        {
            string baseUrl = "http://latihan.buatdevelop.com:5000/";
            string endpoint = "api/product?category=" + category;

            // membuat objek rest client
            var client = new RestClient(baseUrl);

            // membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            // kirim request ke server
            var response = client.Execute<List<Product>>(request);

            return response.Data;
        }

        /// <summary>
        /// Method untuk pencarian data product berdasarkan nama supplier
        /// </summary>
        /// <param name="supplierName"></param>
        /// <returns></returns>
        public List<Product> ReadBySupplier(string supplierName)
        {
            string baseUrl = "http://latihan.buatdevelop.com:5000/";
            string endpoint = "api/product?supplier=" + supplierName;

            // membuat objek rest client
            var client = new RestClient(baseUrl);

            // membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            // kirim request ke server
            var response = client.Execute<List<Product>>(request);

            return response.Data;
        }
    }
}
