using UnityEngine;

public class LegendJumpDownState : LegendBaseState
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime <= 0.3f)
        {
            legendController.MoveAndRotate();
        }
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Managers.SoundManager.Play(SoundType.SFX,StringLiteral.SFX_JUMPLANDING,legendController.LegendType);
    }
}
