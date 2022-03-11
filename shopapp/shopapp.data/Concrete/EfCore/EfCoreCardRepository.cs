using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public class EfCoreCardRepository : EfCoreGenericRepository<Card>,
     ICardRepository
    {
        public EfCoreCardRepository(ShopContext context):base(context)
        {
            
        }
        private ShopContext ShopContext
        {
            get{ return context as ShopContext;}
        }
        public void DeleteFromCard(int cardId, int productId)
        {
         
            var cmd = @"delete from CardItems where CardId=@p0 and ProductId=@p1";
            ShopContext.Database.ExecuteSqlRaw(cmd,cardId,productId);
        
        }

        public Card GetCardByUserId(string userId)
        {
           
            return ShopContext.Cards
                        .Include(i=>i.CardItems)
                        .ThenInclude(i=>i.Product)
                        .FirstOrDefault(i=>i.UserId==userId);
    
        }
        public override void Update(Card entity)
        {
            
            ShopContext.Cards.Update(entity);
        
    }
    }
}