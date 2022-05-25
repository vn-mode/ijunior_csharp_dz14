using System;

namespace vn_mode_dz_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userSymbol;
            int lengthUserName;
            int lengthUserSymbol;

            Console.Write("Введите желаемое имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите желаемый символ: ");
            userSymbol = Console.ReadLine();
            lengthUserName = userName.Length + 2;
            lengthUserSymbol = userSymbol.Length;

            if (lengthUserSymbol > 1)
            {
                userSymbol = userSymbol.Substring(0, lengthUserSymbol - (lengthUserSymbol - 1));
            }

            for (int i = 0; i < lengthUserName; i++)
            {
                Console.Write(userSymbol);
            }

            Console.WriteLine();
            Console.WriteLine(userSymbol + userName + userSymbol);

            for (int i = 0; i < lengthUserName; i++)
            {
                Console.Write(userSymbol);
            }

        }
    }
}
