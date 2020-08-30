using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class BaseModel
    {
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
