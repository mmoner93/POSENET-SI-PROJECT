using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraZoom : MonoBehaviour
{
    private float time = 0;
    public int count = 0;
    public GameObject pantalla;
    public GameObject[] pickups = new GameObject[3];
    public Material Material1;
    public Material Material2;
    public Material Material3;
    public Material Material4;


    // Start is called before the first frame update
    void Start(){
        count = GlobalControl.Instance.now;
        time = 0;

        if (count == 0){
            pantalla.GetComponent<MeshRenderer>().material = Material1;
            pickups[1].GetComponent<Renderer>().material.color = new Color(0.2f, 0.2f, 0.2f, 1f);
            pickups[2].GetComponent<Renderer>().material.color = new Color(0.2f, 0.2f, 0.2f, 1f);

            pickups[0].GetComponent<Collider>().isTrigger = false;
            pickups[1].GetComponent<Collider>().isTrigger = false;
            pickups[2].GetComponent<Collider>().isTrigger = false;
        }
        else if (count == 1) {
            pantalla.GetComponent<MeshRenderer>().material = Material2;
            //pickups[0].GetComponent<Renderer>().enabled = false;
            //pickups[1].GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
            pickups[1].GetComponent<Renderer>().material.color = new Color(0.2f, 0.2f, 0.2f, 1f);
            pickups[2].GetComponent<Renderer>().material.color = new Color(0.2f, 0.2f, 0.2f, 1f);

            pickups[0].GetComponent<Collider>().isTrigger = false;
            pickups[1].GetComponent<Collider>().isTrigger = false;
            pickups[2].GetComponent<Collider>().isTrigger = false;
        }
        else if (count == 2)
        {
            pantalla.GetComponent<MeshRenderer>().material = Material3;
            pickups[0].GetComponent<Renderer>().enabled = false;
            //pickups[1].GetComponent<Renderer>().enabled = false;
            pickups[2].GetComponent<Renderer>().material.color = new Color(0.2f, 0.2f, 0.2f, 1f);

            pickups[0].GetComponent<Collider>().isTrigger = false;
            pickups[1].GetComponent<Collider>().isTrigger = false;
            pickups[2].GetComponent<Collider>().isTrigger = false;
        }
        else if (count == 3)
        {
            pantalla.GetComponent<MeshRenderer>().material = Material4;
            pickups[0].GetComponent<Renderer>().enabled = false;
            pickups[1].GetComponent<Renderer>().enabled = false;
            //pickups[2].GetComponent<Renderer>().enabled = false;

            pickups[0].GetComponent<Collider>().isTrigger = false;
            pickups[1].GetComponent<Collider>().isTrigger = false;
            pickups[2].GetComponent<Collider>().isTrigger = false;
        }

        if (GlobalControl.Instance.tirar)
        {

            pickups[count-1].GetComponent<Collider>().isTrigger = true;
        }
    }

    // Update is called once per frame
    void Update(){

        if (!GlobalControl.Instance.tirar) {

            if (count == 1)
            {
                pickups[0].GetComponent<Renderer>().enabled = false;
                pickups[1].GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
            }
            else if(count == 2)
            {
                pickups[1].GetComponent<Renderer>().enabled = false;
                pickups[2].GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
            }
            else if (count == 3)
            {
                pickups[2].GetComponent<Renderer>().enabled = false;
            }


            time += Time.deltaTime;

            if (time < 4) {
                this.gameObject.transform.Translate(0,  (float) (time / 6), time);
            }
            else {
                if (count == 0) {
                    GlobalControl.Instance.now++;
                    GlobalControl.Instance.tirar = true;
                    SceneManager.LoadScene("GameSelector"); // 1 ///RoutinePut
                }
                else if (count == 1) {
                    GlobalControl.Instance.now++;
                    GlobalControl.Instance.tirar = true;
                    SceneManager.LoadScene("GameSelector"); // 2 ///cleanTeethScene
                }
                else if (count == 2) {
                    GlobalControl.Instance.now++;
                    GlobalControl.Instance.tirar = true;
                    SceneManager.LoadScene("GameSelector"); // 3 ///goToClassScene
                }
                else 
                {
                    GlobalControl.Instance.now++;
                    GlobalControl.Instance.tirar = true;
                    SceneManager.LoadScene("RoutineMenu"); // 3 ///goToClassScene
                }
            }
        }
    }
}
