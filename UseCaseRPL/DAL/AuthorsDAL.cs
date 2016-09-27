using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UseCaseRPL.Models;

namespace UseCaseRPL.DAL
{
    public class AuthorsDAL
    {
        private CommerceDbEntities db;
        public AuthorsDAL()
        {
            db = new CommerceDbEntities();

        }

        //menampilkan semua data Authors
        public IQueryable<Author> getAll()
        {
            var result = from c in db.Authors
                         orderby c.FirstName ascending
                         select c;
            return result;
        }

        public Author GetByID(int id)
        {
            var result = (from c in db.Authors
                         where c.AuthorID == id
                         select c).FirstOrDefault();
            if (result != null)
                return result;
            else
                throw new Exception("Data dengan id " + id.ToString() + " tidak ditemukan");
        }

        
    }
}