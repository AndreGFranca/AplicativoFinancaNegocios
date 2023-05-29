using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Utils
{
    public class Mascaras
    {
        public static PatternMask Monetario = new PatternMask("R$ #,##")
        {
            MaskChars = new[] { new MaskChar('#', @"^\d+$") },

        };
    }
}
