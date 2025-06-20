using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Helpers;
using api.Models;

namespace api.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllStocksAsync(QueryObject query);
        Task<Stock?> GetStockByIdAsync(int id); // Can be null hence the '?'
        Task<Stock?> GetStockBySymbolAsync(string symbol);
        Task<Stock> CreateStockAsync(Stock stockModel);
        Task<Stock?> UpdateStockAsync(int id, UpdateStockRequestDto stockDto);
        Task<Stock?> DeleteStockAsync(int id);
        Task<bool> StockExists(int id);
    }
}