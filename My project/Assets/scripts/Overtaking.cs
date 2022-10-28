using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overtaking : MonoBehaviour
{
    [SerializeField] private Transform enemyCheck;
    [SerializeField] private LayerMask enemyLayer;
    public GameObject enemy;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (EnemyAvailable() && Input.GetKeyDown(KeyCode.F))
        {
            enemy.GetComponent<Movement>().active = true;
            camera.GetComponent<CameraFollow>().target = enemy;
            GetComponent<Movement>().active = false;
        }
        
    }

    private bool EnemyAvailable()
    {
        return Physics2D.OverlapCircle(enemyCheck.position, 1f, enemyLayer);
    }
}
