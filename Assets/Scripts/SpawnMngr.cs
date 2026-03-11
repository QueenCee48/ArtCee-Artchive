using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMngr : MonoBehaviour
{
    public GameState GameState {get; set;}

    public CharacterCntrlr characterCntrlr;

    Transform playerTrans;
    Transform defaultSpawn;

    public GameObject[] spawns;

    // Start is called before the first frame update
    void Start()
    {
        characterCntrlr = GameObject.Find("Player").GetComponent<CharacterCntrlr>();
        playerTrans = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        defaultSpawn = GameObject.Find("SpawnDefault").GetComponent<Transform>();
    }

    public void SpawnPlayer(Transform defaultSpawnPoint)
    {
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
                    playerTrans.position = spawn.GetComponent<Transform>().position;
                    break;
                }
            }
            if (!foundSpawn)
            {
                throw new MissingReferenceException("Spawn point " + GameState.spawnPoint + " not found in scene.");
            }
        }
        else
        {
            playerTrans.position = defaultSpawnPoint.position;
            Debug.Log("No spawn point set, spawning at default location");
        }
    }
}
