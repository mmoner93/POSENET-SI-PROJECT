
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update

    float time_on;
    string actualbox;
    bool counting;

    public Text textr1;
    public Text textexit;


    private void Start() {
        time_on = 3.0f;
    }


    // Update is called once per frame
    void Update() {
        if (counting){
            contarParaIrme();
        }

    }
    
    void contarParaIrme() {
        time_on -= Time.deltaTime;

        if (time_on <= 0) { 
            if (actualbox.Equals("rutina1")) {

                SceneManager.LoadScene("GameSelector");
            }
            if (actualbox.Equals("exit")) {
                Application.Quit();
            }
        }
        else {
            if (actualbox.Equals("rutina1")) {
                textr1.text = "("+ (Mathf.Round( time_on)).ToString()  + ")";
            }
            if (actualbox.Equals("exit")) {
                textexit.text = "(" + (Mathf.Round(time_on)).ToString() + ")";
            }
        }
    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("colisioooon");
        if (other.gameObject.CompareTag("rutina1") ) {
            actualbox = "rutina1";
            counting = true;
            Debug.Log("rutina111");
        }
        if (other.gameObject.CompareTag("exit"))
        {
            Debug.Log("exiiit");
            actualbox = "exit";
            counting = true;
        }

}

    void OnTriggerExit (Collider other) {

        if (other.gameObject.CompareTag("rutina1") && actualbox.Equals("rutina1")) {
            actualbox = "";
            counting = false;
            time_on = 3.0f;
            textr1.text = "(" + (Mathf.Round(time_on)).ToString() + ")";
        }
        if (other.gameObject.CompareTag("exit") && actualbox.Equals("exit")) {
            actualbox = "";
            counting = false;
            time_on = 3.0f;
            textexit.text = "(" + (Mathf.Round(time_on)).ToString() + ")";
        }
    }




}
