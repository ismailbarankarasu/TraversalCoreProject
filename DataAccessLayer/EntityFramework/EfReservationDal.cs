﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        private readonly Context context;
        public EfReservationDal(Context _context) : base(_context)
        {
            context = _context;
        }

        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            return context.Reservations
             .Include(x => x.Destination)
             .Include(x => x.AppUser)
             .Where(x => x.Status == "Onaylandı" && x.AppUserId == id)
             .ToList();
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            return context.Reservations
               .Include(x => x.Destination)
               .Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserId == id)
               .ToList();
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            return context.Reservations
                .Include(x => x.Destination)
                .Where(x => x.Status == "Onay Bekliyor" && x.AppUserId == id)
                .ToList();
        }
    }
}
