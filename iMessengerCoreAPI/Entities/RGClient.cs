using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iMessengerCoreAPI.Models
{
    public class RGClient
    {
        [Key]
        public Guid IDUnique { get; set; }
    }
}
