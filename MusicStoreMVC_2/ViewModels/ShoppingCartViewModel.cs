using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicStoreMVC_2.Models;

namespace MusicStoreMVC_2.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}