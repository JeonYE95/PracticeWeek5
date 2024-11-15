using UnityEngine;

public class FireArrow : ICommand
{
    private Player player;

    public FireArrow(Player player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.CastFireArrow();
    }
}