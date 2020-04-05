using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Program
    {
        delegate void Select();
        static Brouser brous;
        static void Main(string[] args)
        {
            Console.WriteLine("В программе выбор нужного браузера или сервиса осуществляется стрелками <вверх>, <вниз> и <Enter>");
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();

            string[] items = { "Google", "Yandex", "Baidu", "Выход" };
            Select[] firstSelect = new Select[] { Google, Yandex, Baidu, Exit };
            ConsoleMenu menu = new ConsoleMenu(items);
            int menuResult=0;

            do
            {
                menuResult = menu.PrintMenu();
                firstSelect[menuResult]();

                if (menuResult == items.Length - 1) break;

                string[] second_items = { "Поиск", "Карта", "Календарь", "Картинки", "Почта", "Документы", "Переводчик", "Новости", "Игры", "Диск", "Погода", "Выход" };
                Select[] secondSelect = new Select[] {Search, Map, Calendar, Images, Mail, Docs, Translate, News, Games, Drive, Weather, Exit };
                ConsoleMenu service_menu = new ConsoleMenu(second_items);
                int service_menuResult;
                do
                {
                    service_menuResult = service_menu.PrintMenu();
                    secondSelect[service_menuResult]();

                    if (service_menuResult == second_items.Length - 1) break;

                    Console.WriteLine("Для продолжения нажмите любую клавишу");
                    Console.ReadKey();


                } while (service_menuResult != second_items.Length - 1);

            } while (menuResult != items.Length - 1);

            
            Console.ReadKey();
        }
        static void Google()
        {
            brous = new Brouser(new Google());
        }

        static void Yandex()
        {
            brous = new Brouser(new Yandex());
        }

        static void Baidu()
        {
            brous = new Brouser(new Baidu());
        }
       
        static void Search()
        {
            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine(brous.Web_service_Search());
            Console.WriteLine("************************");
            Console.WriteLine();
        }
        static void Map()
        {
            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine(brous.Web_service_Maps());
            Console.WriteLine("************************");
            Console.WriteLine();
        }
        static void Calendar()
        {
            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine(brous.Web_service_Calendar());
            Console.WriteLine("************************");
            Console.WriteLine();
        }
        static void Images()
        {
            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine(brous.Web_service_Images());
            Console.WriteLine("************************");
            Console.WriteLine();
        }
        static void Mail()
        {
            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine(brous.Web_service_Mail());
            Console.WriteLine("************************");
            Console.WriteLine();
        }
        static void Docs()
        {
            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine(brous.Web_service_Docs());
            Console.WriteLine("************************");
            Console.WriteLine();
        }
        static void Translate()
        {
            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine(brous.Web_service_Translate());
            Console.WriteLine("************************");
            Console.WriteLine();
        }
        static void News()
        {
            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine(brous.Web_service_News());
            Console.WriteLine("************************");
            Console.WriteLine();
        }
        static void Games()
        {
            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine(brous.Web_service_Game());
            Console.WriteLine("************************");
            Console.WriteLine();
        }
        static void Drive()
        {
            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine(brous.Web_service_Drive());
            Console.WriteLine("************************");
            Console.WriteLine();
        }
        static void Weather()
        {
            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine(brous.Web_service_Weather());
            Console.WriteLine("************************");
            Console.WriteLine();
        }
        static void Exit()
        {
            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine("Good bye!");
            Console.WriteLine("************************");
            Console.WriteLine();
        }
        
        class ConsoleMenu
        {
            string[] _Items;
            int counter = 0;
            public ConsoleMenu(string[] Items)
            {
                _Items = Items;
            }

            /// <summary>
            /// Функция вывода текста на экран
            /// </summary>
            /// <returns>номер выбранного действия</returns>
            public int PrintMenu()
            {
                ConsoleKeyInfo key;
                do
                {
                    Console.Clear();
                    for (int i = 0; i < _Items.Length; i++)
                    {
                        if (counter == i)
                        {
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(_Items[i]);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                            Console.WriteLine(_Items[i]);

                    }
                    key = Console.ReadKey();
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        counter--;
                        if (counter == -1) counter = _Items.Length - 1;
                    }
                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        counter++;
                        if (counter == _Items.Length) counter = 0;
                    }
                }
                while (key.Key != ConsoleKey.Enter);
                return counter;
            }

        }
    }
}