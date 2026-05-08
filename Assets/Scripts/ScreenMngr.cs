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

    void Start()
    {
        HideCharCustScreen();
        HideInstructionScreen();

        if (!alreadyStartedGame)
        {
            ShowTitleScreen();
        }
    }

    // Hides the starting screen and shows the instruction screen
    public void EnterGame()
    {
        HideTitleScreen();
        ShowInstructionScreen();
        alreadyStartedGame = true;
    }

    // Hides the instruction screen and shows the character customization screen
    public void StartCustomization()
    {
        HideInstructionScreen();
        ShowCharCustScreen();
    }

    // Hides the character customization screen and hides all the button fills
    public void ConfirmCustomization()
    {
        HideCharCustScreen();
        HideAllBtnFills();
    }

    // Enables all the images in the starting screen
    public void ShowTitleScreen()
    {
        foreach (Image titleImg in titleImgs)
        {
            titleImg.enabled = true;
        }
    }

    // Hides all the images in the starting screen
    public void HideTitleScreen()
    {
        foreach (Image titleImg in titleImgs)
        {
            titleImg.enabled = false;
        }
    }

    // Enables the objects on the instruction screen
    public void ShowInstructionScreen()
    {
        insBG.enabled = true;
        insTxt.enabled = true;
    }

    // Hides the objects on the instruction screen
    public void HideInstructionScreen()
    {
        insBG.enabled = false;
        insTxt.enabled = false;
    }

    // Enables all the objects on the character customization screen
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

    // Hides all the objects on the character customization screen
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

    // Hides all the button fills on the character customization screen
    public void HideAllBtnFills()
    {
        foreach (Image ccBtnFill in ccBtnFills)
        {
            ccBtnFill.enabled = false;
        }
    }
}
