using UnityEngine;

public class IceArrow : ICommand
{
    private Player player;

    public IceArrow(Player player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.CastIceArrow();
    }
}