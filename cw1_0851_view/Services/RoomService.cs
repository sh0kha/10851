using cw1_0851_view.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace cw1_0851_view.Services
{
    public class RoomService
    {
        //private string host = "http://ec2-3-144-87-173.us-east-2.compute.amazonaws.com";//"http://ec2-18-218-159-58.us-east-2.compute.amazonaws.com";
        private string host = "https://localhost:7087";
        public async void Update(Room rom, int id)
        {
            var client = new HttpClient();

            var json = JsonConvert.SerializeObject(rom);

            var data = new StringContent(json, Encoding.UTF8, "application/json");
            
            await client.PutAsync(host + "/api/Rooms/"+id, data);
        }

        public async void Create(Room rom)
        {
            var client = new HttpClient();
            
            var json = JsonConvert.SerializeObject(rom);
            
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            await client.PostAsync(host + "/api/Rooms", data);
        }
        public async Task<List<Room>> FindAll()
        {

            var client = new HttpClient();
            var response = await client.GetAsync(host + "/api/Rooms");

            
            var content = await response.Content.ReadAsStringAsync();
            var rooms = JsonConvert.DeserializeObject<List<Room>>(content);
            
            return rooms;
        }

        public async Task<Room> FindOne(int id)
        {
            Room room = new Room();
            
            var client = new HttpClient();
            var response = await client.GetAsync(host + "/api/Rooms/"+id);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                room = JsonConvert.DeserializeObject<Room>(content);
            }
            return room;
        }

        public async void Delete(int id)
        {
            var client = new HttpClient();
            await client.DeleteAsync(host + "/api/Rooms/"+id);
        }
    }
}
