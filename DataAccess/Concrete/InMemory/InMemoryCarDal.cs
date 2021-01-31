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
			_cars = new List<Car>
			{
				new Car{Id=1, BrandId = 1, ColorId = 1, ModelYear = 2020, DailyPrice = 300, Description = "Dizel"},
				new Car{Id=2, BrandId = 2, ColorId = 2, ModelYear = 2019, DailyPrice = 275, Description = "Benzin"},
				new Car{Id=3, BrandId = 2, ColorId = 3, ModelYear = 2018, DailyPrice = 250, Description = "Dizel"},
				new Car{Id=4, BrandId = 2, ColorId = 3, ModelYear = 2017, DailyPrice = 225, Description = "Dizel"},
				new Car{Id=5, BrandId = 1, ColorId = 1, ModelYear = 2016, DailyPrice = 200, Description = "Benzin"},

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

		public Car GetById(int Id)
		{
			return _cars.SingleOrDefault(c => c.Id == Id);
		}

		public void Update(Car car)
		{
			Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
			carToUpdate.Id = car.Id;
			carToUpdate.ColorId = car.ColorId;
			carToUpdate.BrandId = car.BrandId;
			carToUpdate.DailyPrice = car.DailyPrice;
			carToUpdate.Description = car.Description;
			carToUpdate.ModelYear = car.ModelYear;
		}
	}
}
