using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class BirdController : MonoBehaviour
{
   
    public TextMeshProUGUI gameOverText;
    Rigidbody2D bird;
    int score = 0;
    public Text scoreUI;
    //True OR False value to check if bird is alive or not
    public bool isAlive;
    // Start is called before the first frame update
    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
         //Set the alive to true
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if(Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            bird.AddForce(new Vector2(0,1) * 200);
        }
        if(isAlive == false)
        {
            GameOver();
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
    //Check when the player collides with something in the scene
    void OnCollisionEnter2D(Collision2D collision)
    {
        //set isAlive variable  to false when a collision happens with the player
        isAlive = false;
    }
   
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
