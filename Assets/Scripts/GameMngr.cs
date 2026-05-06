using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMngr : MonoBehaviour
{
    public static GameMngr Instance {get; private set;}

    [SerializeField]
    private GameState startingState;

    public GameState GameState {get; private set;}

    public SceneMngr sceneMngr;
    public CharacterCntrlr characterCntrlr;

    public SpawnMngr spawnMngr;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            Instance = this;
            // DontDestroyOnLoad(this);

            // TESTING
            DontDestroyOnLoad(gameObject);
            // END TESTING
        }

        //Set up game state
        GameState = Instantiate(startingState);
        sceneMngr.GameState = GameState;
        characterCntrlr.GameState = GameState;

        /*
        spawnMngr = GameObject.Find("SpawnPoints").GetComponent<SpawnMngr>();
        spawnMngr.GameState = GameState;
        */

        // TESTING
        AssignSpawnMngr();
        // END TESTING
    }

    // void Update()
    // {
    //     spawnMngr = GameObject.Find("SpawnPoints").GetComponent<SpawnMngr>();
    //     spawnMngr.GameState = GameState;
    // }

    // TESTING
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        AssignSpawnMngr();
    }

    void AssignSpawnMngr()
    {
        GameObject spawnObj = GameObject.Find("SpawnPoints");

        if (spawnObj != null)
        {
            spawnMngr = spawnObj.GetComponent<SpawnMngr>();

            if (spawnMngr != null)
            {
                spawnMngr.GameState = GameState;
            }
            else
            {
                Debug.LogWarning("SpawnPoints found but no SpawnMngr component attached.");
            }
        }
        else
        {
            Debug.LogWarning("SpawnPoints object not found in scene.");
        }
    }
    //END TESTING
}
