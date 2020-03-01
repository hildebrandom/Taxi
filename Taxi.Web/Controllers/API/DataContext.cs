using System;
using System.Threading.Tasks;
using Taxi.Web.Data.Entities;

namespace Taxi.Web.Controllers.API
{
    public class DataContext
    {
        public object Taxis { get; internal set; }

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        internal void Update(TaxiEntity taxiEntity)
        {
            throw new NotImplementedException();
        }

        internal void Add(TaxiEntity taxiEntity)
        {
            throw new NotImplementedException();
        }
    }
}