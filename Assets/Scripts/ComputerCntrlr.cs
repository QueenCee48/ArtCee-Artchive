using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerCntrlr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        switch (gameObject.name)
        {
            case "Computer":
                Application.OpenURL("https://cbaucham.neocities.org/");
                break;
            case "Computer (1)":
                Application.OpenURL("https://cierabaucham.neocities.org/");
                break;
            case "Computer (2)":
                Application.OpenURL("https://cbaucham.domains.ggc.edu/Gas%20Database/login.php");
                break;
            case "Computer (3)":
                Application.OpenURL("https://www.codedex.io/nm3DYYjsrqcJeqt2CccI/live");
                break;
            case "Computer (4)":
                Application.OpenURL("https://queencee48.itch.io/patty-up");
                break;
            case "Computer (5)":
                Application.OpenURL("https://queencee48.itch.io/between-timestamps");
                break;
        }
    }
}
