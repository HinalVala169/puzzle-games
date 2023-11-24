using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region PUBLIC_VARS
    #endregion

    #region PRIVATE_VARS
    #endregion

    #region UNITY_CALLBACKS
    public void Start()
    {
        StartGame();
    }
    #endregion

    #region PUBLIC_FUNCTIONS
    public void StartGame()
    {
        ScreenManager.instance.SwitchScreen(Screentype.GamePlay);
    }
    public void GameOver()
    {

    }
    #endregion

}
