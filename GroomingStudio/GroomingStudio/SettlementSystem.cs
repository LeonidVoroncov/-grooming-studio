using System;

public class SettlementSystem
{
    public object CheckViewPets(Visitor visitor)
    {
        var check = new CheckViewPets();
        if (check.Check(visitor.ViewPet))
        {
            return 100 + 50 * ((int)visitor.BreedPet);
        }
        return 150 + 70 * ((int)visitor.BreedPet);
    }
}
