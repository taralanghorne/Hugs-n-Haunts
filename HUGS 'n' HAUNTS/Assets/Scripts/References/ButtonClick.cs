using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public GameObject capsule;

    public void HitButton(){
        Debug.Log("I Hit the Button");
    }

    public void deactivateCube(){
        cube.SetActive(false);
    }

    public void deactivateSphere()
    {
        sphere.SetActive(false);
    }

    public void deactivateCapsule()
    {
        capsule.SetActive(false);
    }
}
