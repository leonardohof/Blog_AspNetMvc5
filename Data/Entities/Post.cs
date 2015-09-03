using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string UrlSlug { get; set; }
        public bool Published { get; set; }
        public DateTime? PostedOn { get; set; }
        public DateTime? Modified { get; set; }
        public virtual IList<Category> Categories { get; set; }
        public virtual IList<Tag> Tags { get; set; }
    }
}
