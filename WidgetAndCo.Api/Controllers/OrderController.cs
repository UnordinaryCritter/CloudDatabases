using DomainLayer.Data;
using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ICustomServices;
using System.Runtime.CompilerServices;

namespace WidgetAndCo.Api.Controllers
{
    public class OrderController : ControllerBase
    {
        private readonly ICustomService<Order> _orderService;
        private readonly ApplicationDbContext _applicationDbContext;
        public OrderController(ICustomService<Order> orderService, ApplicationDbContext applicationDbContext)
        {
            _orderService = orderService;
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet(nameof(GetOrderById))]
        public IActionResult GetOrderById(int Id)
        {
            var obj = _orderService.Get(Id);
            if(obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }


        [HttpGet(nameof(GetOrders))]
        public IActionResult GetOrders(int Id)
        {
            var obj = _orderService.GetAll();
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
    }
}
