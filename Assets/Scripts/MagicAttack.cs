using UnityEngine;

public class MagicAttack : AttackStrategy
{
    public void Attack(Vector3 position, Vector3 direction)
    {
        int numberOfProjectiles = 8;
        float angleStep = 360f / numberOfProjectiles;

        for (int i = 0; i < numberOfProjectiles; i++)
        {
            float angle = i * angleStep;
            Vector3 projectileDir = new Vector3(Mathf.Cos(angle * Mathf.Deg2Rad), 0, Mathf.Sin(angle * Mathf.Deg2Rad));
            Vector3 nextPosition = position + projectileDir * 5f;
        }
    }
}