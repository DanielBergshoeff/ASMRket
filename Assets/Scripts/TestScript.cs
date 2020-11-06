using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public FloatReference HP;
    public FloatReference MoveSpeed;

    public GameEvent TouchPlayer;
    public GameEvent ReleasePlayer;

    private bool touching = false;

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) {
                if (hit.collider.CompareTag("Player"))
                    TouchPlayer.Raise();
                touching = true;
            }
        }

        if (Input.GetMouseButtonUp(0)) {
            if (touching) {
                ReleasePlayer.Raise();
                touching = false;
            }
        }
    }
}

