using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AttackStrategy     // �������̽��� ���� ���� ����
{
    void Attack(Vector3 position, Vector3 direction);
}
