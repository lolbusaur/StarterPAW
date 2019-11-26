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

        public List<string> GetTimes()
        {
            IEnumerable<string> query = from Item item in items select item.Time;
            List<string> collec = query.ToList();
            return collec;
        }

        public List<string> CalcAve(List<string> list)
        {
            int[,] ParseArr = new int[list.Count, 3];

            //Splits the string into 3 parts, then parses each string array to integers and stores them in an array
            for(int i = 0; i < list.Count; i++)
            {
                string s = list[i];
                string[] TempString = s.Split(':');
                for(int j = 0; j < 3; j++)
                {
                    ParseArr[i, j] = Int32.Parse(TempString[j]);
                }
            }

            //Computes the average hour, minute, and second then store in an array
            int[] AveTime = new int[3];
            for(int i = 0; i < 3; i++)
            {
                int ColumnTotal = 0;
                for(int j = 0; j < list.Count; j++)
                {
                    ColumnTotal += ParseArr[i,j];
                }
                AveTime[i] = (ColumnTotal/list.Count);
            }

            //Concatenate the time into readable format, then store in list and return list
            string ConcatTime = "";
            ConcatTime += AveTime[0].ToString() + ":" + AveTime[1].ToString() + ":" + AveTime[2].ToString();
            List<string> ReturnList = new List<string>
            {
                ConcatTime
            };

            return ReturnList;
        }
    }
}