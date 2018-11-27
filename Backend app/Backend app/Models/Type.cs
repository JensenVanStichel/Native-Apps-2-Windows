using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_app.Models
{
    public enum Type
    {
        Restaurant,
        Hotel, 
        Café,
        Winkel,
        Recreatie,
        Cultuur,
        [Display(Description="Fast food")]
        Fastfood
    }
}
