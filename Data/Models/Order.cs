using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever] //ніколи не відображається
        public int id { get; set; }

        [Display(Name = "Enter name")] //яке ымя буде выдображатися
        [StringLength(20)] // введена строка повинна бути не більше 20 символыв
        [Required(ErrorMessage ="Length of name is minimum 20 sybols")]
        public string name { get; set; }

        public string surname { get; set; }
        
        public string address{ get; set; }

        [Display(Name = "Enter Phone")]

        
        public string phone { get; set; }
        
        [Display(Name = "Enter Email")]
        [DataType(DataType.EmailAddress)]
        
        public string email { get; set; }

        [BindNever] //ніколи не відображається
        [ScaffoldColumn(false)] //щоб навіть в коді не було видно
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
