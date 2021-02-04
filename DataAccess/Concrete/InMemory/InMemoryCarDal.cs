using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id=1, BrandId=1,ColorId=1, ModelYear=2020, DailyPrice=1000, Description="Kırmızı renk Dizel Volvo "},
                new Car{Id=2, BrandId=2,ColorId=2, ModelYear=2009, DailyPrice=250, Description="Beyaz renk Tüplü Opel"},
                new Car{Id=3, BrandId=3,ColorId=1, ModelYear=2012, DailyPrice=550, Description="Kırmızı renk Benzinli Mercedes"},
                new Car{Id=4, BrandId=4,ColorId=3, ModelYear=2018, DailyPrice=300, Description="Siyah renk Dizel Nissan"},
                new Car{Id=5, BrandId=5,ColorId=4, ModelYear=2016, DailyPrice=400, Description="Gri renk Benzinli Toyota"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car); 
        }

        public void Delete(Car car)
        {
           Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);


        }

        public List<Car> GetAll()
        {
            return _cars;
        }


        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;    
        }
    }
}
