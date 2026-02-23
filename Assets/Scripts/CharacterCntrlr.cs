using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCntrlr : MonoBehaviour
{
    Transform playerTrans;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        playerTrans = GetComponent<Transform>();
        anim = GetComponent<Animator>();

        anim.SetBool("Idle S", true);
        anim.SetBool("Idle E", false);
        anim.SetBool("Idle N", false);
        anim.SetBool("Idle W", false);

        anim.SetBool("Walk S", false);
        anim.SetBool("Walk E", false);
        anim.SetBool("Walk N", false);
        anim.SetBool("Walk W", false);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 velocity = new Vector2(x, y);

        playerTrans.Translate(velocity * Time.deltaTime * 1.5f);

        bool isMoving = velocity.magnitude > 0;

        if (x > 0)
        {
            SetAnimationState("E", isMoving);
        }
        else if (x < 0)
        {
            SetAnimationState("W", isMoving);
        }
        else if (y > 0)
        {
            SetAnimationState("N", isMoving);
        }
        else if (y < 0)
        {
            SetAnimationState("S", isMoving);
        }
        else if (!isMoving)
        {
            ResetWalkAnimations();
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
