using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCntrlr : MonoBehaviour
{
    Animator anim;
    public CharacterCntrlr characterCntrlr;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        if (anim != null) {
            anim.SetBool("Idle S", true);
            anim.SetBool("Idle E", false);
            anim.SetBool("Idle N", false);
            anim.SetBool("Idle W", false);

            anim.SetBool("Walk S", false);
            anim.SetBool("Walk E", false);
            anim.SetBool("Walk N", false);
            anim.SetBool("Walk W", false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (anim != null) {
            if (characterCntrlr.x > 0)
            {
                SetAnimationState("E", characterCntrlr.isMoving);
            }
            else if (characterCntrlr.x < 0)
            {
                SetAnimationState("W", characterCntrlr.isMoving);
            }
            else if (characterCntrlr.y > 0)
            {
                SetAnimationState("N", characterCntrlr.isMoving);
            }
            else if (characterCntrlr.y < 0)
            {
                SetAnimationState("S", characterCntrlr.isMoving);
            }
            else if (!characterCntrlr.isMoving)
            {
                ResetWalkAnimations();
            }
        }
    }

    void SetAnimationState(string direction, bool isWalking)
    {
        anim.SetBool("Idle S", direction == "S");
        anim.SetBool("Idle E", direction == "E");
        anim.SetBool("Idle N", direction == "N");
        anim.SetBool("Idle W", direction == "W");

        anim.SetBool("Walk S", isWalking && direction == "S");
        anim.SetBool("Walk E", isWalking && direction == "E");
        anim.SetBool("Walk N", isWalking && direction == "N");
        anim.SetBool("Walk W", isWalking && direction == "W");
    }

    void ResetWalkAnimations()
    {
        anim.SetBool("Walk S", false);
        anim.SetBool("Walk E", false);
        anim.SetBool("Walk N", false);
        anim.SetBool("Walk W", false);
    }
}
