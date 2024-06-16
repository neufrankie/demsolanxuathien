using System;

namespace CountCharacterInString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bước 1: Khai báo một chuỗi và gán cho nó một giá trị
            string str = "Hello, welcome to the world of C#!";

            // Bước 2: Khai báo một biến ký tự và gán hoặc nhập từ bàn phím một giá trị
            Console.Write("Nhap vao mot ky tu: ");
            char character = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Để xuống dòng sau khi nhập ký tự

            // Bước 3: Khai báo biến count và gán giá trị 0, để lưu số ký tự đếm được trong chuỗi
            int count = 0;

            // Bước 4: Sử dụng vòng lặp duyệt từng ký tự trong chuỗi. Trong quá trình duyệt: so sánh nếu ký tự trong chuỗi bằng ký tự nhập vào thì tăng biến đếm lên 1
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == character)
                {
                    count++;
                }
            }

            // Bước 5: In ra giá trị biến đếm
            Console.WriteLine($"So lan xuat hien cua ky tu '{character}' trong chuoi là: {count}");
        }
    }
}
