using Business.Abstract;
using Core.Utilities;
using DataAccess.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ımagemanager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public ımagemanager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(int carId, string path)
        {
            var carImage = new CarImage
            {
                CarId = carId,
                Date = DateTime.Now,
                ImagePath = path
            };
            _carImageDal.Add(carImage);
            return new SuccessResult("eklendi");
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetAllByCarId(int carId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(int id, string path)
        {
            throw new NotImplementedException();
        }
    }
}
