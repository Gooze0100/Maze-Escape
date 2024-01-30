using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] int damage = 25;

    public int GetDamage()
    {
        return damage;
    }
}
