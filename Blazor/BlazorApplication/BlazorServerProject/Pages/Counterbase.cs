using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerProject.Pages
{
    public class Counterbase : ComponentBase
    {
        protected int currentCount = 0;
        protected string fontfamily = "Verdana";
        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}
