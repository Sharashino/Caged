using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private Stat health;
    [SerializeField] private Stat mana;
    [SerializeField] private Stat damage;

    public void HealPlayer(int amount)
    {
        health.BaseValue += amount;
    }

    public void DamagePlayer(int amount)
    {
        health.BaseValue -= amount;

        if (health.BaseValue <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(this);
        Debug.Log("Player died!");
    }
}
