using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BirdController : MonoBehaviour
{
   
    Rigidbody2D bird;
    int score = 0;
    public Text scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            bird.AddForce(new Vector2(0,1) * 200);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Points"))
        {
            // Increase Score by 1
            score = score + 1;

            scoreUI.text = score.ToString();
        }
    }
}
