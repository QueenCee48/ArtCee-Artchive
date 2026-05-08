using UnityEngine;

public class CharacterCntrlr : MonoBehaviour
{
    public GameState GameState {get; set;}

    Transform playerTrans;
    SceneMngr sceneMngr;

    public bool isMoving;
    public float x, y;

    void Start()
    {
        sceneMngr = GameObject.Find("SceneManager").GetComponent<SceneMngr>();
        playerTrans = GetComponent<Transform>();
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        Vector2 velocity = new Vector2(x, y);

        playerTrans.Translate(velocity * Time.deltaTime * 1.5f);

        isMoving = velocity.magnitude > 0;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherGO = collision.gameObject;


        // set the spawn point based on the triggered door, then load the corresponding scene
        if (otherGO.tag == "Door")
        {
            switch (otherGO.name)
            {
                case "OStoLobby":
                    sceneMngr.LoadScene("LobbyScene", "SpawnOStoLob");
                    break;
                case "OStoLab":
                    sceneMngr.LoadScene("ComputerLabScene", "SpawnOStoLab");
                    break;
                case "LobbytoOS":
                    sceneMngr.LoadScene("MainScene", "SpawnLobtoOS");
                    break;
                case "LobbytoFA":
                    sceneMngr.LoadScene("FanArtScene", "SpawnLobtoFA");
                    break;
                case "LobbytoDD":
                    sceneMngr.LoadScene("DigitalDesignScene", "SpawnLobtoDD");
                    break;
                case "LobbytoAC":
                    sceneMngr.LoadScene("AlbumCoverScene", "SpawnLobtoAC");
                    break;
                case "LobbytoFL":
                    sceneMngr.LoadScene("FreelanceScene", "SpawnLobtoFL");
                    break;
                case "LobbytoBR":
                    sceneMngr.LoadScene("BrandingScene", "SpawnLobtoBR");
                    break;
                case "FLtoLobby":
                    sceneMngr.LoadScene("LobbyScene", "SpawnFLtoLob");
                    break;
                case "FAtoLobby":
                    sceneMngr.LoadScene("LobbyScene", "SpawnFAtoLob");
                    break;
                case "DDtoLobby":
                    sceneMngr.LoadScene("LobbyScene", "SpawnDDtoLob");
                    break;
                case "LabtoOS":
                    sceneMngr.LoadScene("MainScene", "SpawnLabtoOS");
                    break;
                case "LabtoBR":
                    sceneMngr.LoadScene("BrandingScene", "SpawnLabtoBR");
                    break;
                case "BRtoLobby":
                    sceneMngr.LoadScene("LobbyScene", "SpawnBRtoLob");
                    break;
                case "BRtoLab":
                    sceneMngr.LoadScene("ComputerLabScene", "SpawnBRtoLab");
                    break;
                case "ACtoLobby":
                    sceneMngr.LoadScene("LobbyScene", "SpawnACtoLob");
                    break;
            }
        }
    }
}
