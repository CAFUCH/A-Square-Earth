using System.Collections;
using System.Text.RegularExpressions;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerBrain _pBrain;
    Player _player;
    MapRotate _mapRotate;

    Ray ray;
    public RaycastHit hit;
    [SerializeField] private LayerMask layer;

    public bool isInput = true;
    bool isClick = false;

    private void Awake() {
        
        _pBrain = GetComponent<PlayerBrain>();
        _player = GetComponent<Player>();
        _mapRotate = GameObject.Find("GameManager").GetComponent<MapRotate>();
    }

    private void Update() {

        if (isInput) {

            if (Input.GetKeyDown(KeyCode.Mouse0))
                if (rayHit()) _mapRotate.ClickMap(hit.collider.name);
            
            if (Input.GetKeyDown(KeyCode.Mouse1))
                if (rayHit()) _pBrain.ClickObj(hit);
        }

        if (Input.GetKeyDown(KeyCode.M)) {

            UIManager.instance.meatCnt--;
            _player.Hp += 3f;
            _player.Eng += 5f;
        }
    }

    private bool rayHit() {


        ray = Camera.main.ScreenPointToRay(Input.mousePosition); 

        isClick = (Physics.Raycast(ray, out hit, layer));
        Debug.Log(hit.collider.name);

        // StartCoroutine(clickColl());

        return isClick;
    }

    IEnumerator clickColl() {

        isInput = false;
        yield return new WaitForSeconds(1f);
        isInput = true;
    }
}
