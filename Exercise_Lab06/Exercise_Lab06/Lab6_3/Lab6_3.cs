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
        List<Car> cars = new List<Car>();
        public void ShowResult()
        {
            Menu();
        }
        public void Menu()
        {
            Console.WriteLine("-----------------------------Bài 6.3-------------------------------");
            Console.WriteLine("1. Tạo collection. ");
            Console.WriteLine("2. Hiện thị Collections. ");
            Console.WriteLine("3. Xóa tất cả các Car có màu Red. ");
            Console.WriteLine("4. In danh sách các Car. ");
            Console.WriteLine("0. Thoát.");
            Console.WriteLine("Mời chọn: ");
            dynamic choose = Console.ReadLine();
            while (!int.TryParse(choose, out int value))
            {
                Console.Write("Sai. Nhập lại: ");
                choose = Console.ReadLine();
            }
            switch (int.Parse(choose))
            {
                case 0: break;
                case 1:
                    cars = InitCars();
                    Menu();
                    break;
                case 2:
                    if (cars.Count != 0)
                    {
                        Console.WriteLine("Collections vừa tạo: ");
                        Display(cars);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Chưa tạo Collections.");
                    }
                    Menu();
                    break;
                case 3:
                    if (cars.Count != 0)
                    {
                        Console.WriteLine("Danh sách sau khi xóa Car có màu Red: ");
                        Display(DeleteCar(cars, "Red"));
                    }
                    else
                    {
                        Console.WriteLine("Chưa tạo Collections.");
                    }
                    Menu();
                    break;
                case 4:
                    if (cars.Count != 0)
                    {
                        Console.WriteLine("Danh sách các Car: ");
                        Display(cars);
                    }
                    else
                    {
                        Console.WriteLine("Chưa tạo Collections.");
                    }
                    Menu();
                    break;
               

                default: Menu(); break;
            }
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
            Console.Write("Nhập số lượng xe: ");
            dynamic size = Console.ReadLine();
            while (!int.TryParse(size, out int value))
            {
                Console.Write("Sai. Nhập lại: ");
                size = Console.ReadLine();
            }
            size = int.Parse(size);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Sách {0}", i);
                Car c = new Car();
                c.AddCar();
                cars.Add(c);
            }
            return cars;
            /*
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
            return cars;*/
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
