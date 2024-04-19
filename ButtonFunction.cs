using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void ButtonF(){
        if(this.gameObject.CompareTag("Back")){
            SceneManager.LoadScene("Main");
        }
        if(this.gameObject.CompareTag("A")){
            SceneManager.LoadScene("A");
        }
        if(this.gameObject.CompareTag("B")){
            SceneManager.LoadScene("B");
        }
        if(this.gameObject.CompareTag("C")){
            SceneManager.LoadScene("C");
        }
        if(this.gameObject.CompareTag("D")){
            SceneManager.LoadScene("D");
        }
        if(this.gameObject.CompareTag("E")){
            SceneManager.LoadScene("E");
        }
        if(this.gameObject.CompareTag("F")){
            SceneManager.LoadScene("F");
        }
        if(this.gameObject.CompareTag("G")){
            SceneManager.LoadScene("G");
        }
        if(this.gameObject.CompareTag("H")){
            SceneManager.LoadScene("H");
        }
        if(this.gameObject.CompareTag("I")){
            SceneManager.LoadScene("I");
        }
        if(this.gameObject.CompareTag("J")){
            SceneManager.LoadScene("J");
        }
    }
}

