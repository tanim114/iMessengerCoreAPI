using iMessengerCoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iMessengerCoreAPI.Controllers
{
    /// <summary>
    /// RGDialogsClients is a .NET Core 5 based Web APIcontroller 
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    [SwaggerTag("This is a RGDialogsClients controller designed to handle requests")]
    public class RGDialogsClientsController : ControllerBase
    {
        /// <summary>
        /// An API method of finding a dialogue with given client identifiers
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/FindADialogByClients
        ///     {        
        ///       "4b6a6b9a-2303-402a-9970-6e71f4a47151",
        ///       "7de3299b-2796-4982-a85b-2d6d1326396e",
        ///       "50454d55-a73c-4cbc-be25-3c5729dcb82b"        
        ///     }
        /// </remarks>
        /// <param name="ids"> A collection of clients' Identifiers</param> 
        /// <response code="200">Returns a dialog identifier, only if all the given clients's Identifiers are asociated with a dialog. Otherwise, returns an empty GUID</response>
        [HttpPost]
        [Route("FindADialogByClients")]
        public string FindADialogByClients([FromBody] List<Guid> ids)
        {
            if (ids is not null)
            {
                RGDialogsClients RGDialogsClientsModel = new RGDialogsClients();
                Guid DialogIDUnique = RGDialogsClientsModel.GetDialogByAssociatedClients(ids);
                return DialogIDUnique.ToString();
            }
            return "sorry, something went wrong";
        }

    }
}
