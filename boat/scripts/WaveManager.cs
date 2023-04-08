using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gerenciador de ondas
//Seno Fuction is used to form create waves
public class WaveManager : MonoBehaviour
{
    public static WaveManager instance;

    //Basic Seno Fuction
    public float amplitude = 1f;
    public float length = 2f;
    public float speed = 1f;
    public float offset = 0f;

    private void Awake(){
        //Taxa uma instancia especifica dessa classe em qualquer lugar do projeto 
        if (instance == null)
        {
            instance = this;
        }
        else if ( instance != this){
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }

    }

    void Update(){
        //de
        offset+=Time.deltaTime*speed;
    }

    //retorna altura da funcao seno em cada ponto do eixo x
    public float GetWaveHeight(float _x)
    {
        
        return amplitude*Mathf.Sin( _x / length + offset);
    }

}