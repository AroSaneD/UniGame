using UnityEngine;
using System.Collections;

public abstract class Humanoid : MonoBehaviour, IHumanoid
{

    protected int Speed;
    protected int MaxHealth;
    protected int Health;
    protected int Armor;
    protected int Damage;

    public void GetDamaged(int damage)
    {
        this.Health -= damage;
    }

    public void GetAffected(StatusEffect effect)
    {
        //Todo: Implement status effects
    }

    public void Die()
    {
        //Todo: Implement death
    }


    void Start()
    {
        this.Health = this.MaxHealth;
        this.Armor = 0;
    }


    void Update()
    {
        if (this.Health <= 0)
        {
            this.Die();
        }
    }
}
