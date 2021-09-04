using iMessengerCoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iMessengerCoreAPI.Repositories
{
    public class DialogRepository : IDialogRepository
    {
        private readonly iMessengerContext _context;

        public DialogRepository(iMessengerContext context)
        {
            _context = context;
        }

        public async Task<RGDialog> Create(RGDialog dialog)
        {
            _context.Dialogs.Add(dialog);
            await _context.SaveChangesAsync();
            return dialog;
        }

        public async Task Delete(Guid IDUnique)
        {
            var dialogToDelete = await _context.Dialogs.FindAsync(IDUnique);
            _context.Dialogs.Remove(dialogToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<RGDialog>> Get()
        {
            return await _context.Dialogs.ToListAsync();
        }

        public async Task<RGDialog> Get(Guid IDUnique)
        {
            return await _context.Dialogs.FindAsync(IDUnique);
        }

        public async Task Update(RGDialog dialog)
        {
            _context.Entry(dialog).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
