
namespace Section.AbstractClass_Interface.Interface
{
    public interface IDamagable
    {
        int Health { get; set; }

        void Damage(int damageAmount);
    }
}