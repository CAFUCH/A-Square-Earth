using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    static public Core instance;

    [SerializeField] private GameObject parent;
    GameObject _item;

    private void Awake() {
        
        if (instance)
            Destroy(this);
        else
            instance = this;
    }

    public void AddItem(GameObject item, GameObject pos) {

        Instantiate(item, pos.transform.position, Quaternion.identity, parent.transform);
    }
}
