using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UtilsApp.DTOs;

namespace UtilsApp.Services
{
    public class UserServices
    {
        private string baseUrl;
        private HttpClient client;

        public UserServices(string baseUrl, HttpClient client)
        {
            this.baseUrl = baseUrl;
            this.client = client;
        }

        public async Task<List<UserDTO>> GetAll()
        {
            this.client.BaseAddress = new Uri($"{baseUrl}/");

            var request = new HttpRequestMessage(HttpMethod.Get, this.client.BaseAddress);  

            var response = await client.SendAsync(request);

            var users = JsonConvert.DeserializeObject<List<UserDTO>>(await response.Content.ReadAsStringAsync());

            return users;
        }

        public async Task<UserDTO> GetById(int id)
        {
            this.client.BaseAddress = new Uri($"{baseUrl}/{id}");

            var request = new HttpRequestMessage(HttpMethod.Get, this.client.BaseAddress);

            var response = await this.client.SendAsync(request);

            var user = JsonConvert.DeserializeObject<UserDTO>(await response.Content.ReadAsStringAsync());

            return user;
        }

        public async Task<List<UserDTO>> GetByName(string name)
        {
            this.client.BaseAddress = new Uri($"{baseUrl}/GetUserByName/{name}");

            var request = new HttpRequestMessage(HttpMethod.Get, this.client.BaseAddress);

            var response = await this.client.SendAsync(request);

            var user = JsonConvert.DeserializeObject<List<UserDTO>>(await response.Content.ReadAsStringAsync());

            return user;
        }

        public async Task<bool> Create(UserDTO user)
        {
            this.client.BaseAddress = new Uri($"{baseUrl}/");

            var request = new HttpRequestMessage(HttpMethod.Post, this.client.BaseAddress);

            var content = JsonConvert.SerializeObject(user);

            request.Content = new StringContent(content, null, "application/json");

            var response = await this.client.SendAsync(request);

            return response.StatusCode == HttpStatusCode.Created;
        }

        public async Task<bool> Update(UserDTO user)
        {
            this.client.BaseAddress = new Uri($"{baseUrl}/");

            var request = new HttpRequestMessage(HttpMethod.Put, this.client.BaseAddress);

            var content = JsonConvert.SerializeObject(user);

            request.Content = new StringContent(content, null, "application/json");

            var response = await this.client.SendAsync(request);

            return response.StatusCode == HttpStatusCode.OK;
        }

        public async Task<bool> Delete(int id)
        {
            this.client.BaseAddress = new Uri($"{baseUrl}/{id}");

            var request = new HttpRequestMessage(HttpMethod.Delete, this.client.BaseAddress);

            var response = await this.client.SendAsync(request);

            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}
