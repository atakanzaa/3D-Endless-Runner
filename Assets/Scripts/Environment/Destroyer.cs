using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public string parentName;
    
    void Start()
    {
        parentName = transform.name; //obje ne diye cagiriliyorsa o
        StartCoroutine(DestroyClone());
    }
    IEnumerator DestroyClone()
    {
        yield return new WaitForSeconds(50);
        if (parentName == "Section(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
