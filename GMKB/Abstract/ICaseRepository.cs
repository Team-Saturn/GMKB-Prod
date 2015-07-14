using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GMKB.Models;

namespace GMKB.Abstract
{
    public interface ICaseRepository
    {
        IEnumerable<Case> Cases { get; }
    }
}