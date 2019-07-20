using SRQH.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRQH.Domain.Entities.BookingFlow
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CPF { get; set; }
        
        public Customer(string name, string email, string phone, string cPF) : base()
        {
            Name = name;
            Email = email;
            Phone = phone;
            CPF = cPF;
        }
    }
}
