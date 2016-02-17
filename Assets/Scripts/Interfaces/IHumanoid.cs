using UnityEngine;
using System.Collections;

public interface IHumanoid : IDamagable
{
    void GetAffected(StatusEffect effect);

    void Die();
}
