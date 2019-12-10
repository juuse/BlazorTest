using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorTest.Shared
{
    public class ResItem : ComponentBase
    {
        public int party { get; set; }
        public DateTime bookingDateTime { get; set; }
        public string cemail { get; set; }
        public string cphone { get; set; }
    }
}
