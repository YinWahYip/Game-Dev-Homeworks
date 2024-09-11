using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefab_script : MonoBehaviour
{

    [SerializeField] float xMove = 0.0f;
    [SerializeField] float yMove = 0.0f;
    [SerializeField] float zMove = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am a component added to the prefab");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 1, 0);
        Debug.Log("I update with every frame of the prefab");
    }
}
