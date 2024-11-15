using UnityEngine;

public class ThrowingAttack : AttackStrategy
{
    public void Attack(Vector3 position, Vector3 direction)
    {
        float throwAngle = 5f;
        float gravity = -5f;

        float radianAngle = throwAngle * Mathf.Deg2Rad;
        Vector3 velocity = new Vector3(direction.x * Mathf.Cos(radianAngle), 
                           Mathf.Sin(radianAngle), direction.z * Mathf.Cos(radianAngle)) * 10f;
    }
}