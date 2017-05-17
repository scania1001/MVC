using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeworkOfMoney.Models
{
    public class MyClass
    {
        
        public string category { get; set; }
        public int money { get; set; }
        public DateTime _date { get; set; }
        public string remark { get; set; }
    }
}