using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRotate : MonoBehaviour
{
    [SerializeField] private GameObject _map;

    public void LeftMap(float rotate, float hor, float ver) {

        Vector3 rot = new Vector3(0, 0, rotate);
        _map.transform.Rotate(rot);

        Vector3 pos = new Vector3(hor, ver, 0);
        _map.transform.position = pos;
    }
}
