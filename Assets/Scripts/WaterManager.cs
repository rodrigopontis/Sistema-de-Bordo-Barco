using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//component filtro de malha
[RequireComponent(typeof(MeshFilter))]
//Component renderizador de malha
[RequireComponent(typeof(MeshRenderer))]

public class WaterManager : MonoBehaviour
{
    private MeshFilter meshFilter; //filtro de malha
    // Start is called before the first frame update
    void Awake()
    {
        meshFilter = GetComponent<MeshFilter>();
    }

    // Update is called once per frame
    private void Update()
    {
        //captura os vertices das malhas
        Vector3[] vertices = meshFilter.mesh.vertices;
        
        for (int i = 0;  i < vertices.Length; i++){
            //percorrer o array e modifica os componentes verticais Y com base no componente horizontais de x global
            
            vertices[i].y = WaveManager.instance.GetWaveHeight(transform.position.x + vertices[i].x);
        }
        //reatribuir os vertices da malha e fazer o Recalculate Normals para verificar se as Normalsh malhas estão corretas
        meshFilter.mesh.vertices = vertices;
        meshFilter.mesh.RecalculateNormals();

    }
}
