using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationBehaviour : MonoBehaviour
{
    [Header("Component References")]
    public Animator playerAnimator;

    //Animation String IDs
    private int playerMovementAnimationID;
    private int playerAttackAnimationID;
    private int playerJumpAnimationID;
    private int playerBackFlipAnimationID;

    public void SetupBehaviour()
    {
        SetupAnimationIDs();
    }

    void SetupAnimationIDs()
    {
        playerMovementAnimationID = Animator.StringToHash("Movement");
        playerAttackAnimationID = Animator.StringToHash("Attack");
        playerJumpAnimationID = Animator.StringToHash("Jump");
        playerBackFlipAnimationID = Animator.StringToHash("BackFlip");
    }

    public void UpdateMovementAnimation(float movementBlendValue)
    {
        playerAnimator.SetFloat(playerMovementAnimationID, movementBlendValue);
    }

    public void PlayAttackAnimation()
    {
        playerAnimator.SetTrigger(playerAttackAnimationID);
    }

    public void PlayJumpAnimation()
    {
        playerAnimator.SetTrigger(playerJumpAnimationID);
    }

    public void PlayBackFlipAnimation()
    {
        playerAnimator.SetTrigger(playerBackFlipAnimationID);
    }
}
