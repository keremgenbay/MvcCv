using MvcCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCv.Repostories
{
    
    public class DeneyimRepostories:GenericRepostories<TblDeneyimlerim>
    {
        DbCvEntities db=new DbCvEntities();
        public List<TblDeneyimlerim> List()
        {
            return db.TblDeneyimlerim.ToList();
        }
    }
}