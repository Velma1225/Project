using System.Linq.Expressions;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class EfRepository<T> : IRepository<T> where T : class
{
    protected readonly HaBanContext DbContext;

    public EfRepository(HaBanContext dbContext)
    {
        DbContext = dbContext;
    }


    public T Add(T entity)
    {
        DbContext.Set<T>().Add(entity);
        DbContext.SaveChanges();
        return entity;
    }

    public IEnumerable<T> AddRange(IEnumerable<T> entities)
    {
        DbContext.Set<T>().AddRange(entities);
        DbContext.SaveChanges();
        return entities;
    }

    public async Task<T> AddAsync(T entity)
    {
        DbContext.Set<T>().Add(entity);
        await DbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
    {
        DbContext.Set<T>().AddRange(entities);
        await DbContext.SaveChangesAsync();
        return entities;
    }

    public T Update(T entity)
    {
        DbContext.Set<T>().Update(entity);
        DbContext.SaveChanges();
        return entity;
    }

    public IEnumerable<T> UpdateRange(IEnumerable<T> entities)
    {
        DbContext.Set<T>().UpdateRange(entities);
        DbContext.SaveChanges();
        return entities;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        DbContext.Set<T>().Update(entity);
        await DbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<IEnumerable<T>> UpdateRangeAsync(IEnumerable<T> entities)
    {
        DbContext.Set<T>().UpdateRange(entities);
        await DbContext.SaveChangesAsync();
        return entities;
    }

    public void Delete(T entity)
    {
        DbContext.Set<T>().Remove(entity);
        DbContext.SaveChanges();
    }

    public void DeleteRange(IEnumerable<T> entities)
    {
        DbContext.Set<T>().RemoveRange(entities);
        DbContext.SaveChanges();
    }

    public async Task DeleteAsync(T entity)
    {
        DbContext.Set<T>().Remove(entity);
        await DbContext.SaveChangesAsync();
    }

    public async Task DeleteRangeAsync(IEnumerable<T> entities)
    {
        DbContext.Set<T>().RemoveRange(entities);
        await DbContext.SaveChangesAsync();
    }
    

    public T GetById<TId>(TId id)
    {
        return DbContext.Set<T>().Find(new object[] { id });
    }

    public async Task<T> GetByIdAsync<TId>(TId id)
    {
        return await DbContext.Set<T>().FindAsync(new object[] { id });
    }

    public T FirstOrDefault(Expression<Func<T, bool>> expression)
    {
        return DbContext.Set<T>().FirstOrDefault(expression);
    }

    public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression)
    {
        return await DbContext.Set<T>().FirstOrDefaultAsync(expression);
    }

    public T SingleOrDefault(Expression<Func<T, bool>> expression)
    {
        return DbContext.Set<T>().SingleOrDefault(expression);
    }

    public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> expression)
    {
        return await DbContext.Set<T>().SingleOrDefaultAsync(expression);
    }

    public bool Any(Expression<Func<T, bool>> expression)
    {
        return DbContext.Set<T>().Any(expression);
    }

    public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
    {
        return await DbContext.Set<T>().AnyAsync(expression);
    }

    public async Task<List<T>> ListAsync()
    {
        return await DbContext.Set<T>().ToListAsync();
    }

    public async Task<List<T>> ListAsync(Expression<Func<T, bool>> expression)
    {
        return await DbContext.Set<T>().Where(expression).ToListAsync();
    }

    public List<T> List(Expression<Func<T, bool>> expression)
    {
        return  DbContext.Set<T>().Where(expression).ToList();
    }

    //HaBan新增

    
    public List<T> Select(Expression<Func<T, T>> expression)
    {
        return DbContext.Set<T>().Select(expression).ToList();
    }

    public async Task<List<T>> SelectAsync(Expression<Func<T, T>> expression)
    {
        return await DbContext.Set<T>().Select(expression).ToListAsync();
    }

    

    //參考定義:
    //public static IQueryable<TResult> Select<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
    //{
    //    ArgumentNullException.ThrowIfNull(source);
    //    ArgumentNullException.ThrowIfNull(selector);

    //    return source.Provider.CreateQuery<TResult>(
    //        Expression.Call(
    //            null,
    //            CachedReflectionInfo.Select_TSource_TResult_2(typeof(TSource), typeof(TResult)),
    //            source.Expression, Expression.Quote(selector)
    //            ));
    //}









}