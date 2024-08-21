using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{

    // prefabs
    public GameObject arrowRed;
    public GameObject arrowWhite;

    public float radius;

    public float timeStack;
    public float timeGenerating;

    // arrow status
    public Vector3 arrowPos;
    public float arrowDamage;
    public float arrowDirection;
    public float arrowLocation;
    public float arrowSpeed;
    public float arrowScaler;

    void Start()
    {
        timeGenerating = 1.0f;
        arrowScaler = 1.0f;
    }

    void Update()
    {
        GenerateArrow(timeGenerating);
    }

    void GenerateArrow(float timeGenerating)
    {
        timeStack += Time.deltaTime;
        GameObject arrowGo;

        if (timeStack > timeGenerating)
        {
            RandomizeArrowStat();

            if (arrowDamage > 10.0f)
            {
                arrowGo = GameObject.Instantiate(arrowRed);
            }
            else
            {
                arrowGo = GameObject.Instantiate(arrowWhite);
            }

            SetArrowStat(arrowGo);
            timeStack = 0;
        }
    }
    void RandomizeArrowStat()
    {
        this.arrowLocation = Random.Range(-8.0f, 8.0f);
        this.arrowDamage = Random.Range(5.0f * arrowScaler, 10.49f * arrowScaler);
        this.arrowSpeed = Random.Range(0.01f * arrowScaler, 0.05f * arrowScaler);
    }
    void SetArrowStat(GameObject arrowGo)
    {
        ArrowController arrowController = arrowGo.GetComponent<ArrowController>();
        arrowGo.transform.position = new Vector3(arrowLocation, 6.0f, 0);
        arrowController.arrowDamage = (int)arrowDamage;
        arrowController.arrowSpeed = arrowSpeed;
        arrowController.arrowDirection = -1;
        arrowController.radius = 0.5f;
    }

}
