using UnityEngine;
using System.Collections;
public class Animation : MonoBehaviour
{
    public Animator animator;

    private static float horizontalMove;

    void Update()
    {
        horizontalMove = CharacterMovement.horizontalMove;
        if(horizontalMove != 0) animator.SetTrigger("Walk");
        else animator.SetTrigger("Idle");

    }
}