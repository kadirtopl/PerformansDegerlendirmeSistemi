using PMS.Core.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Entity.Concrete
{
    public class UserPosition : IEntity
    {
        [Key]
        public int USERPOSITIONID { get; set; }

        public int USERID { get; set; }

        public int POSITIONID { get; set; } 


    }
}
