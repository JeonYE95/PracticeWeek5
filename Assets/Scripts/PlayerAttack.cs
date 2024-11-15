using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private BullAttack bullAttack = new BullAttack();
    private MagicAttack magicAttack = new MagicAttack();
    private ThrowingAttack throwingAttack = new ThrowingAttack();

    public void UseBullAttack(Vector3 position, Vector3 direction)
    {
        bullAttack.Attack(position, direction);
    }

    public void UseMagicAttack(Vector3 position, Vector3 direction)
    {
        magicAttack.Attack(position, direction);
    }

    public void UseThrowingAttack(Vector3 position, Vector3 direction)
    {
        throwingAttack.Attack(position, direction);
    }
}