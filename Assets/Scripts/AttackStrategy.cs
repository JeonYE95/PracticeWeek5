using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AttackStrategy     // 인터페이스로 공격 패턴 구현
{
    void Attack(Vector3 position, Vector3 direction);
}
