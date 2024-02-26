using SignalR.DataAccesLayer.Abstract;
using SignalR.DataAccesLayer.Concrete;
using SignalR.DataAccesLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccesLayer.EntityFramework
{
	public class EfMenuTableDal : GenericRepository<MenuTable>, IMenuTableDal

	{
		public EfMenuTableDal(SignalRContext context) : base(context)
		{
		}

		public int MenuTableCount()
		{
			using var context = new SignalRContext();
			return context.MenuTables.Count();
		}

        public void MenuTableStatusFalse(int id)
        {
            using var context = new SignalRContext();
			var value = context.MenuTables.Find(id);
			value.Status = false;
			context.SaveChanges();
        }

        public void MenuTableStatusTrue(int id)
        {
            using var context = new SignalRContext();
            var value = context.MenuTables.Find(id);
            value.Status = true;
            context.SaveChanges();
        }
    }
}
