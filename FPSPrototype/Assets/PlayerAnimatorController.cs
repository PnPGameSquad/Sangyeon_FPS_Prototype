using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        // "Player" 오브젝트 기준으로 자식 오브젝트인
        // "arms_assault_rifle_01" 오브젝트에 Animator 컴포넌트가 있음
        animator = GetComponentInChildren<Animator>();
    }

    public float MoveSpeed
    {
        set => animator.SetFloat("movementSpeed", value);
        get => animator.GetFloat("movementSpeed");
    }

    public void OnReload()
    {
        animator.SetTrigger("OnReload");
    }

    // Assault Rifle 마우스 우클릭 액션 (default/aim mode)
    public bool AimModeIs
    {
        set => animator.SetBool("IsAimMode", value);
        get => animator.GetBool("IsAimMode");
    }

    public void Play(string stateName, int layer, float normalizedTime)
    {
        animator.Play(stateName, layer, normalizedTime);
    }
    
    public bool CurrentAnimationIs(string name)
    {
        return animator.GetCurrentAnimatorStateInfo(0).IsName(name);
    }
}
