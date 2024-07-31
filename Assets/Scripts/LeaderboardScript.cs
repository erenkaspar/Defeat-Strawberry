using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderboardScript : MonoBehaviour
{

    //PlayFab
    public PlayFabManager playFabManager;

    // Start is called before the first frame update
    void Start()
    {
        playFabManager.GetLeaderboard();
    }
}
