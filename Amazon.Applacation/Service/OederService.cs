﻿using Amazon.Applacation.Contract;
using Amazon.Models.Models;
using System;
using System.Linq;


namespace Amazon.Applacation.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
  


        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
        
        }
       
        public Order Add(Order order)
        {
            if (order is not null)
            {
                order.StateOrder = StateOrder.Processing;
                var res = _orderRepository.Add(order);
                _orderRepository.Save();
                return res;
            }
            else
            {
                throw new Exception("Order data is not valid!");
            }
        }

        public Order UpdateState(int orderId, StateOrder newState,string Email)
        {
            var order = _orderRepository.GetById(orderId);
           
            if (order is not null)
            {
                order.StateOrder = newState;
                
                var res = _orderRepository.Update(order);
                _orderRepository.Save();
                return res;
            }
            else
            {
                throw new Exception("Order not found!");
            }
        }
        public IQueryable<Order> GetOrderByUser(int UserID)
        {
            if(UserID < 0)
            {
                return _orderRepository.GetOrderByUser(UserID);
            }
            else
            {
                throw new Exception("User Data Not Vaild");
            }
        }
        public Order GetOrderById(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception(" I dont have Id of This Order");
            }
            else
            {
              return  _orderRepository.GetById(Id);
            }
        }

    }
}
