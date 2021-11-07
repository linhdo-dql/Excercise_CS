using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab06.Lab6_3
{   
    /// <summary>
    /// Bài 6.3 trong Lab06
    /// Yêu cầu:
    /// Tạo lớp Car lưu trữ thông tin (name, color)
    /// Khởi tạo một List lưu trữ danh sách 10 Car
    /// Xóa các Car có màu Red
    /// In danh sách các Car.
    /// </summary>
    class Lab6_3
    {
        public void ShowResult()
        {
            List<Car> cars = InitCars();
            Console.WriteLine("a. Khởi tạo 1 danh sách Car: ");
            Display(cars);
            Console.WriteLine("b. Xóa tất cả các Car có màu Red: ");
            Display(DeleteCar(cars, "Red"));
            Console.WriteLine("c. In danh sách các Car: ");
            Display(cars);
        }
        /// <summary>
        /// In danh sách các Car.
        /// </summary>
        /// <param name="c"></param>
        public void Display(List<Car> c)
        {
            foreach(Car x in c)
            {
                Console.WriteLine(x.ToString());
            }
        }
        /// <summary>
        /// Khởi tạo một List lưu trữ danh sách 10 Car
        /// </summary>
        /// <returns></returns>
        public List<Car> InitCars()
        {   
            List<Car> cars = new List<Car>();
            cars.Add(new Car("Ferrari", "Yellow"));
            cars.Add(new Car("McLaren", "Black"));
            cars.Add(new Car("Lamborgini", "Red"));
            cars.Add(new Car("BMW", "Blue"));
            cars.Add(new Car("Mercerdes Ben", "Cyan"));
            cars.Add(new Car("Audi", "White"));
            cars.Add(new Car("Land Rover", "Gray"));
            cars.Add(new Car("Huyndai", "White"));
            cars.Add(new Car("Suzuki", "Red"));
            cars.Add(new Car("Mitsubishi", "Gray"));
            return cars;
        }
        /// <summary>
        /// Xóa các Car theo màu
        /// </summary>
        /// <param name="cars"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public List<Car> DeleteCar(List<Car> cars, string color)
        {
            cars.RemoveAll((c) => { return c.color.Equals(color); });
            return cars;
        }
    }
}
