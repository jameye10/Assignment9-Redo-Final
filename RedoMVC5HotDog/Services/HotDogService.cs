using RedoMVC5HotDog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedoMVC5HotDog.Services
{
    public class HotDogService
    {
        private static List<HotDog> hotDogs;
        static HotDogService()
        {
            hotDogs = new List<HotDog>();
            HotDog dog1 = new HotDog()
            {
                HotDogID = 1,
                HotDogName = "Jumbo Franks",
                LastPlaceAte = "Hot Dog World",
                LastTimeAte = new DateTime(),
                Rating = 5
            };
            hotDogs.Add(dog1);

            HotDog dog2 = new HotDog()
            {
                HotDogID = 2,
                HotDogName = "Chunky Jalapeno Dog",
                LastPlaceAte = "Johnny's House ",
                LastTimeAte = new DateTime(),
                Rating = 1
            };
            hotDogs.Add(dog2);

            HotDog dog3 = new HotDog()
            {
                HotDogID = 3,
                HotDogName = "50/50 Dog",
                LastPlaceAte = "New Street Cafe",
                LastTimeAte = new DateTime(),
                Rating = 3
            };
            hotDogs.Add(dog3);
        }

        public List<HotDog> listAll()
        {
            return hotDogs;
        }
        public HotDog Get(int id)
        {
            HotDog selectedDog = new HotDog();
            foreach (HotDog hotdog in hotDogs)
            {
                if (hotdog.HotDogID == id)
                {
                    selectedDog = hotdog;
                }
            }
            return selectedDog;
        }
        public void Add(HotDog hotdog)
        {
            hotDogs.Add(hotdog);
        }
        public void Remove(HotDog hotdog)
        {
            hotDogs.Remove(hotdog);
        }
    }
}