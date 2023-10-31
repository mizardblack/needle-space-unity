using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenFarAway : MonoBehaviour
{
    [SerializeField]
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, Vector3.zero) > 10.0)
        {
            DestroyGameObject();
        }
    }
    void DestroyGameObject()
    {
        Destroy(obj);
    }

}
