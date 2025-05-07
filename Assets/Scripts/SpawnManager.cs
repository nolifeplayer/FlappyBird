using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    public GameObject pipePrefab;
    float randomHeight = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes" ,1.5f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipes()
    {
        Instantiate(pipePrefab, new Vector2(3, Random.Range(-6.89f,-4.08f)), Quaternion.identity);
    }
}
