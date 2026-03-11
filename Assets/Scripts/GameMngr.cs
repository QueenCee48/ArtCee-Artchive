using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            DontDestroyOnLoad(this);
        }

        //Set up game state
        GameState = Instantiate(startingState);
        sceneMngr.GameState = GameState;
        characterCntrlr.GameState = GameState;
        spawnMngr = GameObject.Find("SpawnPoints").GetComponent<SpawnMngr>();
        spawnMngr.GameState = GameState;
    }

    void Update()
    {
        spawnMngr = GameObject.Find("SpawnPoints").GetComponent<SpawnMngr>();
        spawnMngr.GameState = GameState;
    }
}
