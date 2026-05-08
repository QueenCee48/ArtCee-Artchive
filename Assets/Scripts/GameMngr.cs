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

            DontDestroyOnLoad(gameObject);
        }

        // Set up game state
        GameState = Instantiate(startingState);
        sceneMngr.GameState = GameState;
        characterCntrlr.GameState = GameState;

        AssignSpawnMngr();
    }

    // Subscribe to scene loaded event to assign SpawnMngr reference in new scenes
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // Unsubscribe to scene loaded event to prevent memory leaks
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // Calls AssignSpawnMngr() whenever a new scene is loaded
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        AssignSpawnMngr();
    }

    // Helper method to find and assign SpawnMngr reference in the current scene
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
}
