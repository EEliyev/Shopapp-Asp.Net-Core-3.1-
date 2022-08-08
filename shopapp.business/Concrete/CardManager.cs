using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.business.Concrete
{
    public class CardManager : ICardService
    {
        private readonly IUnitOfWork _unitofwork;
        public CardManager(IUnitOfWork unitofwork)
        {
            _unitofwork=unitofwork;
        }

        public void AddToCard(string userId, int productId, int quantity)
        {
            var card = GetCardByUserId(userId);

            if(card!=null)
            {
                // eklenmek isteyen urun sepette var mi(guncelleme)
                // eklenmek isteyen urun sepette var  ve yeni kayit olustur(kayit ekleme)

                var index = card.CardItems.FindIndex(i=>i.ProductId==productId);
                if(index<0)
                {
                    card.CardItems.Add(new CardItem()
                    {
                        ProductId=productId,
                        Quantity=quantity,
                        CardId=card.Id
                    });
                }else{
                    card.CardItems[index].Quantity+=quantity;
                }

                _unitofwork.Cards.Update(card);
                _unitofwork.Save();
            }
        }

        public void DeleteFromCard(string userId, int productId)
        {
            var card = GetCardByUserId(userId);
            if(card!=null)
            {
                _unitofwork.Cards.DeleteFromCard(card.Id,productId);
                _unitofwork.Save();
            }
        }

        public Card GetCardByUserId(string userId)
        {
            return _unitofwork.Cards.GetCardByUserId(userId);
        }

        public void InitializeCard(string userId)
        {
            _unitofwork.Cards.Create(new Card(){UserId=userId});
            _unitofwork.Save();
        }
    }
}