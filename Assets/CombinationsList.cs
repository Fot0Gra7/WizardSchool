using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;

[Inspectable]
public class CombinationsList
{
    [Inspectable]
    public Sprite Element1;
    [Inspectable]
    public Sprite Element2;
    [Inspectable]
    public Sprite result;
    public void SetElements(Image firstImage, Image secondImage)
    {
        firstImage.sprite = Element1;
        secondImage.sprite = Element2;
    }
}
