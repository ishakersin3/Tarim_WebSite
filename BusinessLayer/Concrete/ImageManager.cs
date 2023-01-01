using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageManager : IImageService
    {
        private IImageDAL _ımageDAL;

        public ImageManager(IImageDAL ımageDAL)
        {
            _ımageDAL = ımageDAL;
        }
        public void Delete(Image t)
        {
            _ımageDAL.Delete(t);
        }

        public Image GetById(int id)
        {
            return _ımageDAL.GetById(id);
        }

        public List<Image> GetListAll()
        {
            return _ımageDAL.GetListAll();
        }

        public void Insert(Image t)
        {
            _ımageDAL.Insert(t);
        }

        public void Update(Image t)
        {
            _ımageDAL.Update(t);
        }
    }
}
