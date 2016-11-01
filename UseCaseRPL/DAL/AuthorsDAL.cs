using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UseCaseRPL.Models;

namespace UseCaseRPL.DAL
{
    public class AuthorsDAL : IDisposable
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


        public void Create(Author author)
        {
            try
            {
                db.Authors.Add(author);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }


        public void Edit(Author obj)
        {
            var result = GetByID(obj.AuthorID);

            if (result != null)
            {
                result.FirstName = obj.FirstName;
                result.LastName = obj.LastName;
                result.Email = obj.Email;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                throw new Exception("Data tidak ditemukan !");
            }
        }

        public void Dispose()
        {
           db.Dispose();
        }
    }
    }