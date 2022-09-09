using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Anqa.Service.Core.Lib.Models
{
    public class MappingCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public int DivisionId { get; set; }
    }
}
