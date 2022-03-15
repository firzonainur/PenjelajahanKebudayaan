using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBar : MonoBehaviour
{
    Vector3 itemLocalScale;
    // Start is called before the first frame update
    void Start()
    {
        itemLocalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        itemLocalScale.x = Items.itemAmount;
        transform.localScale = itemLocalScale;

    }

}
