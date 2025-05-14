using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    BirdController birdControllerScript;
    public GameObject pipePrefab;
    float randomHeight = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes" ,1.5f, 1.5f);
        birdControllerScript = GameObject.Find("Red_Bird_1").GetComponent<BirdController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if isAlive variable from PlayerController is false
        if(birdControllerScript.isAlive == false)
        {
            // Stop Spawning in new pipes
            CancelInvoke();
        }
    }

    void SpawnPipes()
    {
        Instantiate(pipePrefab, new Vector2(3, Random.Range(-6.89f,-4.08f)), Quaternion.identity);
    }
}
