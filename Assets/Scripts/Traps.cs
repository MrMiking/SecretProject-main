using UnityEngine;

public class Traps : MonoBehaviour
{
    [Header("ScriptableObject")]
    [SerializeField] private PlayerStats playerStats;
    [SerializeField] private TrapsStats trapStats;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerStats.TakeDamage(trapStats.Damage);

            Destroy(gameObject);
        }
    }
}
