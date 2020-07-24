using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace BlazorLeaflet.Samples.Data
{
    public class HotelServices
    {
        private HotelDbContext dbContext;
        public HotelServices(HotelDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<Hotels>> GetHotelAsync()
        {
            return await dbContext.Hotel.ToListAsync();
        }
        public async Task<Hotels> AddHotelAsync(Hotels hotel)
        {
            try
            {
                dbContext.Hotel.Add(hotel);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return hotel;
        }
        public async Task<Hotels> UpdateHotelAsync(Hotels hotel)
        {
            try
            {
                var hotelExist = dbContext.Hotel.FirstOrDefault(p => p.ID == hotel.ID);
                if (hotelExist != null)
                {
                    dbContext.Update(hotel);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return hotel;
        }
        public async Task DeleteHotelAsync(Hotels hotel)
        {
            try
            {
                dbContext.Hotel.Remove(hotel);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
