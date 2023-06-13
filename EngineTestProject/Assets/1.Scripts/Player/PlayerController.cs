using UnityEngine;

public class PlayerController : MonoBehaviour
{
    PlayerBrain _pBrain;

    private void Awake() {
        
        _pBrain = GetComponent<PlayerBrain>();
    }

    private void Update() {

        if (Input.GetKeyDown(KeyCode.Mouse1))
            _pBrain.ClickObj();
    }
}
