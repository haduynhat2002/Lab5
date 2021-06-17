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
            var highSchoolTeacher = new HighSchoolTeacher
            {
                IdentityNumber = "A001",
                FullName = "Nhat Ha Duy",
                BaseSalary = 100,
                SkillLever =  1,
                SeniorLecture = 60000,
                Bonus = 1000,
                HighSchoolTeacherCode = "TEACHER001"
            };
            var universityTeacher = new UniversityTeacher
            {
                IdentityNumber = "A002",
                FullName = "Ha Duy Nhat",
                BaseSalary = 100,
                SkillLever =  1,
                SeniorLecture = 30000,
                Bonus = 9000,
                UniversityTeacherCode = "UNIVERSITY_TEACHER002",
                EnglishSkillLever = 2
            };
            Console.WriteLine(highSchoolTeacher.CalculateSalary());
            Console.WriteLine(universityTeacher.CalculateSalary());
            
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