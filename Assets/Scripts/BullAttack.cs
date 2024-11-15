using UnityEngine;

public class BullAttack : AttackStrategy
{
    // 직선으로 진행하는 총알
    public void Attack(Vector3 position, Vector3 direction)
    {
        float speed = 10f;
        Vector3 bulletposition = position + direction.normalized * speed;
    }
}