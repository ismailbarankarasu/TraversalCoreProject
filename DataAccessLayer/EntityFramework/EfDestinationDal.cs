using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        private readonly Context _context;
        public EfDestinationDal(Context context) : base(context)
        {
            _context = context;
        }

        public int DestinationCount()
        {
            var destinationCount = _context.Destinations.Count();
            return destinationCount;
        }

        public int GuidesCount()
        {
            
            var guidesCount = _context.Guides.Count();
            return guidesCount;
        }
    }
}
