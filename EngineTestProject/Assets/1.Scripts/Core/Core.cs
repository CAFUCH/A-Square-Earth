using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    static public Core instance;
    public GameObject item;

    [SerializeField] private GameObject parent;

    private void Awake() {
        
        if (instance)
            Destroy(this);
        else
            instance = this;
    }

    private void Update() {
        
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void AddItem(GameObject item, GameObject pos) {

        item = Instantiate(item, pos.transform.position, Quaternion.identity, parent.transform);
    }
}
