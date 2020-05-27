using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraZoom : MonoBehaviour
{
    private float time = 0;
    public int count = 0;
    public GameObject pantalla;
    public Material Material1;
    public Material Material2;
    public Material Material3;
    

    // Start is called before the first frame update
    void Start(){
        count = GlobalControl.Instance.now;

        if (count == 0){
            pantalla.GetComponent<MeshRenderer>().material = Material1;
        }
        else if (count == 1) {
            pantalla.GetComponent<MeshRenderer>().material = Material2;
        }
        else if (count == 2){
            pantalla.GetComponent<MeshRenderer>().material = Material3;
        }
    }

    // Update is called once per frame
    void Update(){
        time += Time.deltaTime;
  
        if (time < 4){
            this.gameObject.transform.Translate(0, time / 4, time);
        }
        else{
            if (count == 0){
                GlobalControl.Instance.now ++;
                SceneManager.LoadScene("RoutinePut"); // 1
            }
            else if (count == 1){
                GlobalControl.Instance.now++;
                SceneManager.LoadScene("cleanTeethScene"); // 2
            }
            else if (count == 2){

                GlobalControl.Instance.now++;
                SceneManager.LoadScene("goToClassScene"); // 3
            }
        }
    }
}
