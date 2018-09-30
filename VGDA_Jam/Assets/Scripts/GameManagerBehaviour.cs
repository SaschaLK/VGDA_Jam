using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerBehaviour : MonoBehaviour {

    public static GameManagerBehaviour instance;
    public GameObject youDed;

    private void Awake() {
        instance = this;
    }

    public void GameOver() {
        youDed.GetComponent<YouDedBehaviour>().YouDedAnimation();
    }

}
