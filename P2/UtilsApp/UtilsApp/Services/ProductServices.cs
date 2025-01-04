using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsApp.DTOs;
using System.Net;

namespace UtilsApp.Services
{
    public class ProductServices
    {
        private string baseUrl;
        private HttpClient client;

        public ProductServices(string baseUrl, HttpClient client)
        {
            this.baseUrl = baseUrl;
            this.client = client;
        }

        public async Task<List<ProductDTO>> GetAll()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}/");  

            var response = await this.client.SendAsync(request);

            var products = JsonConvert.DeserializeObject<List<ProductDTO>>(await response.Content.ReadAsStringAsync());

            return products;
        }

        public async Task<ProductDTO> GetById(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}/{id}");

            var response = await this.client.SendAsync(request);

            var product = JsonConvert.DeserializeObject<ProductDTO>(await response.Content.ReadAsStringAsync());

            return product;
        }

        public async Task<bool> Create(ProductDTO product)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"{baseUrl}/");

            var content = JsonConvert.SerializeObject(product);

            request.Content = new StringContent(content, null, "application/json");

            var response = await this.client.SendAsync(request);

            return response.StatusCode == HttpStatusCode.Created;
        }

        public async Task<bool> Update(ProductDTO product)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, $"{baseUrl}");

            var content = JsonConvert.SerializeObject(product);

            request.Content = new StringContent(content, null, "application/json");

            var response = await this.client.SendAsync(request);

            return response.StatusCode == HttpStatusCode.OK;
        }

        public async Task<bool> Delete(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{baseUrl}/{id}");

            var response = await this.client.SendAsync(request);

            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}
