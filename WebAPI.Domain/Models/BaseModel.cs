using System;

namespace WebAPI.Domain.Models
{
    public abstract class BaseModel
    {
        public Guid Id { get; set; }
    }
}