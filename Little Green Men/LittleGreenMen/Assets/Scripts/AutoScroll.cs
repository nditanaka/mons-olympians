using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class AutoScroll : MonoBehaviour
{
    public float ScrollSpeed; //adjust this in the inspector to make the scroll speed faster or slower
    public Renderer BackgroundRend; //This is the background renderer used to autoscroll image
    void Update()
    {
        //This is used on a quad and is essentially a moviing sphere with an image cast on it
        BackgroundRend.material.mainTextureOffset += new Vector2(0f, ScrollSpeed * Time.deltaTime);
        
    }
}
