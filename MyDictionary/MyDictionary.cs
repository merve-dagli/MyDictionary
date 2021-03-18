using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<ID, GameName, GamePrice>
    {
        public MyDictionary()
        {
            liste = new (ID, GameName, GamePrice)[0];
        }
        (ID, GameName, GamePrice)[] liste;

        public void Add(ID gameId, GameName gameName, GamePrice gamePrice)
        {
            (ID, GameName, GamePrice)[] tempArray = liste;
            liste = new (ID, GameName, GamePrice)[liste.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                liste[i] = tempArray[i];
            }
            liste[liste.Length - 1] = (gameId, gameName, gamePrice);
        }
        public int Count
        {
            get { return liste.Length; }
        }

        public void Listing()
        {
            Console.WriteLine("-------Oyunlar-------");
            for (int i = 0; i < liste.Length; i++)
            {
                Console.WriteLine(liste[i]);
            }
        }
       
    }
}
