using UnityEngine;

public class DisplayCanvasOnTrigger : MonoBehaviour
{
    public GameObject myCanvas; 

    void Start()
    {
        if (myCanvas != null)
            myCanvas.SetActive(false); 
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            if (myCanvas != null)
                myCanvas.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (myCanvas != null)
                myCanvas.SetActive(false);
        }
    }
}