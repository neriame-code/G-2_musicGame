using UnityEngine;
using UnityEngine.InputSystem;
using static PlayerObject;

public class PlayerIdleState : IPlayerState
{
    private PlayerObject playerObject;
    public PlayerIdleState(PlayerObject playerObject){ this.playerObject = playerObject; }

    public void EnterState()
    {
        if (playerObject != null && playerObject.PlayerActionMap != null)
        {
            // �A�N�V�����̎擾�ƃC�x���g�̍w��
            playerObject.PlayerActionMap.FindAction("MoveLeft").performed += OnMoveLeftPerformed;
            playerObject.PlayerActionMap.FindAction("MoveRight").performed += OnMoveRightPerformed;
            playerObject.PlayerActionMap.FindAction("SpaceAction").performed += OnSpaceActionPerformed;
            playerObject.PlayerActionMap.FindAction("JumpAction").performed += OnJumpActionPerformed;
        }
    }

    public void Update()
    {

    }

    public void ExitState()
    {
        // �I�u�W�F�N�g�j�����ɃC�x���g�̍w�ǂ�����
        if (playerObject != null)
        {
            playerObject.PlayerActionMap.FindAction("MoveLeft").performed -= OnMoveLeftPerformed;
            playerObject.PlayerActionMap.FindAction("MoveRight").performed -= OnMoveRightPerformed;
            playerObject.PlayerActionMap.FindAction("SpaceAction").performed -= OnSpaceActionPerformed;
        }
    }

    private void OnMoveLeftPerformed(InputAction.CallbackContext context){ playerObject.ChangeState(PlayerState.GoLeft); }
    private void OnMoveRightPerformed(InputAction.CallbackContext context){ playerObject.ChangeState(PlayerState.GoRight); }
    private void OnSpaceActionPerformed(InputAction.CallbackContext context){ playerObject.ChangeState(PlayerState.Roll); }

    private void OnJumpActionPerformed(InputAction.CallbackContext context) { playerObject.ChangeState(PlayerState.Jump); }
}
