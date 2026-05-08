using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneMngr : MonoBehaviour
{
    public GameState GameState {get; set;}

    SpawnMngr spawnMngr;
    public string currentScene;
    
    Transform playerTrans;
    Transform defaultSpawn;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
    }

    // Loads the specified scene and sets the spawn point for the new scene
    public void LoadScene(string sceneName, string spawnPointName)
    {
        GameState.spawnPoint = spawnPointName;
        Debug.Log("Spawn point set to: " + GameState.spawnPoint);

        // SceneManager.sceneLoaded += OnSceneLoaded;

        SceneManager.LoadScene(sceneName);
    }

    // Spawns the player at the correct spawn point after a new scene is loaded
    // private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    // {
    //     spawnMngr = GameObject.Find("SpawnPoints").GetComponent<SpawnMngr>();
    //     defaultSpawn = GameObject.Find("SpawnDefault").GetComponent<Transform>();

    //     spawnMngr.SpawnPlayer(defaultSpawn);

    //     SceneManager.sceneLoaded -= OnSceneLoaded;
    // }


    // TESTING
    // private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    // {
    //     StartCoroutine(SpawnAfterSceneLoad());

    //     SceneManager.sceneLoaded -= OnSceneLoaded;
    // }

    // IEnumerator SpawnAfterSceneLoad()
    // {
    //     yield return null;

    //     spawnMngr = GameObject.Find("SpawnPoints").GetComponent<SpawnMngr>();
    //     Transform defaultSpawn = GameObject.Find("SpawnDefault").GetComponent<Transform>();

    //     spawnMngr.SpawnPlayer(defaultSpawn);
    // }
    // END TESTING
}
