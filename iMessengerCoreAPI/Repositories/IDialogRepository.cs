using iMessengerCoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iMessengerCoreAPI.Repositories
{
    public interface IDialogRepository
    {
        Task<IEnumerable<RGDialog>> Get();
        Task<RGDialog> Get(Guid IDUnique);
        Task<RGDialog> Create(RGDialog dialog);
        Task Update(RGDialog dialog);
        Task Delete(Guid IDUnique);
    }
}
