using Microsoft.EntityFrameworkCore;
using Store.Data.Entities;

namespace Store.Repository.Specification;

public class SpecificationEvaluator<TEntity,TKey> where TEntity : BaseEntity<TKey>
{
    // IEnumerable VS IQueryable
    public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> specs)
    {
        var query = inputQuery;
        if (specs.Criteria is not null)
            query = query.Where(specs.Criteria); // x => x.TypeId == 3

        if (specs.OrderBy is not null)
            query = query.OrderBy(specs.OrderBy); // x => x.Name
        
        if (specs.OrderByDescending is not null)
            query = query.OrderByDescending(specs.OrderByDescending); 

        if (specs.IsPaginated)
            query = query.Skip(specs.Skip).Take(specs.Take);
        
        query = specs.Includes.Aggregate(query,(current,includeExpression) => current.Include(includeExpression));

        return query;
    }
}