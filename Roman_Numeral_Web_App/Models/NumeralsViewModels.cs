using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Roman_Numeral_Web_App.Models
{
    public class NumeralsViewModel
    {
        [DataType(DataType.Text),Required, StringLength(15)]
        public string Roman_Numerals { get; set; }
        [DataType(DataType.Text)]
        public ulong Arabic_Numerals { get; set; }
    }
}
