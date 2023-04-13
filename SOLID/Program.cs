namespace SOLID;

class Program
{
    static void Main(string[] args)
    {

        List<IWeapon> weapons = new List<IWeapon>
        {
            new Eagle(),
            new Vandal(),
            new Bazuka()
        };
        WeaponHolder weaponHolder = new WeaponHolder(weapons);

        weaponHolder.AttackWithAll();
    
    }

}


public class WeaponHolder
{
    private readonly List<IWeapon> _weapons;

    public WeaponHolder(List<IWeapon> weapons)
    {
        _weapons = weapons;
    }

    public void AttackWithAll()
    {
        foreach (var weapon in _weapons)
        {
            weapon.Attack();
        }
    }
}

public class Eagle : IWeapon
{
    public void Attack()
    {
        Console.WriteLine("pew pew ");
    }
}

public class Bazuka : IWeapon
{
    public void Attack()
    {
        Console.WriteLine("BOOM!");
    }
}

public class Vandal : IWeapon
{
    public void Attack()
    {
        Console.WriteLine("diw diw diw");
    }
}

public interface IWeapon
{
    void Attack();
}