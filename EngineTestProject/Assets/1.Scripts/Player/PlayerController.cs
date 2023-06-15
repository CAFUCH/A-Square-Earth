using UnityEngine;

public class PlayerController : MonoBehaviour
{
    PlayerBrain _pBrain;

    public bool isInput = true;

    private void Awake() {
        
        _pBrain = GetComponent<PlayerBrain>();
    }

    private void Update() {

        if (isInput) {

            if (Input.GetKeyDown(KeyCode.Mouse1))
                _pBrain.ClickObj();
        }
    }
}
