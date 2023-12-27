using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{

    internal class BookingRepo : Repo, IRepo<Booking, int, Booking>
    {
        public Booking Create(Booking obj)
        {
            db.Bookings.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Bookings.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Booking> Read()
        {
            return db.Bookings.ToList();
        }

        public Booking Read(int id)
        {
            return db.Bookings.Find(id);
        }

        public Booking Update(Booking obj)
        {
            var ex = Read(obj.BookingID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;

        }

        Booking IRepo<Booking, int, Booking>.Create(Booking obj)
        {
            throw new NotImplementedException();
        }

        bool IRepo<Booking, int, Booking>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        List<Type> IRepo<Booking, int, Booking>.Read()
        {
            throw new NotImplementedException();
        }

        Type IRepo<Booking, int, Booking>.Read(int id)
        {
            throw new NotImplementedException();
        }

        Booking IRepo<Booking, int, Booking>.Update(Type obj)
        {
            throw new NotImplementedException();
        }
    }
}
