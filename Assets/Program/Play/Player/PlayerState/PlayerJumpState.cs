using UnityEngine;
using UnityEngine.UI;

public class PlayerJumpState : IPlayerState
{
    // [SerializeField] private Image jumpImage;

    private PlayerObject playerObject;
    public PlayerJumpState(PlayerObject playerObject) { this.playerObject = playerObject; }

    public void EnterState()
    {
        Debug.Log("�W�����v����");
        // playerObject.SetImage(jumpImage);
        // �A�j���[�V���������Ȃ�
        playerObject.ChangeState(PlayerObject.PlayerState.Idle);
    }

    public void Update() { }

    public void ExitState() { }
}
