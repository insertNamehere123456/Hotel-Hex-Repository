using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartMainRoom()
    {
        GameManager.instance.LoadScene
            (GameManager.instance.Mainroom);

    }
}
