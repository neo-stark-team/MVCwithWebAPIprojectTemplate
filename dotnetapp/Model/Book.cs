using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Web;  
namespace dotnetapp.Models  
{  
    public class Book  
    {  
        public int BookId { get; set; }  
        public string BookName { get; set; }  
        public string Category { get; set; }  
        public decimal Price { get; set; }  
    }  
} 