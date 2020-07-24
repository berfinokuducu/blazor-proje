using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorLeaflet.Samples.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options)
         : base(options)
        {
        }
        public DbSet<Hotels> Hotel { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotels>().HasData(GetHotel());
            base.OnModelCreating(modelBuilder);
        }
        private List<Hotels> GetHotel()
        {
            return new List<Hotels>
                {
        new Hotels { ID = 1,image="https://imagessl.etstur.com/files/images/hotelImages/integration/TR/94131/l/s5cu25fseia0a4ruyzif.jpg", name = "Kolin Hotel", phone = "+902862180808",city="Çanakkale",district="Merkez",street="Atatürk Caddesi",No=2,activity_area="Açık ve Kapalı Havuz,Spa,Restoran",Longitude=26.406563, Latitude=40.112759},
        new Hotels { ID = 2,image="https://imagessl.etstur.com/files/images/hotelImages/integration/TR/51416/l/lu0axr1mij2jnljgrqzt.jpg", name=  "Büyük Truva Hotel", phone = "+902862171024",city="Çanakkale",district="Merkez",street="Mehmet Akif Ersoy Cd.",No=2,activity_area="Restoran", Longitude=26.407925, Latitude=40.153368},
        new Hotels { ID = 3,image="https://imagessl.etstur.com/files/images/hotelImages/integration/TR/91088/l/mfih5nuhidb7r7ifn4ow.jpg", name = "Grand Ece Hotel", phone = "+902862139345",city="Çanakkale",district="Merkez",street="Değirmenlik 1.Çıkmazı Sk.",No=4,activity_area="",Longitude= 26.404780, Latitude= 40.149660},
        
    };
        }

    }
    
}
