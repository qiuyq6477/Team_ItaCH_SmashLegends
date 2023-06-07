using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private float _currentMoveSpeed = 5.4f;

    internal Vector3 moveDirection;
    private Animator _animator;
    private PlayerStatus _playerStatue;
    private void Start()
    {
        _playerStatue = GetComponent<PlayerStatus>();
        _animator = GetComponent<Animator>();
    }

    // 이동방향을 바라보도록 이동방향으로 캐릭터 회전
    public void MoveAndRotate()
    {
        if (moveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveDirection);
            transform.Translate(Vector3.forward * (_currentMoveSpeed * Time.deltaTime));
        }
        else
        {
            _animator.SetBool(AnimationHash.Run, false);
        }
    }

    public void MoveHellper(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        if (input != null)
        {
            moveDirection = new Vector3(input.x, 0, input.y);
            _animator.SetBool(AnimationHash.Run, true);
        }
    }
}