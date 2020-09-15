using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInviteSite.Models
{
    public static class Repository
    {
        private static List<GuesResponse> _responses = new List<GuesResponse>(); //Создаем коллекцию типа GuesResponse
        public static IEnumerable<GuesResponse> Responses //?реализуем интерфейс? хз че это
        {
            get
            {
                return _responses;  //Свойство гет, которое возвращает коллекцию GuesResponse
            }
        }
        public static void AddResponse(GuesResponse response) // Статический метод, который принимает параметры типа GuesPresonse и добавляет их в коллекцию
        {
            _responses.Add(response);

        }
    }
}
