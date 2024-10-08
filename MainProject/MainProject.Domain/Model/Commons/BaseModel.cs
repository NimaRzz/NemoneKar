using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Domain.Model.Commons
{
    public abstract class BaseModel<TKey>
    {

        [Key]
        public TKey Id { get; set; }
        public DateTime InsertTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? RemoveTime { get; set; }
        public bool IsRemoved { get; set; }
    }

    public abstract class BaseModel : BaseModel<long>
    {

    }

}
