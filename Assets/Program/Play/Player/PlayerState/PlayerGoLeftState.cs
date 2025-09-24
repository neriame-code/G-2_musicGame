using UnityEngine;

public class PlayerGoLeftState : IPlayerState
{
    private PlayerObject playerObject;
    public PlayerGoLeftState(PlayerObject playerObject) { this.playerObject = playerObject; }

    public void EnterState()
    {
        Debug.Log("���ړ�����");
        playerObject.MoveToLine(PlayerObject.MoveDirection.Left); // ���Ɉړ�
        // �A�j���[�V�������N��
        playerObject.ChangeState(PlayerObject.PlayerState.Idle);
    }

    public void Update() { }

    public void ExitState() { }
}
