using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectar : MonoBehaviour
{

    public AudioSource quienEmite;
    public AudioClip elAudioDeMario;
    public float volumen = 1;



    private void OnTriggerEnter(Collider other) {
        
// si antes se escucho el sonido no hacer nada


        

        AudioSource.PlayClipAtPoint(elAudioDeMario,gameObject.transform.position);
        //Destroy(gameObject);

    }
    
    }



