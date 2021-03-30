using Bussiness.Concrete;
using Core.Entities;
using DataAccess.Concrete.EntityFramework;
//using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class ConsoleUI
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CategoryManager categoryManager = new Bussiness.Concrete.CategoryManager(new EfCategoryDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());


            DateTime? bos = null;

            
            //User user = new User { Id = 1, FirstName = "John", LastName = "Smith",Email="John_Smith@gmail.com",Password="12345" };
            Customer customer1 = new Customer {CustomerId=2, CompanyName = "KofteAd", UserId = 4 };

            AddCustomer(customer1, customerManager);

            //GetByBrandId(3, brandManager);
            //GetByCarId(3,carManager);
            //GetByCategoryId(1, categoryManager);
            //GetByColorId(2, colorManager);




            //GetAllCars(carManager);


            //#########################################_Brand Methods_#########################################
             void AddBrand(Brand brand, BrandManager brandManager1)
            {
                brandManager1.Add(brand);
            }

             void DeleteBrand(Brand brand, BrandManager brandManager1)
            {
                brandManager1.Delete(brand);
            }

             void UpdateBrand(Brand brand, BrandManager brandManager1)
            {
                brandManager1.Update(brand);
            }

             void GetAllBrand(BrandManager brandManager1)
            {
                foreach (var brand in brandManager1.GetAll().Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
             void GetByBrandId(int brandId, BrandManager brandManager1)
            {
                var getBrand = brandManager1.GetById(brandId).Data;
                Console.WriteLine(getBrand.BrandName);
            }

            //#########################################_Category Methods_#########################################
             void AddCategory(Category category, CategoryManager categoryManager1)
            {
                categoryManager1.Add(category);
            }

             void DeleteCategory(Category category, CategoryManager categoryManager1)
            {
                categoryManager1.Delete(category);
            }

             void UpdateCategory(Category category, CategoryManager categoryManager1)
            {
                categoryManager1.Update(category);
            }

             void GetAllCategories(CategoryManager categoryManager1)
            {
                foreach (var category in categoryManager1.GetAll().Data)
                {
                    Console.WriteLine(category.CategoryName);
                }
            }
             void GetByCategoryId(int categoryId, CategoryManager categoryManager1)
            {
                var getCaregory = categoryManager1.GetById(categoryId).Data;
                Console.WriteLine(getCaregory.CategoryName);
            }

            //########################################_Color Methods_#########################################
             void AddColor(Color color, ColorManager colorManager1)
            {
                colorManager1.Add(color);
            }

             void DeleteColor(Color color, ColorManager colorManager1)
            {
                colorManager1.Delete(color);
            }

             void UpdateColor(Color color, ColorManager colorManager1)
            {
                colorManager1.Update(color);
            }

             void GetAllColors(ColorManager colorManager1)
            {
                foreach (var color in colorManager1.GetAll().Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }

             void GetByColorId(int colorId, ColorManager colorManager1)
            {
                var getColor = colorManager1.GetById(colorId).Data;
                Console.WriteLine(getColor.ColorName);
                
            }


            //#########################################_Car Methods_#########################################
             void AddCar(Car car, CarManager carManager1)
            {
                carManager1.Add(car);
            }

             void DeleteCar(Car car, CarManager carManager1)
            {
                carManager1.Delete(car);
            }

             void UpdateCar(Car car, CarManager carManager1)
            {
                carManager1.Update(car);
            }

             void GetAllCars(CarManager carManager1)
            {
                foreach (var car in carManager1.GetAll().Data)
                {
                    Console.WriteLine(car.Desciription);
                }
            }
             void GetCarDetails(CarManager carManager1) 
            {
                foreach (var car in carManager1.GetCarDetails().Data)
                {
                    Console.WriteLine("CarName=" + car.CarName + " CategoryName=" + car.CategoryName + " BrandName=" + car.BrandName + " ColorName="
                        + car.ColorName + " DailyPrice=" + car.DailyPrice);
                }
            }            
             void GetCarsByBrandId(CarManager carManager1)
            {
                foreach (var car in carManager1.GetAllByBrandId(1).Data)
                {
                    Console.WriteLine(car.Desciription);
                }
            }

             void GetCarsByColorId(int carID,CarManager carManager1)
            {
                foreach (var car in carManager1.GetAllByColorId(carID).Data)
                {
                    Console.WriteLine(car.Desciription);
                }
            }

             void GetByCarId(int carId, CarManager carManager1)
            {
                var getCar = carManager1.GetById(carId).Data;
                Console.WriteLine(getCar.CarName);
            }


            //#########################################_User Methods_#########################################
             void AddUser(User user,UserManager userManager1)
            {
                userManager1.Add(user);
                Console.WriteLine(user.FirstName+ " Added");
            }

             void DeleteUser(User user, UserManager userManager1)
            {
                userManager1.Delete(user);
                Console.WriteLine(user.FirstName + " Deleted");
            }

             void UpdateUser(User user, UserManager userManager1)
            {
                userManager1.Update(user);
                Console.WriteLine(user.FirstName + " Updated");
            }

             void GetAllUser(UserManager userManager1)
            {
                foreach (var user in userManager1.GetAll().Data)
                {
                    Console.WriteLine(user.FirstName);
                }
            }

             void GetByUserId(int id, UserManager userManager1)
            {
                var getUser = userManager1.GetById(id).Data;
                Console.WriteLine(getUser.FirstName);
            }

            //#########################################_Customer Methods_#########################################
             void AddCustomer(Customer customer, CustomerManager customerManager1)
            {
                customerManager1.Add(customer);
                Console.WriteLine(customer.CompanyName + " Added");
            }

             void DeleteCustomer(Customer customer, CustomerManager customerManager1)
            {
                customerManager1.Delete(customer);
                Console.WriteLine(customer.CompanyName);
            }

             void UpdateCustomer(Customer customer, CustomerManager customerManager1)
            {
                customerManager1.Update(customer);
                Console.WriteLine(customer.CompanyName);
            }

             void GetAllCustomers(CustomerManager customerManager1)
            {
                foreach (var customer in customerManager1.GetAll().Data)
                {
                    Console.WriteLine(customer.CompanyName);
                }
            }

             void GetByCustomerId(int id, CustomerManager customerManager1)
            {
                var getCustomer = customerManager1.GetById(id).Data;
                Console.WriteLine(getCustomer.CompanyName);
            }


            //#########################################_Reantal Methods_#########################################
             void AddRental(Rental rental, RentalManager rentalManager1)
            {
                if (rental.ReturnDate!=null)
                {
                    rentalManager1.Add(rental);
                    Console.WriteLine(rental.Id + " Added");
                }
                Console.WriteLine(rental.ReturnDate + " Is null " + rental.Id + " Don't added");
            }

             void DeleteRental(Rental rental, RentalManager rentalManager1)
            {
                rentalManager1.Delete(rental);
                Console.WriteLine(rental.Id);
            }

             void UpdateRental(Rental rental, RentalManager rentalManager1)
            {
                rentalManager1.Update(rental);
                Console.WriteLine(rental.Id);
            }

             void GetAllRentals(RentalManager rentalManager1)
            {
                foreach (var customer in rentalManager1.GetAll().Data)
                {
                    Console.WriteLine(customer.Id);
                }
            }

             void GetByRentalId(int id, RentalManager rentalManager1)
            {
                var getCustomer = rentalManager1.GetById(id).Data;
                Console.WriteLine(getCustomer.Id);
            }
        }
    }
}

