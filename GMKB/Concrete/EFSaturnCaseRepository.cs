using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GMKB.Abstract;
using GMKB.Models;

namespace GMKB.Concrete
{
    public class EFSaturnCaseRepository : ICaseRepository
    {
        private SaturnEntities db = new SaturnEntities();

        public IEnumerable<Case> Cases
        {
            get { return db.Cases; }
        }

    }
}