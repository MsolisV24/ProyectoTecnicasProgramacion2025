using ClassModels;

namespace ClassController
{
    public interface ICartService
    {
        Cart GetCurrentCart();
        void SetCurrentUserAndFair(string username, int fairId);
        void AddItem(int productId, decimal qty);
        void RemoveItem(int productId);
        void ClearCart();
        void SetDeliveryAddress(int addressId);
        List<ExpenseRecord> Checkout();
    }
}


