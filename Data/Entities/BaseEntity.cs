using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public BaseEntity()
        { }

        public BaseEntity(int id)
            : this()
        {
            this.Id = id;
        }
    }
}
