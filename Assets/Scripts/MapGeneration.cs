﻿/***************************************/
/* Outerworlds Terrain Generation Test */
/* Author: Felix Eckert                */
/***************************************/

// IN ORDER TO USE THE MAP GENERATION, DISABLE THE
// SPRITE COMPONENT IN THE BACKGROUND OBJECT
// AND ACTIVATE THIS SCRIPT IN THE MAPGEN OBJECT
// IN THE TESTING-SCENE

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{

    public int width;
    public int height;
    public int distance;
    public int space;

    public GameObject Grass;
    public GameObject Dirt;
    public GameObject Stone;

    public float heightpoint;
    public float heightpoint2;


    // Use this for initialization
    void Start()
    {
        Generation();
    }

    void Generation()
    {
        distance = height;
        for (int w = 0; w < width; w++)
        {
            int lowernum = distance - 1;
            int heighernum = distance + 2;
            distance = Random.Range(lowernum, heighernum);
            space = Random.Range(12, 20);
            int stonespace = distance - space;


            for (int j = 0; j < stonespace; j++)
            {
                Instantiate(Stone, new Vector3(w, j), Quaternion.identity);
            }

            for (int j = stonespace; j < distance; j++)
            {
                Instantiate(Dirt, new Vector3(w, j), Quaternion.identity);
            }
            Instantiate(Grass, new Vector3(w, distance), Quaternion.identity);
        }
    }
}
