using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverScrolling : MonoBehaviour
{
    [SerializeField] float scrollSpeed = 4f;
    Material myMaterial;
    Vector2 offSet;

    private void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
        offSet = new Vector2(scrollSpeed, 0f);
    }

    private void Update()
    {
        myMaterial.mainTextureOffset += offSet * Time.deltaTime;
    }
}
