using System;
using System.Text;
using lab5.Exercise2;
using Order;

namespace lab5
{
    
  internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Ex1
            // Console.WriteLine("Bạn đã chọn đặt hàng tạp hóa hay sản phẩm bánh mì hay chưa (r/c)");
            // var luaChon = Console.ReadLine();
            // while (true)
            // {
            //     if (luaChon == "c")
            //     {
            //         ShowMenu();
            //     } 
            //     else if (luaChon == "r")
            //     {
            //         Console.WriteLine("Bạn có muốn đặt hàng tiếp không ? (y/n)");
            //         var luaChon2 = Console.ReadLine();
            //         if (luaChon2 == "y")
            //         {
            //             ShowMenu();
            //         }
            //         else if (luaChon2 == "n")
            //         {
            //             break;
            //         }
            //         else
            //         {
            //             Console.WriteLine("Vui lòng chọn y hoặc n");
            //         }
            //     }
            //     else
            //     {
            //         Console.WriteLine("Vui lòng lựa chọn chính xác");
            //     }
            // }
            
            //Ex2
            Console.WriteLine("vui lòng nhập tên");
            var name = Console.ReadLine();
            Console.WriteLine("vui lòng nhập salary");
            var salary = double.Parse(Console.ReadLine());
            Console.WriteLine("vui lòng nhập bonus");
            var bonus = double.Parse(Console.ReadLine());
            var seniorLecture = new Ex2.SeniorLecture
            {
                Name = name,
                Salary = salary,
                Bonus = bonus
            };
            try
            {
                CheckAmount(seniorLecture);
            }
            catch (Ex2.AmountException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public static void CheckAmount(Ex2.SeniorLecture seniorLecture)
        {
            if (seniorLecture.Salary < 60000)
            {
                throw new Ex2.AmountException($"mức lương của giảng viên {seniorLecture.Name} tối thiểu phải từ 60000");
            }
            else if(seniorLecture.Bonus > 10000)
            {
                throw new Ex2.AmountException($"mức thưởng của giảng viên {seniorLecture.Name} tối đa không quá 10000");
            }
            else
            {
                Console.WriteLine("ok");
            }
        }

        //Ex1
        public static void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Vui lòng nhập lựa chọn của bạn");
                Console.WriteLine(".1 Cửa hàng tạp hóa");
                Console.WriteLine(".2 Cửa hàng bánh mì");
                Console.WriteLine(".0 Thoat");
                var luaChon3 = int.Parse(Console.ReadLine());
                if (luaChon3 == 1)
                {
                    Console.WriteLine("vui lòng nhập vào tên người dùng :");
                    var userName = Console.ReadLine();
                    Customer.Customer customer = new Customer.Customer();
                    var name = customer.AcceptsCustomerName(userName);
                    var grocery = new Grocery();
                    Console.WriteLine(name + " " + grocery.grocery());
                }else if (luaChon3 == 2)
                {
                    Console.WriteLine("vui lòng nhập vào tên người dùng :");
                    var userName = Console.ReadLine();
                    Customer.Customer customer = new Customer.Customer();
                    var name = customer.AcceptsCustomerName(userName);
                    var bakery = new Bakery();
                    Console.WriteLine(name + " " + bakery.bakery());
                }
                else if (luaChon3 == 0)
                {
                    break;
                    
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập từ 0 - 2");
                }
            }
        }
        
    }
}

namespace Customer
{
    public class Customer
    {
        public string AcceptsCustomerName(string customerName)
        {
            return customerName;
        }
    }
}


namespace Order
{
    
    public class Grocery
    {
        public string grocery()
        {
            return "đã order tạp hóa";
        }
    }

    public class Bakery
    {
        public string bakery()
        {
            return "đã order bánh mì";
        }
    }
}