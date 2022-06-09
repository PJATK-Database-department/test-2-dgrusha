using System.Collections.Generic;
using WebTask2.DTO;

namespace WebTask2.Services
{
    public interface IDBServices
    {

        public IEnumerable<OrderContainer> orders(int id);

    }
}
