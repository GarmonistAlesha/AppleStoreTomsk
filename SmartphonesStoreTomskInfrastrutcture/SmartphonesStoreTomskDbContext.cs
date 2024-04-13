using Microsoft.EntityFrameworkCore;
using SmartphonesStoreTomskInfrastrutcture.Entites;

namespace SmartphonesStoreTomskInfrastrutcture
{
    public class SmartphonesStoreTomskDbContext : DbContext 
    {
        private readonly object Apple;

        public SmartphonesStoreTomskDbContext (DbContextOptions<SmartphonesStoreTomskDbContext> options)
            : base(options) 
        { 
        }

        /// <summary>
        /// Таблица для смартфонов Apple
        /// </summary>
        public DbSet<AppleEntity> Apples {  get; set; }
        /// <summary>
        /// Таблица для смартфонов Huawei
        /// </summary>
        public DbSet<HuaweiEntity> Huawei { get; set;}
        /// <summary>
        /// Таблица для смартфонов Samsung
        /// </summary>
        public DbSet<SamsungEntity> Samsung { get; set;}
        /// <summary>
        /// Таблица для смартфонов Xiaomi
        /// </summary>
        public DbSet<XiaomiEntity> Xiaomi { get; set;}


    }
}
