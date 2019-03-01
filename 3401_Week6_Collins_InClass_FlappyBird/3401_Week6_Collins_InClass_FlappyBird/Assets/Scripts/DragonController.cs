using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//^included for score UI

public class DragonController : MonoBehaviour
{
    //This is where you type other public things
    //Public then whatever it is, then name it
    public Rigidbody2D DragonRB;

    //A new varaible for jumpspeed, also a given value for it to be adjusted 
    public float JumpSpeed = 5;
    //to call the Game Over Screen
    public GameObject gameOverCanvas;
    //Score !
    public int Score;
    //This will add the score text to the Score UI
    public Text ScoreText;

    public AudioSource Flap;

    void Start()
    {

    }

   


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

            //This will use the name assigned above, and vary its velocity 
            //This is the jump function, to do so, it needs to = a new Vector 2
            //The (DragonRB.velocity.x will ensure X axis does not change
            //The added JumpSpped will allow it to be altered with space is hit
        DragonRB.velocity = new Vector2(DragonRB.velocity.x, JumpSpeed);

        Flap.Play();

    }

    //new void for on collision and death conditoin, if found while typing, will...
    //... fill itself out automatically
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //In Unity, a GAMEOVER canvas was created, now this will be called when...
        //.. a collison is detected
        //Call teh defined variable above (gameOverCanvas) and use .SetActive to turn on
        //make sure you then Drag the canvas in Unity to the gameOverCanvas in inspector!
        gameOverCanvas.SetActive(true);
    }

    //This is the score collider made teh same way as the one above
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //will add more to score, ++ will increase an int by 1
        Score++;
        //also want to change text to be the current score, ToString is for displaying #
        ScoreText.text = Score.ToString();


    }
}
