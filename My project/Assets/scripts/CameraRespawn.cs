using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraRespawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform camera;
 


    void Update()
    {
        if (player.position.y > camera.position.y + 13.5)
        {
            SceneManager.LoadScene("DropDownLevel");
        }
        if (player.position.y < camera.position.y - 13.5)
        {
            SceneManager.LoadScene("DropDownLevel");
        }
    }
}
