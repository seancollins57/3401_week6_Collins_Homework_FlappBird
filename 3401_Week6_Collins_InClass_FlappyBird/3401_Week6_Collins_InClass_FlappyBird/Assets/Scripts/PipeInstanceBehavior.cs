using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeInstanceBehavior : MonoBehaviour
{
    //The varaible that is assigned to move speed
    public float MoveSpeed = 5;
    //The varaible that is assigned to despawn if function 
    //This is made a public float so the variable can be played with and seen for optimization
    public float despawnXPosition = -20;


    void Start()
    {
        
    }


    void Update()
    {
        //Lower case cuz it work for the gameobject the script is attached to
        //.Translate means the position is moved rather than rotation
        //This will move the Pipe Instance left (instance meaning the parent of 2 pipes)
        //the last argument will ensure it moves at teh same speed on all devices
        transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime);

        //This will check if the istance is off screen and if it is to despawn
        //If then in ( ) you define what it is looking for, then < the x value itll call function
        if (transform.position.x < despawnXPosition)
        {
            //Destory gameObject) with lower case will destory the object this script is attatched to
            Destroy(gameObject);
         
           }




    }
}
