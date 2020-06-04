using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class controlRopa : MonoBehaviour
{
    public static controlRopa instance;
    private int counter = 0;
    public GameObject manoIzCube;
    public GameObject manoDerCube;
    public GameObject piernaDerCube;
    public GameObject piernaIzCube;
    public GameObject CajaVisual;

    public GameObject camiseta;
    public GameObject pantalon;
    public GameObject zapatos;

    public Material mat1;
    public Material mat2;
    public Material mat3;


    public Material camisetaOn;
    public Material pantalonOn;
    public Material zapatoOn;

    private bool manoIzqInPosition;
    private bool manoDerInPosition;
    private bool piernaIzqInPosition;
    private bool piernaDerInPosition;

    Vector3 pos1manoIzqJUEGO;
    Vector3 pos1manoDerJUEGO;
    Vector3 pos1piernaIzqJUEGO;
    Vector3 pos1piernaDerJUEGO;


    Vector3 pos2manoIzqJUEGO;
    Vector3 pos2manoDerJUEGO;
    Vector3 pos2piernaIzqJUEGO;
    Vector3 pos2piernaDerJUEGO;


    Vector3 pos3manoIzqJUEGO;
    Vector3 pos3manoDerJUEGO;
    Vector3 pos3piernaIzqJUEGO;
    Vector3 pos3piernaDerJUEGO;


    public Text Tempo;
    public float tiempo = 0.0f;
    bool tengoQueContar = false;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        GlobalControl.Instance.musica.Play();
        GlobalControl.Instance.musica.loop = true;
        manoIzqInPosition = false;
        manoDerInPosition = false;
        piernaIzqInPosition = false;
        piernaDerInPosition = false;
        tengoQueContar = false;
        crearSitio();
        counter = 0;
        tiempo = 0.0f;
        manoIzCube.transform.position = pos1manoIzqJUEGO;
        manoDerCube.transform.position = pos1manoDerJUEGO;
        piernaDerCube.transform.position = pos1piernaDerJUEGO;
        piernaIzCube.transform.position = pos1piernaIzqJUEGO;
        CajaVisual.GetComponent<MeshRenderer>().material = mat1;

    }
    


    void crearSitio()
    {
        //1--------------------------------
        pos1manoIzqJUEGO.x = 34 + 139f;
        pos1manoIzqJUEGO.y = 122f;
        pos1manoIzqJUEGO.z = 1.836f;

        pos1manoDerJUEGO.x = 34 + -131f;
        pos1manoDerJUEGO.y = 125f;
        pos1manoDerJUEGO.z = 1.836f;



        pos1piernaIzqJUEGO.x = 34 + -36f;
        pos1piernaIzqJUEGO.y = -235.0f;
        pos1piernaIzqJUEGO.z = 1.836f;

        pos1piernaDerJUEGO.x = 34 + 51.0f;
        pos1piernaDerJUEGO.y = -238.0f;
        pos1piernaDerJUEGO.z = 1.836f;

        

        //2--------------------------------------

        pos2manoIzqJUEGO.x = 34 + 83f;
        pos2manoIzqJUEGO.y = 106f;
        pos2manoIzqJUEGO.z = 1.836f;

        pos2manoDerJUEGO.x = 34 + -59f;
        pos2manoDerJUEGO.y = -70.0f;
        pos2manoDerJUEGO.z = 1.836f;

        pos2piernaIzqJUEGO.x  = 34 + -30f;
        pos2piernaIzqJUEGO.y  = -235.0f;
        pos2piernaIzqJUEGO.z  = 1.836f;
                              
        pos2piernaDerJUEGO.x = 34 + 51.0f;
        pos2piernaDerJUEGO.y = -238.0f;
        pos2piernaDerJUEGO.z = 1.836f;

        //3----------------------------------------

        pos3manoIzqJUEGO.x = 34+154f;
        pos3manoIzqJUEGO.y = -2f;
        pos3manoIzqJUEGO.z = 1.836f;

        pos3manoDerJUEGO.x = 34 + -173;
        pos3manoDerJUEGO.y = 5f;
        pos3manoDerJUEGO.z = 1.836f;


        pos3piernaIzqJUEGO.x = 34 + -104.0f;
        pos3piernaIzqJUEGO.y  =  -241.0f;
        pos3piernaIzqJUEGO.z  = 1.836f;

        pos3piernaDerJUEGO.x  = 34 + 90f;
        pos3piernaDerJUEGO.y  = -249f;
        pos3piernaDerJUEGO.z = 1.836f;


    }

    // Update is called once per frame
    void Update()
    {

        check();
        if (tengoQueContar) {
            contarParaIrme();
        }
    }

    void contarParaIrme()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= 3.0f) {
            SceneManager.LoadScene("GameSelector"); // 1
        }
    }


    void check()
    {
        if (manoDerInPosition && manoIzqInPosition & piernaIzqInPosition & piernaDerInPosition)
        {
            Debug.Log("Dos true !!");
            Debug.Log("Antes cube iz  x"+ manoIzCube.transform.position.x + " y"+ manoIzCube.transform.position.y + " z"+ manoIzCube.transform.position.y);
            Debug.Log("Antes cube der  x" + manoDerCube.transform.position.x + " y" + manoDerCube.transform.position.y + " z" + manoDerCube.transform.position.y);
            Vector3 temp=manoIzCube.transform.position;
            // temp.y = temp.y - 10.0f;
            // manoIzCube.transform.position = temp;
            Debug.Log("Counter "+counter);
            switch (counter)
            {
               /* case 0:
                    Debug.Log("Entro a 0");
                    manoIzCube.transform.position = pos1manoIzqJUEGO;
                    manoDerCube.transform.position= pos1manoDerJUEGO;
                    CajaVisual.GetComponent<MeshRenderer>().material = mat1;
                    break;*/
                case 0:
                    camiseta.GetComponent<MeshRenderer>().material = camisetaOn;
                    manoIzCube.transform.position = pos2manoIzqJUEGO;
                    manoDerCube.transform.position= pos2manoDerJUEGO;
                    piernaDerCube.transform.position = pos2piernaDerJUEGO; 
                    piernaIzCube.transform.position = pos2piernaIzqJUEGO; 
                    CajaVisual.GetComponent<MeshRenderer>().material = mat2;
                    manoIzqInPosition = false;
                    manoDerInPosition = false;
                    piernaIzqInPosition = false;
                    piernaDerInPosition = false;
                    break;
                case 1:
                    pantalon.GetComponent<MeshRenderer>().material = pantalonOn;
                    manoIzCube.transform.position= pos3manoIzqJUEGO;
                    manoDerCube.transform.position = pos3manoDerJUEGO;
                    piernaDerCube.transform.position = pos3piernaDerJUEGO; ;
                    piernaIzCube.transform.position = pos3piernaIzqJUEGO; ;
                    CajaVisual.GetComponent<MeshRenderer>().material = mat3;
                    manoIzqInPosition = false;
                    manoDerInPosition = false;
                    piernaIzqInPosition = false;
                    piernaDerInPosition = false;
                    break;

                case 2:
                    zapatos.GetComponent<MeshRenderer>().material = zapatoOn;
                    tengoQueContar = true;
                    Tempo.text = "Muy bien !";
                    break;
                default: Debug.Log("No disponible"); break;
            }

            //Debug.Log("Despues cube iz  x" + manoIzCube.transform.position.x + " y" + manoIzCube.transform.position.y + " z" + manoIzCube.transform.position.y);
            //Debug.Log("Despues cube der  x" + manoDerCube.transform.position.x + " y" + manoDerCube.transform.position.y + " z" + manoDerCube.transform.position.y);

            counter++;
        }


    }



    public void setManoIzqPosition(bool cual)
    {
        manoIzqInPosition = cual;
    }

    public void setManoDerPosition(bool cual)
    {
        manoDerInPosition = cual;
    }


    public void setPiernaDerPosition(bool cual)
    {
        piernaDerInPosition = cual;
    }
    public void setPiernaIzqPosition(bool cual)
    {
        piernaIzqInPosition = cual;
    }

}
