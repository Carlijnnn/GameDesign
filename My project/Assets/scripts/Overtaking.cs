using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overtaking : MonoBehaviour
{
    [SerializeField] private Transform enemyCheck;
    [SerializeField] private LayerMask enemyLayer;
    [SerializeField] private AudioSource audioOutput;
    public GameObject enemy;
    public GameObject camera;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (EnemyAvailable() && Input.GetKeyDown(KeyCode.F))
        {
            animator.SetBool("Overtaken", true);
            enemy.GetComponent<Movement>().active = true;
            audioOutput.Play(0);
            camera.GetComponent<CameraFollow>().target = enemy;
            GetComponent<Movement>().active = false;
        }
        
    }

    private bool EnemyAvailable()
    {
        return Physics2D.OverlapCircle(enemyCheck.position, 1f, enemyLayer);
    }
}
