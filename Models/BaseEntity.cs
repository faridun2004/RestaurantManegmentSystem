﻿namespace RestaurantManegmentSystem.Models
{
    public abstract class BaseEntity
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
        
        public override string ToString()
        {
            return $"Id:{Id} ({GetType().Name})";
        }
    }
}
