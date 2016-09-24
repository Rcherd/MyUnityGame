using UnityEngine;
using System.Collections;

public class onClickButtons : MonoBehaviour {

    public void onClickButton1()
    {
        Application.LoadLevel("RollABall");
    }

    public void onClickButton2()
    {
        Application.LoadLevel("MiniGame");
    }

    public void onClickButton3()
    {
        Application.LoadLevel("Menu");
    }
}
