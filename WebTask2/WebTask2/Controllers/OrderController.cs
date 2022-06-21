using Microsoft.AspNetCore.Mvc;
using WebTask2.Services;
using WebTask2.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebTask2.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrderController : Controller
    {
        private readonly IDBServices _dBServices;
        public OrderController(IDBServices dBServices) 
        {
            _dBServices = dBServices;
        }

        [HttpGet("{idClient:int}")]
        public  IActionResult GetAllOrdersById(int idClient)
        {
            var orders =  _dBServices.Orders(idClient);
            return Ok(orders);
        }


        [HttpPut("{idOrder:int}")]
        public IActionResult GetAllOrdersById(int idOrder, IEnumerable<DTO.OrderDTO> orders)
        {
            _dBServices.PutOrders(idOrder, orders);
            return Ok();
        }

    }
}
