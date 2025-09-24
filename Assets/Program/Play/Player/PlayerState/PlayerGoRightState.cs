using UnityEngine;

public class PlayerGoRightState : IPlayerState
{
    private PlayerObject playerObject;
    public PlayerGoRightState(PlayerObject playerObject) { this.playerObject = playerObject; }

    public void EnterState()
    {
        Debug.Log("�E�ړ�����");
        playerObject.MoveToLine(PlayerObject.MoveDirection.Right); // �E�Ɉړ�
        // �A�j���[�V�������N��
        playerObject.ChangeState(PlayerObject.PlayerState.Idle);
    }

    public void Update(){}

    public void ExitState() { }
}
