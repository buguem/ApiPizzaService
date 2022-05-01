 using System;
using System.Collections.Generic;
using ApiPizzaService.Entities;
using ApiPizzaService.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace ApiPizzaService.Controllers
{

    [ApiController]
    [Route("orders")]
    public class OrderController : ControllerBase
    {
        private readonly IOrdersRepository repository;

        public OrderController(IOrdersRepository repository )
        {
            this.repository = repository;
        }

        // GET  /orders
        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
            var orders = repository.GetOrders();
            return orders;
        }

        //GET /items/id
        [HttpGet("{id}")]
        public ActionResult<Order>  GetOrder(Guid id)
        {
            var order = repository.GetOrder(id);

            if(order is null){
                return NotFound();
            }
            return order;
        }
    }
}