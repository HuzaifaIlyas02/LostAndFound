using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public DateTime Date { get; set; }
        public string? Time { get; set; }
        public string? ContactInfo { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsLost { get; set; }
    }
}