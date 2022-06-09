using System.Collections.Generic;
using WebTask2.DTO;

namespace WebTask2.Services
{
    public interface IDBServices
    {

        public IEnumerable<OrderContainer> Orders(int id);

        public void PutOrders(int id, IEnumerable<DTO.OrderDTO> orders);

    }
}
