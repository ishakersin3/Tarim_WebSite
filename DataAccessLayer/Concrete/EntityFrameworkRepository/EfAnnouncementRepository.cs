using DataAccessLayer.Abstract;
using DataAccessLayer.Contexts;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameworkRepository
{
    public class EfAnnouncementRepository : GenericRepository<Announcement>, IAnnouncementDAL
    {
        public void AnnouncementStatusToFalse(int id)
        {
            using (var context = new TarimContext())
            {
                var value = context.Announcements.FirstOrDefault(x => x.AnnouncementId==id);
                value.Status= false;
                context.SaveChanges();
            }
        }

        public void AnnouncementStatusToTrue(int id)
        {
            using (var context = new TarimContext())
            {
                var value = context.Announcements.FirstOrDefault(x => x.AnnouncementId == id);
                value.Status = true;
                context.SaveChanges();
            }
        }
    }
}
