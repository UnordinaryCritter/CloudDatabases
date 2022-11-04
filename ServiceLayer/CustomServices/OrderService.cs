using ServiceLayer.ICustomServices;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer;

namespace ServiceLayer.CustomServices
{
    public class OrderService: ICustomService <Order>{
    private readonly IRepository<Order> _orderRepository;
        public OrderService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order Get(int Id)
        {
            try
            {
                var obj = _orderRepository.Get(Id);
                if(obj == null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Order> GetAll()
        {
            try
            {
                var obj = _orderRepository.GetAll();
                if (obj == null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
