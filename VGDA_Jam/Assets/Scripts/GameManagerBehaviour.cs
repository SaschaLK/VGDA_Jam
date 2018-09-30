using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerBehaviour : MonoBehaviour {

    public static GameManagerBehaviour instance;

    private void Awake() {
        instance = this;
    }

}
