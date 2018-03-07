using System;
using System.Web;
using System.ComponentModel.DataAnnotations;
//using System.Data.Entity;


namespace Fourm.Models
{
    public class fourm
    {
        [Required]
        public int ID { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public DateTime Timestamp { get; set; }


    }
}
