using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Program
    {
        class Google
        {
            public string Search()
            {
                return "GoogleSearch";
            }
            public string Images()
            {
                return "GoogleImages";
            }
            public string Mail()
            {
                return "Gmail";
            }
            public string Maps()
            {
                return "GoogleMaps";
            }
            public string Docs()
            {
                return "GoogleDocs";
            }
        }

        class Yandex
        {
            public string Search()
            {
                return "YandexSearch";
            }
            public string Images()
            {
                return "YandexImages";
            }
            public string Mail()
            {
                return "@yandex";
            }
            public string Maps()
            {
                return "YandexMaps";
            }
            public string Docs()
            {
                return "YandexDocs";
            }
        }

        class Brousers
        {
            string User_do;
            public string Web_service()
            {
                Google g = new Google();
                User_do = g.Docs();

                Yandex y = new Yandex();
                User_do += " ," + y.Mail();

                return User_do;
            }
        }
        static void Main(string[] args)
        {
            Brousers brousers = new Brousers();
            Console.WriteLine(brousers.Web_service());
            Console.ReadKey();
        }
    }
}
