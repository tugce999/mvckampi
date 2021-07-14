using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
   public class Content
    {
        [Key]
        public int ContentID { get; set; }

        public string ContrnyValue { get; set; }
        public DateTime ContentDate { get; set; }

        public int HeadingId {get; set; }
        public virtual Heading Heading {get; set; }

        public int? WriterId { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
