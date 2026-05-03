using System;

class Program
{
    static void Main()
    {
        ArmorFactory factory = new HeavyArmorFactory();

        IArmor myArmor = factory.CreateArmor();

        myArmor.GetDefense();
    }
}
