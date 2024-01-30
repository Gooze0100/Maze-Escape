using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;
    GameManager gameManager;

    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        DamageDealer damageDealer = other.GetComponent<DamageDealer>();

        if (damageDealer != null)
        {
            if (other.gameObject.tag == "Enemy")
            {
                TakeDamage(damageDealer.GetDamage());
            }
        }
    }

    void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        gameManager.LoadDefeatScene();
    }

    public int GetHealth()
    {
        return health;
    }
}
