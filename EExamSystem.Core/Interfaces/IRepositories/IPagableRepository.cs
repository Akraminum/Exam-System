using EExamSystem.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EExamSystem.Core.Interfaces.IRepositories
{
    public interface IPagableRepository<T>
    {
        public IEnumerable<T> FindPage(PagingParametersDto PagingParameters,
                                        Expression<Func<T, bool>> searchpredicate,
                                        Expression<Func<T, object>> orderpredicate);
        public IEnumerable<T> GetPage(PagingParametersDto PagingParameters, Expression<Func<T, object>> orderpredicate);
    }
}
