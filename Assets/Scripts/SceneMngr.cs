using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMngr : MonoBehaviour
{
    public GameState GameState {get; set;}

    SpawnMngr spawnMngr;
    public string currentScene;
    
    Transform playerTrans;
    Transform defaultSpawn;

    // Start is called before the first frame update
    void Start()
    {
        spawnMngr = GameObject.Find("SpawnPoints").GetComponent<SpawnMngr>();
        playerTrans = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        defaultSpawn = GameObject.Find("SpawnDefault").GetComponent<Transform>();
        currentScene = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(string sceneName, string spawnPointName)
    {
        GameState.spawnPoint = spawnPointName;

        SceneManager.sceneLoaded += OnSceneLoaded;

        SceneManager.LoadScene(sceneName);
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        spawnMngr.SpawnPlayer(defaultSpawn);

        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
