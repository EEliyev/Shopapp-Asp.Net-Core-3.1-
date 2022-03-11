using shopapp.entity;

namespace shopapp.data.Abstract
{
    public interface ICardRepository:IRepository<Card>
    {
        Card GetCardByUserId(string userId);
        void DeleteFromCard(int cardId, int productId);
    }
}