namespace HomeworkOfMoney.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountBook")]
    public partial class AccountBook
    {
        public Guid Id { get; set; }
        [Display(Name = "類別")]
        public int Categoryyy { get; set; }
        [Display(Name = "金額")]
        public int Amounttt { get; set; }
        [Display(Name = "日期")]
        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}")]
        public DateTime Dateee { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "註解")]
        public string Remarkkk { get; set; }
    }
}
