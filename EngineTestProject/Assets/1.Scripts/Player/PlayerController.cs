using System.Collections;
using System.Text.RegularExpressions;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    PlayerBrain _pBrain;
    MapRotate _mapRotate;

    Ray ray;
    RaycastHit hit;
    [SerializeField] private LayerMask layer;

    public bool isInput = true;
    bool isClick = false;

    private void Awake() {
        
        _pBrain = GetComponent<PlayerBrain>();
        _mapRotate = GameObject.Find("GameManager").GetComponent<MapRotate>();
    }

    private void Update() {

        if (isInput) {

            if (Input.GetKeyDown(KeyCode.Mouse0))
                if (rayHit()) _mapRotate.ClickMap(hit.collider.name);
            
            if (Input.GetKeyDown(KeyCode.Mouse1))
                if (rayHit()) _pBrain.ClickObj(hit);
        }
    }

    private bool rayHit() {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition); 

        isClick = (Physics.Raycast(ray, out hit, layer));

        // StartCoroutine(clickColl());

        return isClick;
    }

    IEnumerator clickColl() {

        isInput = false;
        yield return new WaitForSeconds(1f);
        isInput = true;
    }
}
