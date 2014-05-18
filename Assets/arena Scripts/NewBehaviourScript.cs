using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{

    int hexagonDiameter = 1;
    public Transform prefab;

    // Use this for initialization
    void Start()
    {
        generateFloor(10);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void generateFloor(int radius)
    {
        // http://www.redblobgames.com/grids/hexagons/#basics
        //                                   x                   z
        float[] hexCordR = { Mathf.Sqrt(3f) / 2f * hexagonDiameter, 0 };
        float[] hexCordQ = { (Mathf.Sqrt(3f) / 2f * hexagonDiameter) / 2f, 3f / 4f * hexagonDiameter };

        for (int r = 0; r < radius * 2 + 1; r++)
        {
            for (int q = 0; q < radius * 2 + 1; q++)
            {
                if (radius == 0)
                {
                    Transform temp = Instantiate(prefab) as Transform;
                    temp.name = "arenaHex_r" + (r - radius) + "q" + (q - radius);
                    temp.transform.position = new Vector3(0, 0, 0);
                    temp.transform.rotation = Quaternion.Euler(90, -90, 0);
                }
                else
                {
                    if (Mathf.Abs((r - radius) + (q - radius)) <= radius)
                    {
                        Transform temp = Instantiate(prefab) as Transform;
                        temp.name = "arenaHex_r" + (r - radius)  + "q" + (q - radius);
                        temp.transform.position = new Vector3((r - radius) * hexCordR[0] + (q - radius) * hexCordQ[0], 0, ((r - radius) * hexCordR[1]) + ((q - radius) * hexCordQ[1]));
                        temp.transform.rotation = Quaternion.Euler(90, -90, 0);
                    }
                }
            }
        }
    }
}
