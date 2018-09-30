using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalRoboBehaviour : MonoBehaviour {

    public float speed;
    public float pathFindingCDTime;
    public float maxSpeed;

    private Vector2 scienceGuyPosition;
    private Rigidbody2D mobRB;

    private void Start() {
        mobRB = GetComponent<Rigidbody2D>();
        StartCoroutine(PathRoutine(pathFindingCDTime));
    }

    private void FixedUpdate() {
        //ADD: * Time.fixedTime
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, scienceGuyPosition*1.5f, step);
    }

    private IEnumerator PathRoutine(float time) {
        while (true) {
            scienceGuyPosition = MobManagerBehaviour.instance.scienceGuy.GetComponent<Rigidbody2D>().position;
            yield return new WaitForSecondsRealtime(time);
        }
    }
}
