using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCubeDuplicator : MonoBehaviour
{
    public BuildCubeSet RuntimeSet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) {
            Duplicate();
        }
    }

    private void Duplicate() {
        for (int i = RuntimeSet.Items.Count - 1; i >= 0; i--) {
            GameObject go = Instantiate(RuntimeSet.Items[i].gameObject);
            go.transform.position = RuntimeSet.Items[i].transform.position + Vector3.up * 1f;
        }
    }
}
