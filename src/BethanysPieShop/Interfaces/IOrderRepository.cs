using BethanysPieShop.Models;

namespace BethanysPieShop.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        void CreatePieGiftOrder(PieGiftOrder pieGiftOrder);
    }
}
