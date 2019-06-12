using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{

    public class EmydexFarmSystem
    {
        List<object> animalList;

        public EmydexFarmSystem()
        {
            this.animalList = new List<object>();
        }

        //TEST 1
        public void Enter(object animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            this.animalList.Add(animal);
            Console.WriteLine("{0} has entered the Emydex farm", animal.GetType().Name);
        }

        //TEST 2
        public void MakeNoise()
        {
            foreach (var item in this.animalList)
            {
                Console.WriteLine(item.GetType().GetMethod("Talk").Invoke(item, null));
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (var item in this.animalList)
            {
                if (item.GetType().GetMethod("ProduceMilk") != null)
                {
                    Console.WriteLine(item.GetType().GetMethod("ProduceMilk").Invoke(item, null));
                }

            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            foreach (var item in this.animalList)
            {
                Console.WriteLine(item.GetType().GetMethod("Release").Invoke(item, null));
            }
            Console.WriteLine("Emydex Farm is now empty");
        }
    }
}