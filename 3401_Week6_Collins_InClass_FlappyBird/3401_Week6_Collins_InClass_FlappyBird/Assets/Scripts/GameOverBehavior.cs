using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//^included new library for scene management ^

public class GameOverBehavior : MonoBehaviour
{
   //all other voids not necessary, named something Poetic
    public void OnRestartButtonPressed ()
    {

        //0 means itll load the one scene in the game, also the first scene
        SceneManager.LoadScene(0);
    }


}
