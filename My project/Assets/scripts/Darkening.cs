using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darkening : MonoBehaviour
{
    SpriteRenderer sprite;
    float alphaLevel;
    float alphaFactor;
    public float totallyDarkHeight = 1000f;
 
    // Use this for initialization
    void Start () {
        alphaFactor = 1 / totallyDarkHeight;
    }
 
    // Update is called once per frame
    void Update () {
        alphaLevel = alphaFactor * transform.position.y;
        if (alphaLevel > 1){
            alphaLevel = 1;
        }
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = new Color (00, 00, 00, alphaLevel);
    }
}
