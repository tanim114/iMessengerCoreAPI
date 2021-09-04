using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iMessengerCoreAPI.Models
{
    public class RGDialog
    {
        [Key]
        public Guid IDUnique { get; set; }

        //  nth quantity IDClients
        public List<RGClient> Clients { get; set; }
    }
}
