using SmartphoneStoreTomsk.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartphonesStoreTomskInfrastrutcture.Entites;


namespace SmartphonesStoreTomskInfrastrutcture
{
    public class AppleRepository
    {
        private readonly SmartphonesStoreTomskDbContext _context;
        public AppleRepository(SmartphonesStoreTomskDbContext context)
        {
            _context = context;
        }
        public async Task<List<Apple>> GetApple()
        {

            var appleEntities = await _context.Apples
                .AsNoTracking()
                .ToListAsync();



            var apple = appleEntities.Select(b => Apple.Create(b.Id,b.Model,b.Description,b.Price).apple)
                .ToList();
           
            return apple;


        }

        public async Task<Guid> CreateApple(Apple apple)
        {

            var appleEntity = new AppleEntity
            {
                Id = apple.Id,
                Model = apple.Model,
                Description = apple.Description,
                Price = apple.Price,

            };
            object Apple = await _context.Apples.AddAsync(appleEntity);
            await _context.SaveChangesAsync();

            return appleEntity.Id;
        
        
        }
        public async Task<Guid> Update(Guid id , string model, string description , decimal price, int quantity)
        {

            await _context.Apples
                .Where(b => b.Id == id)
                .ExecuteUpdateAsync(s => s
                .SetProperty(b => b.Model, b => model)
                .SetProperty(b => b.Description, b => description)
                .SetProperty(b => b.Price, b => price)
                .SetProperty(b => b.Quantity, b => quantity));

            return id;
        }
        public async Task<Guid> DeleteApple(Guid id)
        { 
        
            await _context.Apples
                .Where (b => b.Id == id)
                .ExecuteDeleteAsync();
            
            return id;
        
        
        }
    }
}
