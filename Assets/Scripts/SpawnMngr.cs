using System.Collections;
using UnityEngine;

public class SpawnMngr : MonoBehaviour
{
    public GameState GameState {get; set;}

    public CharacterCntrlr characterCntrlr;

    Transform playerTrans;
    Transform defaultSpawn;

    public GameObject[] spawns;

    // void Start()
    // {
    //     characterCntrlr = GameObject.Find("Player").GetComponent<CharacterCntrlr>();
    //     playerTrans = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    //     defaultSpawn = GameObject.Find("SpawnDefault").GetComponent<Transform>();
    // }

    // TESTING
    IEnumerator Start()
    {
        yield return null;

        defaultSpawn = GameObject.Find("SpawnDefault").transform;

        SpawnPlayer(defaultSpawn);
    }
    // END TESTING

    // Spawns the player at the spawn point specified in GameState, or at the default spawn if no spawn point is set
    public void SpawnPlayer(Transform defaultSpawnPoint)
    {
        if (GameState == null)
        {
            Debug.LogError("GameState is NULL in SpawnMngr");
            return;
        }

        // TESTING
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player == null)
        {
            Debug.LogError("Player object not found.");
            return;
        }

        playerTrans = player.transform;
        // END TESTING

        // if (playerTrans == null)
        // {
        //     playerTrans = GameObject.FindGameObjectWithTag("Player").transform;
        // }

        if (defaultSpawnPoint == null)
        {
            Debug.LogError("Default spawn point is NULL");
            return;
        }
        
        if (GameState.spawnPoint != "")
        {
            bool foundSpawn = false;

            GameObject[] spawns = GameObject.FindGameObjectsWithTag("SpawnPoint");

            foreach (GameObject spawn in spawns)
            {                
                //if matching spawn name
                if (spawn.name == GameState.spawnPoint)
                {
                    foundSpawn = true;

                    //spawn player at spawn point
                    // playerTrans.position = spawn.GetComponent<Transform>().position;

                    // TESTING
                    playerTrans.position = spawn.transform.position;

                    Debug.Log("Spawning at " + spawn.name);

                    // GameObject.FindGameObjectWithTag("Player")
                    // END TESTING
                    break;
                }
            }
            if (!foundSpawn)
            {
                // throw new MissingReferenceException("Spawn point " + GameState.spawnPoint + " not found in scene.");
               
                // TESTING
                Debug.LogWarning("Spawn point " + GameState.spawnPoint + " not found in scene. Spawning at default location.");
                
                playerTrans.position = defaultSpawnPoint.position;
                // END TESTING
            }
        }
        else
        {
            playerTrans.position = defaultSpawnPoint.position;
            Debug.Log("No spawn point set, spawning at default location");
        }
    }
}
