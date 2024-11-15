using UnityEngine;

public class QuickSlot
{
    private ICommand[] slots;

    public QuickSlot(int slotCount)
    {
        slots = new ICommand[slotCount];
    }

    public void SetSkill(int slotIndex, ICommand skill)
    {
        if (slotIndex >= 0 && slotIndex < slots.Length)
        {
            slots[slotIndex] = skill;
        }
    }

    public void UseSkill(int slotIndex)
    {
        if (slotIndex >= 0 && slotIndex < slots.Length && slots[slotIndex] != null)
        {
            slots[slotIndex].Execute();
        }
    }
}
