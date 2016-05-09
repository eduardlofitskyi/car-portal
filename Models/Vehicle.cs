using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;


namespace Auto.Models
{
    public class Vehicle
    {

        
        [Key]
        public int Id { get; set; }
        
        public String brand { get; set; } //марка
        public String model { get; set; } //модель
        public int releaseDate { get; set; } // год выпуска
        public String color { get; set; }   //цвет
        public String title { get; set; }   // описание
        public bool autoKPP { get; set; }   // автоматическая коробка передач: true - да, false - нет
        public double capacity{ get; set; } // вместимость
        public int price { get; set; } // цена
      [Required]
        public bool isUses { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }

    }
}