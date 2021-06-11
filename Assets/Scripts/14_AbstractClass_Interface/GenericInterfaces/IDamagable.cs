
namespace Section.AbstractClass_Interface.GenericInterfaces
{
    public interface IDamagable<T>
    {
        int Health { get; set; }

        //void Damage(int damageAmount);
        //void Damage(float damageAmount);
        void Damage(T damageAmmount);
    }
}