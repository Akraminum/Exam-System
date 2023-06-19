using EExamSystem.Core.DTO;
using EExamSystem.Core.Interfaces.IRepositories;
using EExamSystem.Core.Interfaces.Repositories;
using EExamSystem.Infrastructure.DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EExamSystem.Core.Repositories
{
    public class GenericPagableRepository<T> : GenericRepository<T>, IGenericRepository<T>, IPagableRepository<T> where T : class
    {
        protected readonly ApplicationDbContext context;

        public GenericPagableRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<T> FindPage(PagingParametersDto PagingParameters,
                                        Expression<Func<T, bool>> searchpredicate,
                                        Expression<Func<T, object>> orderpredicate)
        {
            var totalCount = context.Set<T>().Count();
            var skipCount = (PagingParameters.PageNumber - 1) * PagingParameters.PageSize;

            var query = context.Set<T>()
                                    .Where(searchpredicate)
                                    .OrderByDescending(orderpredicate)
                                    .Skip(skipCount)
                                    .Take(PagingParameters.PageSize);

            Console.WriteLine("=================================");
            Console.WriteLine(query.ToQueryString());
            Console.WriteLine("=================================");

            return query.ToList();
        }

        public IEnumerable<T> GetPage(PagingParametersDto PagingParameters,
                                        Expression<Func<T, object>> orderpredicate)
        {
            return FindPage(PagingParameters, e => true, orderpredicate);
        }
    }
}
