using System;

namespace tastCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Пользователь вводит два числа. Вывести на экран большее
            ///
            Console.WriteLine("Enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Bigger is:" + firstNumber);
            }
            else
            {
                Console.WriteLine("Bigger is:" + secondNumber);
            }
            Console.ReadKey();




            //            Пользователь вводит слово «мяу» или слово «гав» если слово
            //введенное пользователем «мяу» вывести на экран «Покорми кота»
            //иначе «Погуляй с собакой»
            Console.WriteLine("Enter мяу or гав");
            string word = Console.ReadLine();
            if (word == "мяу")
            {
                Console.WriteLine("Покорми кота");
            }
            else if (word == "гав")
            {
                Console.WriteLine("Погуляй с собакой");
            }
            Console.ReadKey();



            //            Пользователь вводит номер месяца если месяц 1,2,12 вывести на экран
            //«Зима»; 3,4,5 – «Весна»; 6 - 8 – «Лето»; 9 - 11 – «Осень». В любом другом
            //    случае «На этой планете такого месяца нет»
            Console.WriteLine("Enter number of month");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            if (monthNumber == 1 | monthNumber == 2 | monthNumber == 12)
            {
                Console.WriteLine("Зима»;");
            }
            else if (monthNumber == 3 | monthNumber == 4 | monthNumber == 5)
            {
                Console.WriteLine("Весна");
            }
            else if (monthNumber == 6 | monthNumber == 7 | monthNumber == 8)
            {
                Console.WriteLine("Лето");
            }
            else if (monthNumber == 9 | monthNumber == 10 | monthNumber == 11)
            {
                Console.WriteLine("Осень");
            }
            else
            {
                Console.WriteLine("На этой планете такого месяца нет");
            }
            Console.ReadKey();



            ////            Пользователь вводит число 1 или 0 с помощью одной строки кода
            ////вывести на экран «Хорошо» если пользователь ввел 1 или «Плохо»
            ////если пользователь ввел 0
            Console.WriteLine("Enter 1 or 0");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            if (monthNumber == 1)
            {
                Console.WriteLine("Хорошо");
            }
            else if (monthNumber == 0)
            {
                Console.WriteLine("Плохо");
            }
            Console.ReadKey();



            //            Вывести название дня недели по его номеру(1 - понедельник, 7 -
            //воскресенье)
            Console.WriteLine("Enter number of week");
            int monthOfWeek = Convert.ToInt32(Console.ReadLine());
            if (monthOfWeek == 1)
            {
                Console.WriteLine("понедельник");
            }
            else if (monthOfWeek == 2)
            {
                Console.WriteLine("вторник");
            }
            else if (monthOfWeek == 3)
            {
                Console.WriteLine("среда");
            }
            else if (monthOfWeek == 4)
            {
                Console.WriteLine("четверг");
            }
            else if (monthOfWeek == 5)
            {
                Console.WriteLine("пятница");
            }
            else if (monthOfWeek == 6)
            {
                Console.WriteLine("суббота");
            }
            else if (monthOfWeek == 7)
            {
                Console.WriteLine("воскресенье");
            }
            Console.ReadKey();



            //            Служба такси заказала вам программу, которая спрашивает количество
            //километров и количество минут простоя, а дальше считает так: первые
            //5 километров(или до 5 км) 20 гривен, каждый следующий километр 3
            //гривны, плюс простой 1 грн за 1 минуту.Программа должна посчитать
            //и сказать общую сумму оплаты за поездку.
            Console.WriteLine("Введите количество километров");
            int km = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество минут простоя");
            int time = Convert.ToInt32(Console.ReadLine());
            if (km < 5)
            {
                Console.WriteLine("Сумма к оплате:" + (time + 20));
            }
            else
            {
                Console.WriteLine("Сумма к оплате:" + ((km - 5) * 3 + time + 20));
            }
            Console.ReadKey();



            //            Дано натуральное число.Выяснить, является ли оно простым, т.е.
            //делится только на 1 и на само себя.
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool prost = true;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            if (prost)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }
            //Console.ReadKey();



            //            Вы организатор лотереи.Пользователь вводит ставку.Вы бросаете
            //12 - гранный кубик.Если выпадают значения от 1 до 5, пользователь
            //проиграл.Если выпадают значения от 6 до 8, пользователь получает
            //свою ставку обратно.Если выпало от 9 до 11, пользователь получает
            //двойную ставку, а если выпало 12 - ставку умноженную на 10.После
            //окончания игры покажите пользователю, сколько он выиграл.
            Console.WriteLine("Введите свою ставку");
            int number = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int i = rnd.Next(1, 13);
            Console.WriteLine("Число на кубике:" + i);
            if (i >= 1 & i <= 5)
            {
                Console.WriteLine("Вы проиграли");
            }
            else if (i >= 6 & i <= 8)
            {
                Console.WriteLine("К вам вернулась ваша ставка");
            }
            else if (i >= 9 & i <= 11)
            {
                Console.WriteLine("Вы удвоили свою ставки, теперь она составляет:" + (number * 2));
            }
            else if (i == 12)
            {
                Console.WriteLine("Ваша ставка *10, теперь она составляет:" + (number * 10));
            }
            Console.ReadKey();



            //            Сделать программу перевода валют. Вводится сумма, потом
            //выбирается вид валюты – гривны или доллары или евро, программа
            //переводит в две другие валюты. Текущий курс валюты считать
            //известным.
            Console.WriteLine("Введите сумму для конвертации");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Определите валюту конвертации, доступно: гривна, доллар, евро");
            string currency = Console.ReadLine();
            double currencyDollarHrn = 23.72;
            double currencyEuroHrn = 26.23;
            double currencyHrnDollar = 0.042;
            double currencyEuroDollar = 1.11;
            double currencyHrnEuro = 0.038;
            double currencyDollarEuro = 0.90;
            switch (currency)
            {
                case "гривна":
                    Console.WriteLine(number + "грн равно " + number * currencyHrnDollar + "дол или " + number * currencyHrnEuro + "евро");
                    break;
                case "доллар":
                    Console.WriteLine(number + "дол равно " + number * currencyDollarHrn + "грн или " + number * currencyDollarEuro + "евро");
                    break;
                case "евро":
                    Console.WriteLine(number + "евро равно " + number * currencyEuroHrn + "грн или " + number * currencyEuroDollar + "дол");
                    break;
                default:
                    Console.WriteLine("Выбор не допустимой валюты");
                    break;
            }
            //Console.ReadKey();



            //            Вывести на экран таблицу умножения на N от 1 до 20 где N число
            //введенное пользователем 
            Console.WriteLine("Enter the number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            int i = 0;
            for (i = 0; i <= 20; i++)
            {
                double number2 = number1 * i;
                Console.WriteLine("{0}*{1} = {2}", number1, i, number2);
            }
            Console.ReadKey();



            //Пользователь вводит число вывести на экран количество разрядов в этом числе
            Console.WriteLine("Введите целое число");
            string str = Console.ReadLine();
            var chars = str.ToCharArray();
            Console.WriteLine("В этом числе " + chars.Length + " разрядов");
            Console.ReadKey();



            //            Программа загадывает число от 1 до 146.Пользователь пытается его
            //угадать.В случае неверного ответа программа дает подсказку
            //«больше» или «меньше»
            Console.WriteLine("Enter the number");
            int x = 0, num = 0;
            Random random = new Random();
            num = random.Next(1, 146);
            do
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (num == x)
                {
                    Console.WriteLine("Win");
                    break;
                }
                else if (x < num)
                {
                    Console.WriteLine("Number is More");
                }
                else if (x > num)
                {
                    Console.WriteLine("Number is Less");
                }
            } while (true);



            //            12.Выведите все точные квадраты натуральных чисел, которые(квадраты)
            //меньше заданного числа N. (натуральные - это числа, которые мы
            //используем при счете: 1, 2, 3 и т.д.)
            Console.WriteLine("Enter the number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            int i = 1;
            for (i = 1; i < number1;)
            {
                double number2 = i * i;
                Console.WriteLine(number2);
                i++;
            }
            Console.ReadKey();



            //            Прочитать с клавиатуры 5 целых чисел, подсчитать их среднее
            //арифметическое и сообщить его пользователю
            Console.WriteLine("Enter the  1 number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  2 number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  3 number");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  4 number");
            int number4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  5 number");
            int number5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Averege is " + (number1 + number2 + number3 + number4 + number5) / 5);



            //            14.Создать 5 случайных целых чисел, подсчитать их среднее
            //арифметическое и сообщить его пользователю
            Random rnd1 = new Random();
            int number1 = rnd1.Next(1, 1000);
            Console.WriteLine("Число 1:" + number1);
            Random rnd2 = new Random();
            int number2 = rnd2.Next(1, 1000);
            Console.WriteLine("Число 2:" + number2);
            Random rnd3 = new Random();
            int number3 = rnd3.Next(1, 1000);
            Console.WriteLine("Число 3:" + number3);
            Random rnd4 = new Random();
            int number4 = rnd4.Next(1, 1000);
            Console.WriteLine("Число 4:" + number4);
            Random rnd5 = new Random();
            int number5 = rnd5.Next(1, 1000);
            Console.WriteLine("Число 5:" + number5);
            Console.WriteLine("среднее " + (number1 + number2 + number3 + number4 + number5) / 5);



            //            У гусей и кроликов вместе 64 лапы.Сколько может быть кроликов и
            //гусей(указать все сочетания) ?            
            int total = 64;
            int quse = 0;
            int rabbit = 0;
            for (quse = 0; quse <= total; quse++)
            {
                for (rabbit = 0; rabbit <= total / 2; rabbit++)
                {
                    if (2 * quse + 4 * rabbit == total)
                    {
                        Console.WriteLine("Гусей " + quse + " кролей " + rabbit);
                    }
                }
            }



            //            Напишите программу, которая будет «спрашивать» правильный
            //пароль, до тех пор, пока он не будет введен. Правильный пароль пусть
            //будет «root». Если пароль не верный, программа должна сказать
            //"Неверный пароль!"
            Console.WriteLine("Введите пароль");
            string pass = Console.ReadLine();
            if (pass != "root")
            {
                Console.WriteLine("Неверный пароль!");
            }



        }
    }
}