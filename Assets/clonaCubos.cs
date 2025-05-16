using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonaCubos : MonoBehaviour
{
    public GameObject cuboprefab;

    // Start is called before the first frame update
    void Start()
    {
       
    }


    public void clonarCubos()
    {
        Instantiate(cuboprefab);
    }
}
