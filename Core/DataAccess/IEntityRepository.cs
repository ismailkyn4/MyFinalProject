using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using Core.Entities;

namespace Core.DataAccess
{
    //generic constraint - generik kısıt 
    //class:referans tip
    //T ya IEntitiy olabilir yada IEntitiden implemente olan bir nesne olabilir.
    //new ile newlenebilir olsun dedik. IEntity interface olduğu için newlenemez.
    public interface IEntityRepository<T> where T:class,IEntity,new ()  
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter ); //filtre eşittir null demediğimiz zaman bütün datayı istiyoruz demek.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllByCategory(int categoryId); //ürünleri kategorisine göre sırala.
    }
}
