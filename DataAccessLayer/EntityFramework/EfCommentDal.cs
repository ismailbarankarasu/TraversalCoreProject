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
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        private readonly Context context;
        public EfCommentDal(Context _context) : base(_context)
        {
            context = _context;
        }

        public List<Comment> CommentListWithDestination()
        {
            var values = context.Comments.Include(x => x.Destination).ToList();
            return values;
        }
    }
}
