using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface ICardService
    {
         void InitializeCard(string userId);
         Card GetCardByUserId(string userId);
        void AddToCard(string userId,int productId,int quantity);
        void DeleteFromCard(string userId, int productId);
    }
}