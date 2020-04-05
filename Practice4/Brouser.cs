using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    
    class Brouser
    {
        IBrousers user_brouser;

        public Brouser(IBrousers brous)
        {
           user_brouser = brous;
        }

        /// <summary>
        /// Возвращает веб-сервис Поиск от указанного браузера
        /// </summary>
        /// <returns>Поиск</returns>
        public string Web_service_Search()
        {
            return user_brouser.Search();
        }
        /// <summary>
        /// Возвращает веб-сервис Картинки от указанного браузера
        /// </summary>
        /// <returns>Картинки</returns>
        public string Web_service_Images()
        {
            return user_brouser.Images();
        }
        /// <summary>
        /// Возвращает веб-сервис Почта от указанного браузера
        /// </summary>
        /// <returns>Почты</returns>
        public string Web_service_Mail()
        {
            return user_brouser.Mail();
        }
        /// <summary>
        /// Возвращает веб-сервис Карты от указанного браузера
        /// </summary>
        /// <returns>Карты</returns>
        public string Web_service_Maps()
        {
            return user_brouser.Maps();
        }
        /// <summary>
        /// Возвращает веб-сервис Документы от указанного браузера
        /// </summary>
        /// <returns>Документы</returns>
        public string Web_service_Docs()
        {
            return user_brouser.Docs();
        }
        /// <summary>
        /// Возвращает веб-сервис Переводчик от указанного браузера
        /// </summary>
        /// <returns>Переводчик</returns>
        public string Web_service_Translate()
        {
            return user_brouser.Translate();
        }
        /// <summary>
        /// Возвращает веб-сервис Новости от указанного браузера
        /// </summary>
        /// <returns>Новости</returns>
        public string Web_service_News()
        {
            return user_brouser.News();
        }
        /// <summary>
        /// Возвращает веб-сервис Игры от указанного браузера
        /// </summary>
        /// <returns>Игры</returns>
        public string Web_service_Game()
        {
            return user_brouser.Game();
        }
        /// <summary>
        /// Возвращает веб-сервис Календарь от указанного браузера
        /// </summary>
        /// <returns>Календарь</returns>
        public string Web_service_Calendar()
        {
            return user_brouser.Calendar();
        }
        /// <summary>
        /// Возвращает веб-сервис Диск от указанного браузера
        /// </summary>
        /// <returns>Диск</returns>
        public string Web_service_Drive()
        {
            return user_brouser.Drive();
        }
        /// <summary>
        /// Возвращает веб-сервис Погода от указанного браузера
        /// </summary>
        /// <returns>Погода</returns>
        public string Web_service_Weather()
        {
            return user_brouser.Weather();
        }
    }
}
