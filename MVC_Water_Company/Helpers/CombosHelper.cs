using MVC_Water_Company.Data;
using MVC_Water_Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Water_Company.Helpers
{
    public class CombosHelper : IDisposable
    {
        private static MVC_Water_CompanyContext db = new MVC_Water_CompanyContext();

        public static List<Locality> GetLocalities()
        {
            var localities = db.Localities.ToList();

            localities.Add(new Locality{ 
            LocalityID = 0,
            Name = "[Select a locality]"
            });

            return localities.OrderBy(l => l.Name).ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}