using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auto.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }//айдишник заказа
        public string Person { get; set; } //покупатель, Фио
        public string Address { get; set; }//адрес покупателя
        public int AutoId { get; set; }
        public DateTime Date { get; set; }//дата заказа
    }
}