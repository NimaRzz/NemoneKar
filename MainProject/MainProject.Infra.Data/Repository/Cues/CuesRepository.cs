using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Domain.Interfaces.Cues;
using MainProject.Domain.Model.Cues;

namespace MainProject.Infra.Data.Repository.Cues
{
    public class CuesRepository:ICuesRepository
    {
        private readonly IDataBaseContext _context;

        public CuesRepository(IDataBaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Cue> GetCues()
        {
            return _context.Cues;
        }
    }
}
