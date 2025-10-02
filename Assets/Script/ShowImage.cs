using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowImage : MonoBehaviour
{
 
 public GameObject imageToShow;
    // Start is called before the first frame update
 public void Show()
    {
        if (imageToShow != null)
        {
            imageToShow.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
