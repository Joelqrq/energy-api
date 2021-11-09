using EnergyAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace EnergyAPI.Services
{
    public class NotificationService
    {
        private readonly HttpClient client;

        public NotificationService(HttpClient client)
        {
            this.client = client;
        }

        public async void BroadcastToClient(object sender, EntityStateChangedEventArgs e)
        {
            var energyGeneration = e.Entry.Entity as EnergyRecord;

            var content = new StringContent(JsonSerializer.Serialize(new
            {
                price = energyGeneration.Price
            }));

            await client.PostAsync("notification", content);
        }
    }
}
