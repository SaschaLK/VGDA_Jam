using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobManagerBehaviour : MonoBehaviour {

    public static MobManagerBehaviour instance;

    public GameObject scienceGuy;
    public GameObject[] mobs;

    private void Awake() {
        instance = this;
    }

    private void Start() {
        StartCoroutine(SpawnMobs());
    }

    private IEnumerator SpawnMobs() {
        while (true) {
            Instantiate(mobs[0]);
            yield return new WaitForSecondsRealtime(4);
        }
    }
}
