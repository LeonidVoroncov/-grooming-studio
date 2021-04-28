using System;

namespace GroomingStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            var visitor = new Visitor[]
            {
                new Visitor("Василий", "Васильевич", "Васнецов", "88005575356", "Барсик", View.Cat, Breed.smallShorthair),
                new Visitor("Никита", "Антотович", "Иванов", "88006786788", "Персик", View.Dog, Breed.mediumLongHaired),
                new Visitor("Коля", "Васильевич", "Никитин", "88045668776", "Тузик", View.Dog, Breed.bigLongHaired),
                new Visitor("Михаил", "Динисович", "Кондраков", "88078056745", "Рыжик", View.Cat, Breed.smallLongHaired)
            };

            var settlementSystem = new SettlementSystem();
            foreach (var element in visitor)
            {
                Console.WriteLine($"Пришел {element.FirstName}, домашний питомец {element.NamePet}, " +
                    $"заплатил за стрижку питомца: {settlementSystem.CheckViewPets(element)}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
