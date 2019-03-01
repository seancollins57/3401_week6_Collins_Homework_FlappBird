using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    //Spawn postion, works just like despawn
    public float SpawnXposition = 10;
    //Tells what is being spawned, the game object and the name of it
    public GameObject pipeInstancePrefab;
   //This variable is not public, but is defined as the Transform for an instance
    Transform lastSpawnPipe;
    //the X position in which previous spawned instance
    public float spawnNewTriggerXpos;


    void Start()
    {
        //Instantiate will spawn prefabs!
        //Vector 3 is used cuz Unity is 3D always, it then needs an X Y Z
        //After the Vector argument it needs a rotation, what is given means no rotation
        //Make sure a coma is after each arguement, event after ( )
       //Commented out, and moved to update
        // Instantiate(pipeInstancePrefab, new Vector3(SpawnXposition, 0, 0), Quaternion.identity);

    }


    void Update()
    {

        //This will look for where the instance is everyframe and will spawn a new one ...
        //...once it hits a certain transform ; == checks for equalivalance, = assigns
        if (lastSpawnPipe == null)
        {
            //function from above
            // added .transform because of the Transform above
            lastSpawnPipe = Instantiate(pipeInstancePrefab, new Vector3(SpawnXposition, 0, 0), Quaternion.identity).transform;

        }

        else

        {
            //If the last spawn transform of x is less then 
            if (lastSpawnPipe.position.x < spawnNewTriggerXpos)
            {
            
            lastSpawnPipe = Instantiate(pipeInstancePrefab, new Vector3(SpawnXposition, 0, 0), Quaternion.identity).transform;

            }


        }
    }
}
