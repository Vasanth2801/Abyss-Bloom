using UnityEngine;

public class PlayerIdleState : PlayerState
{
    public PlayerIdleState(Player player, PlayerStateMachine stateMachine) : base(player, stateMachine)
    {
            
    }

    public override void Enter()
    {
        Debug.Log("Enter Idle State");
    }
}
