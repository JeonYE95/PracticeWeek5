using UnityEngine;

public class BullAttack : AttackStrategy
{
    // �������� �����ϴ� �Ѿ�
    public void Attack(Vector3 position, Vector3 direction)
    {
        float speed = 10f;
        Vector3 bulletposition = position + direction.normalized * speed;
    }
}