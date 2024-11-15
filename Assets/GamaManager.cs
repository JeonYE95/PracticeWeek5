using UnityEngine;
public class GameManager : MonoBehaviour
{
    private Player player;
    private QuickSlot quickSlot;

    void Start()
    {
        player = FindObjectOfType<Player>();
        quickSlot = new QuickSlot(2);  

        quickSlot.SetSkill(0, new FireArrow(player));
        quickSlot.SetSkill(1, new IceArrow(player));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) quickSlot.UseSkill(0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) quickSlot.UseSkill(1);
    }
}
