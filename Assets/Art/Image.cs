using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image : MonoBehaviour
{
    public RawImage targetimage;
    public RawImage image {  get; set; }
    // Start is called before the first frame update
    public void SetImage()
    {
        targetimage = image;
    }
}
