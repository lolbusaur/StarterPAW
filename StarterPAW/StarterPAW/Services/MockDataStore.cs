using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarterPAW.Models;

namespace StarterPAW.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Time = "12:51:21", Date = "12/12/12"},
                new Item { Id = Guid.NewGuid().ToString(), Time = "23:17:05", Date = "12/13/12"},
                new Item { Id = Guid.NewGuid().ToString(), Time = "01:48:16", Date = "12/14/12"},
                new Item { Id = Guid.NewGuid().ToString(), Time = "08:33:28", Date = "12/15/12"},
                new Item { Id = Guid.NewGuid().ToString(), Time = "12:06:14", Date = "12/16/12"},
                new Item { Id = Guid.NewGuid().ToString(), Time = "18:27:51", Date = "12/17/12"}
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }

    }
}