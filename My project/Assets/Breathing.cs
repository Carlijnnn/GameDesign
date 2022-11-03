using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breathing : MonoBehaviour
{
    [SerializeField] private AudioSource breathSource;
    public GameObject Angel;
    public AudioSource chase;
    public GameObject MainCamera;
    public AudioSource music;

    // Start is called before the first frame update
    void Start()
    {
        //chase = Angel.GetComponent<AudioSource>();
        //music = MainCamera.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 0 && !breathSource.isPlaying) {
            breathSource.Play();
        } else if (transform.position.y > 3 && breathSource.isPlaying) {
            chase.volume = (float)0.2;
            music.volume = (float)0.2;
            breathSource.volume = (50 + (transform.position.y/20) * 100)/100;
        } else if (transform.position.y < 0 && breathSource.isPlaying) {
            breathSource.Pause();
        }
    }
}
