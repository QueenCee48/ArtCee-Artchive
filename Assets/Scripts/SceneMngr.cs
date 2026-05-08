using UnityEngine;
using UnityEngine.SceneManagement;

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

        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            CharacterCntrlr characterCntrlr = player.GetComponent<CharacterCntrlr>();
            Collider2D playerCollider = player.GetComponent<Collider2D>();

            if (characterCntrlr != null)
            {
                characterCntrlr.canMove = false;
            }

            if (playerCollider != null)
            {
                playerCollider.enabled = false;
            }
        }

        SceneManager.LoadScene(sceneName);
    }
}
