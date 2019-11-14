using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOnClick : MonoBehaviour {

    // Use this for initialization
    public void OnMouseDown()
    {
        Destroy(gameObject);
    }
}


