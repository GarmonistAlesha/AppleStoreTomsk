using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneStoreTomsk.Domain.Models
{
    public class Huawei
    {
        public Guid Id { get; }
        public string Model { get; } = string.Empty;
        public string Description { get; } = string.Empty;
        public decimal Price { get; }
        public int Quantity { get; }
    }
}

