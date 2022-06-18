using AppBay_BackEnd.Models;
using System.Collections.Generic;

namespace AppBay_BackEnd.ViewModels
{
    public class HomeVM
    {
       public Slider sliders { get; set; }
       public IEnumerable<Card> cards { get; set; } 
       public IEnumerable<Modern> moderns { get; set; }

    }
}
