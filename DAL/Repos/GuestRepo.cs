using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{

    internal class GuestRepo : Repo, IRepo<Guest, int, Guest>
    {
        public Guest Create(Guest obj)
        {
            db.Guests.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Guests.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Guest> Read()
        {
            return db.Guests.ToList();
        }

        public Guest Read(int id)
        {
            return db.Guests.Find(id);
        }

        public Guest Update(Guest obj)
        {
            var ex = Read(obj.GuestID);// Update 
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        Guest IRepo<Guest, int, Guest>.Create(Guest obj)
        {
            throw new NotImplementedException();
        }

        bool IRepo<Guest, int, Guest>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        List<Type> IRepo<Guest, int, Guest>.Read()
        {
            throw new NotImplementedException();
        }

        Type IRepo<Guest, int, Guest>.Read(int id)
        {
            throw new NotImplementedException();
        }

        Guest IRepo<Guest, int, Guest>.Update(Type obj)
        {
            throw new NotImplementedException();
        }
    }
}
