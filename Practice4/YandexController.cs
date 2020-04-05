using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Yandex : IBrousers
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
            return "@yandex.ru";
        }
        public string Maps()
        {
            return "YandexMaps";
        }
        public string Docs()
        {
            return "YandexDocs";
        }
        public string Translate()
        {
            return "YandexTranslate";
        }
        public string News()
        {
            return "YandexNews";
        }
        public string Game()
        {
            return "YandexPlay";
        }
        public string Calendar()
        {
            return "YandexCalendar";
        }
        public string Drive()
        {
            return "YandexDisc";
        }

        public string Weather()
        {
            return "YandexWeather";
        }
    }
}
