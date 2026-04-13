using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenMngr : MonoBehaviour
{
    public Image[] titleImgs;

    public Image insBG;
    public Text insTxt;

    public Image[] ccMenuImgs;
    public Text[] ccMenuTxts;
    public RawImage[] ccMenuRawImgs;
    public Image[] ccBtnFills;

    public static bool alreadyStartedGame = false;
    private static ScreenMngr instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        HideCharCustScreen();
        HideInstructionScreen();

        if (!alreadyStartedGame)
        {
            ShowTitleScreen();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterGame()
    {
        HideTitleScreen();
        ShowInstructionScreen();
        alreadyStartedGame = true;
    }

    public void StartCustomization()
    {
        HideInstructionScreen();
        ShowCharCustScreen();
    }

    public void ConfirmCustomization()
    {
        HideCharCustScreen();
        HideAllBtnFills();
    }

    public void ShowTitleScreen()
    {
        foreach (Image titleImg in titleImgs)
        {
            titleImg.enabled = true;
        }
    }

    public void HideTitleScreen()
    {
        foreach (Image titleImg in titleImgs)
        {
            titleImg.enabled = false;
        }
    }

    public void ShowInstructionScreen()
    {
        insBG.enabled = true;
        insTxt.enabled = true;
    }

    public void HideInstructionScreen()
    {
        insBG.enabled = false;
        insTxt.enabled = false;
    }

    public void ShowCharCustScreen()
    {
        foreach (Image ccMenuImg in ccMenuImgs)
        {
            ccMenuImg.enabled = true;
        }

        foreach (Text ccMenuTxt in ccMenuTxts)
        {
            ccMenuTxt.enabled = true;
        }

        foreach (RawImage ccMenuRawImg in ccMenuRawImgs)
        {
            ccMenuRawImg.enabled = true;
        }
    }

    public void HideCharCustScreen()
    {
        foreach (Image ccMenuImg in ccMenuImgs)
        {
            ccMenuImg.enabled = false;
        }

        foreach (Text ccMenuTxt in ccMenuTxts)
        {
            ccMenuTxt.enabled = false;
        }

        foreach (RawImage ccMenuRawImg in ccMenuRawImgs)
        {
            ccMenuRawImg.enabled = false;
        }
    }

    public void HideAllBtnFills()
    {
        foreach (Image ccBtnFill in ccBtnFills)
        {
            ccBtnFill.enabled = false;
        }
    }
}
