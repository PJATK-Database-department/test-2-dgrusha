using System;
using System.Collections.Generic;
using System.Linq;
using WebTask2.DTO;
using WebTask2.Exceptions;
using WebTask2.Models;

namespace WebTask2.Services
{
    public class DBServices : IDBServices
    {
        private OrderDbContext _db;
        public DBServices(OrderDbContext db) 
        {
            _db = db;
        }

        public IEnumerable<OrderContainer> OrderContainersGet(int id)
        {

            IEnumerable<OrderContainer> oc = (from co in _db.ClientOrders
                                             where co.IDClient == id
                                             select new DTO.OrderContainer
                                             {
                                                 IdClientOrder = co.IdClientOrder
                                             ,
                                                 Comments = co.Comments,
                                                 IDClient = co.IDClient,
                                                 OrderDate = co.OrderDate,
                                                 CompletionDate = co.CompletionDate,
                                                 IDEmployee = co.IDEmployee
                                             }).ToList();
            if (oc == null) 
            {
                throw new MiddleBadReq("bad Request");
            }
            return oc;
        }
        public IEnumerable<OrderContainer> FulfilWithOrders(int id)
        {
            IEnumerable<OrderContainer> orderContainers = OrderContainersGet(id);
            foreach (var item in orderContainers) 
            {
                IEnumerable<OrderDTO> orders2 = (from co in _db.ClientOrders
                                               join cc in _db.Confectionary_ClientOrders on co.IdClientOrder equals cc.IdClientOrder
                                               join cf in _db.Confectioneries on cc.IdConfectionary equals cf.IdConfectionery
                                               where co.IdClientOrder == item.IdClientOrder
                                               select new DTO.OrderDTO { Amount = cc.Amount, ProductName = cf.Name }).ToList();
                item.list = orders2;
            }

            return orderContainers;
        }

        public int TotalAmount(int id) 
        {
            int totalAmount = _db.Confectionary_ClientOrders.Where(x => x.IdClientOrder == id).Sum(x => x.Amount);
            return totalAmount;
        }

        public IEnumerable<OrderContainer> orders(int id)
        {
            IEnumerable<OrderContainer> orderContainers = FulfilWithOrders(id);
            foreach (var item in orderContainers)
            {
                item.TotalAmount = TotalAmount(item.IdClientOrder);
            }

            return orderContainers;
        }


    }
}
