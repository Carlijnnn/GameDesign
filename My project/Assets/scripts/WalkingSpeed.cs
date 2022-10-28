using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingSpeed : MonoBehaviour
{
    private Animator mAnimator;

    [SerializeField] private Rigidbody2D RigidB;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
     mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var vel = RigidB.velocity;
        speed = vel.magnitude;
        if (mAnimator != null){
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {
                if (GetComponent<Movement>().active){
                mAnimator.SetBool("Walking", true);
                }
            } else if (Input.GetKeyDown(KeyCode.F))
            {
                mAnimator.SetTrigger("Caster");
            } else if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            {
                mAnimator.SetBool("Walking", false);
            }
        }
    }
}
