using LaboratorioArlissonMenacho.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LaboratorioArlissonMenacho.Repositories
{
    public class RepositoryBase<Tentity>:IDisposable where Tentity:class
    {
        private readonly LaboratorioContexto db;

        public RepositoryBase(LaboratorioContexto db)
        {
            this.db = db;
        }

        public void Add(Tentity T)
        {
            db.Set<Tentity>().Add(T);
            db.SaveChanges();
        }
        public void Delete(Tentity T)
        {

            db.Set<Tentity>().Remove(T);
            db.SaveChanges();
        }
        public IList<Tentity> FindAll()
        {
            return db.Set<Tentity>().ToList();
        }
        public Tentity GetById(int id)
        {
            return db.Set<Tentity>().Find(id);
        }
        public void Update(Tentity T)
        {
            db.Entry(T).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
