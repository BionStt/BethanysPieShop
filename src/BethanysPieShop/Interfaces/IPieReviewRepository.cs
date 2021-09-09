using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;

namespace BethanysPieShop.Interfaces
{
    public interface IPieReviewRepository
    {
        void AddPieReview(PieReview pieReview);
        IEnumerable<PieReview> GetReviewsForPie(int pieId);
    }
}
