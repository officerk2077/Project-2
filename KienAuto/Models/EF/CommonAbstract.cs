using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KienAuto.Models.EF
{
    public abstract class CommonAbstract
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifierDate { get; set; }
        public DateTime ModifierBy { get; set; } 
    }
}