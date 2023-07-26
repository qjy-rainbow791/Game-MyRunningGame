using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Control the player's animation script
public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private bool isJump;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        isJump = false;
        animator = GetComponent<Animator>();
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        isJump = !playerController.CanJump();
        animator.SetBool("IsJump", isJump);
    }
}
