using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    public float tiempo = 0.0f;
    private bool tengoQueContar = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tengoQueContar) {
            contarParaIrme();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        tengoQueContar = true;
        controlGoClass.instanceGoClass.isred = true;
    }

    void contarParaIrme()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= 3.0f)
        {
            SceneManager.LoadScene("GameSelector"); // 1
        }
    }

}
