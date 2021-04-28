using System;


public class Visitor
{
    public string FirstName { get; }

    public string MiddleName { get; }

    public string LastName { get; }

    public string PhoneNumber { get; }

    public string NamePet { get; }//имя//

    public View ViewPet { get; }//вид//    

    public Breed BreedPet { get; }//порода//

    public Visitor(string firstName, string middleName, string lastName, string phoneNumber,
        string namePet, View viewPet, Breed breedPet) {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        NamePet = namePet;
        ViewPet = viewPet;
        BreedPet = breedPet;
    }
}