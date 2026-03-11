using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCntrlr : MonoBehaviour
{
    public GameState GameState {get; set;}

    Transform playerTrans;
    Animator anim;
    SceneMngr sceneMngr;

    // Start is called before the first frame update
    void Start()
    {
        sceneMngr = GameObject.Find("SceneManager").GetComponent<SceneMngr>();
        playerTrans = GetComponent<Transform>();
        anim = GetComponent<Animator>();

        anim.SetBool("Idle S", true);
        anim.SetBool("Idle E", false);
        anim.SetBool("Idle N", false);
        anim.SetBool("Idle W", false);

        anim.SetBool("Walk S", false);
        anim.SetBool("Walk E", false);
        anim.SetBool("Walk N", false);
        anim.SetBool("Walk W", false);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 velocity = new Vector2(x, y);

        playerTrans.Translate(velocity * Time.deltaTime * 1.5f);

        bool isMoving = velocity.magnitude > 0;

        if (x > 0)
        {
            SetAnimationState("E", isMoving);
        }
        else if (x < 0)
        {
            SetAnimationState("W", isMoving);
        }
        else if (y > 0)
        {
            SetAnimationState("N", isMoving);
        }
        else if (y < 0)
        {
            SetAnimationState("S", isMoving);
        }
        else if (!isMoving)
        {
            ResetWalkAnimations();
        }
    }

    void SetAnimationState(string direction, bool isWalking)
    {
        anim.SetBool("Idle S", direction == "S");
        anim.SetBool("Idle E", direction == "E");
        anim.SetBool("Idle N", direction == "N");
        anim.SetBool("Idle W", direction == "W");

        anim.SetBool("Walk S", isWalking && direction == "S");
        anim.SetBool("Walk E", isWalking && direction == "E");
        anim.SetBool("Walk N", isWalking && direction == "N");
        anim.SetBool("Walk W", isWalking && direction == "W");
    }

    void ResetWalkAnimations()
    {
        anim.SetBool("Walk S", false);
        anim.SetBool("Walk E", false);
        anim.SetBool("Walk N", false);
        anim.SetBool("Walk W", false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherGO = collision.gameObject;

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
