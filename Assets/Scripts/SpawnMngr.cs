using System.Collections;
using UnityEngine;

public class SpawnMngr : MonoBehaviour
{
    public GameState GameState {get; set;}

    public CharacterCntrlr characterCntrlr;

    Transform playerTrans;
    Transform defaultSpawn;

    public GameObject[] spawns;

    IEnumerator Start()
    {
        yield return null;

        defaultSpawn = GameObject.Find("SpawnDefault").transform;

        SpawnPlayer(defaultSpawn);
    }

    // Spawns the player at the spawn point specified in GameState, or at the default spawn if no spawn point is set
    public void SpawnPlayer(Transform defaultSpawnPoint)
    {
        if (GameState == null)
        {
            Debug.LogError("GameState is NULL in SpawnMngr");
            return;
        }

        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player == null)
        {
            Debug.LogError("Player object not found.");
            return;
        }

        playerTrans = player.transform;

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

                    playerTrans.position = spawn.transform.position;

                    Debug.Log("Spawning at " + spawn.name);

                    break;
                }
            }
            if (!foundSpawn)
            {
                Debug.LogWarning("Spawn point " + GameState.spawnPoint + " not found in scene. Spawning at default location.");
                
                playerTrans.position = defaultSpawnPoint.position;
            }
        }
        else
        {
            playerTrans.position = defaultSpawnPoint.position;
            Debug.Log("No spawn point set, spawning at default location");
        }

        CharacterCntrlr charCntrlr = player.GetComponent<CharacterCntrlr>();
        Collider2D playerCollider = player.GetComponent<Collider2D>();

        if (charCntrlr != null)
        {
            charCntrlr.canMove = true;
        }

        if (playerCollider != null)
        {
            playerCollider.enabled = true;
        }
    }
}
