using CoreAPIwithTableStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPIwithTableStorage.Services
{
  public  interface ITableStorageService
    {
        Task<GroceryItemEntity> RetrieveAsync(string category, string id);
        Task<GroceryItemEntity> InsertOrMergeAsync(GroceryItemEntity entity);
        Task<GroceryItemEntity> DeleteAsync(GroceryItemEntity entity);
    }
}
