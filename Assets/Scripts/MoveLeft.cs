using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Creatubg a variable to store the BirdController script
    BirdController birdControllerScript;
    public float speed = 2;
    // Start is called before the first frame update
    void Awake()
    {
        //Find the player controller script when the game Starts
        birdControllerScript = GameObject.Find("Red_Bird_1").GetComponent<BirdController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move pipes left
        if(birdControllerScript.isAlive == true)
        {
             transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        else
        {
            speed = 0;
        }
        
    }
}
