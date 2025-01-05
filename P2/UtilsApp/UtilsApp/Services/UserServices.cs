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
            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}/");  

            var response = await client.SendAsync(request);

            var users = JsonConvert.DeserializeObject<List<UserDTO>>(await response.Content.ReadAsStringAsync());

            return users;
        }

        public async Task<UserDTO> GetById(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}/{id}");

            var response = await this.client.SendAsync(request);

            var user = JsonConvert.DeserializeObject<UserDTO>(await response.Content.ReadAsStringAsync());

            return user;
        }

        public async Task<List<UserDTO>> GetByName(string name)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}/GetUserByName/{name}");

            var response = await this.client.SendAsync(request);

            var user = JsonConvert.DeserializeObject<List<UserDTO>>(await response.Content.ReadAsStringAsync());

            return user;
        }

        public async Task<bool> Create(UserDTO user)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"{baseUrl}/");

            var content = JsonConvert.SerializeObject(user);

            request.Content = new StringContent(content, null, "application/json");

            var response = await this.client.SendAsync(request);

            return response.StatusCode == HttpStatusCode.Created;
        }

        public async Task<bool> Update(UserDTO user)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, $"{baseUrl}/");

            var content = JsonConvert.SerializeObject(user);

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

        public async Task<UserDTO> Login(string login, string password)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"{baseUrl}/Login");

            var auth = new AuthDTO
            {
                Login = login,
                Password = password
            };

            var content = JsonConvert.SerializeObject(auth);

            request.Content = new StringContent(content, null, "application/json");

            var response = await this.client.SendAsync(request);

            var user = JsonConvert.DeserializeObject<UserDTO>(await response.Content.ReadAsStringAsync());

            return user;
        }
    }
}
