using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Common
{
    public static class Pagination
    {

        public static IEnumerable<TSource> ToPaged<TSource>(this IEnumerable<TSource> source, int page, int pageSize, out int rowsCount)
        {

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "Source cannot be null.");
            }
             rowsCount = source.Count();
           
            return source.Skip((page - 1) * pageSize).Take(pageSize);
        }
    }
}
