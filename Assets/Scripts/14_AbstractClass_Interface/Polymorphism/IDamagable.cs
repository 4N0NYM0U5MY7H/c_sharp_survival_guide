
namespace Section.AbstractClass_Interface.Polymorphism
{
    public interface IDamagable
    {
        int Health { get; set; }

        //void Damage(int damageAmount);
        //void Damage(float damageAmount);
        void Damage(int damageAmmount);
    }
}