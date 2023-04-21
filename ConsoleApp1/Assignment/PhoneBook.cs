using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A.Assignment
{
    public class PhoneBook :Phone
    {

        List<string[]> PhoneList = new List<string[]>();

        public override void insertPhone(String name, String phone)
        {
            bool exist = false;
            foreach (var item in PhoneList)
            {
                if (item[0] == name)
                {
                    if (item[1] != phone)
                    {
                        item[1] += ":" + phone;
                        Console.WriteLine($"Đã thêm số điện thoại {phone} cho {name}");
                    }
                    else
                    {
                        Console.WriteLine($"Số điện thoại {phone} đã tồn tại cho {name}");
                    }
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                PhoneList.Add(new string[] { name, phone });
                Console.WriteLine($"Đã thêm {name} với số điện thoại {phone}");
            }
        }
        public override void removePhone(String name)
        {
            int count = PhoneList.RemoveAll(item => item[0] == name);
            Console.WriteLine($"Đã xóa {count} số điện thoại của {name}");
        }
        public override void updatePhone(String name, String newPhone)
        {
            foreach (var item in PhoneList)
            {
                if (item[0] == name)
                {
                    item[1] = newPhone;
                    Console.WriteLine($"Đã cập nhật số điện thoại của {name} thành {newPhone}");
                    break;
                }
            }
        }
        public override void searchPhone(String name)
        {
            foreach (var item in PhoneList)
            {
                if (item[0] == name)
                {
                    Console.WriteLine($"Số điện thoại của {name} là: {item[1]}");
                    break;
                }
            }
        }
        public override void sort()
        {
            { 
            PhoneList.Sort((x, y) => x[0].CompareTo(y[0]));
            Console.WriteLine("Đã sắp xếp danh sách theo tên người dùng");
        }
    }
    }
}
