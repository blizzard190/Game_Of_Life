using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D_Array : MonoBehaviour {
    public GameObject boep;
    public int ColumnLenght;
    public int Row;
    public GameObject[,] Array;
    [SerializeField]
    private Material mat;

    private MeshRenderer colour;

    private float duration = 1.0F;

    void Start ()
    {
        Array = new GameObject[ColumnLenght, Row];
        for(int i = 0; i < ColumnLenght; i++)
        {
            for(int j = 0; j < Row; j++)
            {
                Array[i, j] = (GameObject)Instantiate(boep, new Vector3(i, j, 0), Quaternion.identity);
            }
        }
	}

	void Update ()
    {
        if (Input.GetMouseButtonUp(0))
        {
            StartCoroutine("Fade");
        }
    }

    private IEnumerator Fade()
    {
        for (float i = 0; i < 1; i += 0.01f)
        {
            mat.color = new Color(1, i, i);
            yield return null;
        }
        //float lerp = Mathf.PingPong(Time.time, duration) / duration;
        //colour.material.color = Color.Lerp(Color.green, Color.blue, lerp);
        //yield return null;  
    }
}
