using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRotate : MonoBehaviour
{
    [SerializeField] private GameObject _map;

    [SerializeField] int leftCount, rightCount = 0;

    Quaternion rot;
    Vector3 dir;

    Vector3 originPos;

    bool isChg = false;

    private void Start() {
        
        originPos = _map.transform.position;
    }

    private Vector3[] leftDir = new Vector3[] {

        new Vector3(15f, -15f, 0f),
        new Vector3(-15f, -15f, 0f),
        new Vector3(-15f, 15f, 0f),
        new Vector3(15f, 15f, 0f)
    };

    private Vector3[] rightDir = new Vector3[] {

        new Vector3(0f, -15f, 15f),
        new Vector3(0f, -15f, -15f),
        new Vector3(0f, 15f, -15f),
        new Vector3(0f, 15f, 15f)
    };

    private void Update() {
        
        if (Input.GetKeyDown(KeyCode.E))
            RightMap();
        if (Input.GetKeyDown(KeyCode.Q))
            LeftMap();
    }

    public void LeftMap() {

        Quaternion rot = Quaternion.Euler(0, 0, -90f);
            _map.transform.rotation = rot * _map.transform.rotation;

        leftCount++;
    }

    public void RightMap() {

        Quaternion rot = Quaternion.Euler(90f, 0, 0);
            _map.transform.rotation = rot * _map.transform.rotation;

        rightCount++;

        // _map.transform.rotation = new 
    }
    
    IEnumerator ResetPos(Vector3 targetPos) {

        Vector3 startPos = _map.transform.position;

        float t = 0f;

        while (t < 0.25f) {

            t += Time.deltaTime * 1.0f;

            _map.transform.position = Vector3.Lerp(startPos, targetPos, t);
            yield return null;
        }

        _map.transform.position = targetPos;
    }
}
