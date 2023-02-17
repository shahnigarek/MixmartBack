using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.ViewModels
{
    public class PageNationList<TEntity> : List<TEntity>
    {
        public PageNationList(IQueryable<TEntity> entities, int pageIndex, int totalPages)
        {
            TotalPages = totalPages;
            PageIndex = pageIndex;

            int start = PageIndex - 2;
            int end = PageIndex + 2;

            if (start <= 0)
            {
                end = end - (start - 1);
                start = 1;
            }

            if (end > TotalPages)
            {
                end = TotalPages;

                if (end > 3)
                {
                    start = end - 4;
                }

            }

            Start = start;
            End = end;

            AddRange(entities);
        }

        public int TotalPages { get; }
        public int PageIndex { get; }
        public bool HasNext => PageIndex < TotalPages;
        public bool HasPrev => PageIndex > 1;
        public int Start { get; }
        public int End { get; }

        public static PageNationList<TEntity> Create(IQueryable<TEntity> entities, int pageIndex, int pageItemCount)
        {
            int totalPages = (int)Math.Ceiling((decimal)entities.Count() / pageItemCount);

            if (pageIndex < 1 || pageIndex > totalPages)
            {
                pageIndex = 1;
            }

            entities = entities
                .Skip((pageIndex - 1) * pageItemCount)
                .Take(pageItemCount);

            return new PageNationList<TEntity>(entities, pageIndex, totalPages);
        }
    }
}
