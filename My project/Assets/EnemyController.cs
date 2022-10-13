using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator eAnimator;
    // Start is called before the first frame update
    void Start()
    {
        eAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) && GetComponent<Movement>().active)
        {
            eAnimator.SetBool("running", true);
            
        } else if ((!Input.GetKey(KeyCode.A) || !Input.GetKey(KeyCode.D)) && GetComponent<Movement>().active)
        {
            eAnimator.SetBool("running", false);
        }

        if (Input.GetKey(KeyCode.Space) && GetComponent<Movement>().active) {
            eAnimator.SetTrigger("Jump");        }
    }
}
