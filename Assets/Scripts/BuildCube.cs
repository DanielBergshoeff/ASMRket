using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCube : MonoBehaviour
{
    public BuildCubeSet RuntimeSet;

    private void OnEnable() {
        RuntimeSet.Add(this);
    }

    private void OnDisable() {
        RuntimeSet.Remove(this);
    }
}
