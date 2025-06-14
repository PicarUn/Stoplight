using System.Collections;
using UnityEngine;

public class Stoplight : MonoBehaviour
{
    public GameObject Sphere1, Sphere2, Sphere3;
    public MeshRenderer rend1, rend2, rend3;
    public float timer;
    public Color[] targetColor;

    void Start()
    {
        rend1 = Sphere1.GetComponent<MeshRenderer>();
        rend2 = Sphere2.GetComponent<MeshRenderer>();
        rend3 = Sphere3.GetComponent<MeshRenderer>();

        StartCoroutine(StopLightSequence());
    }

    IEnumerator StopLightSequence()
    {
        while (true)
        {
            rend1.material.color = Color.red;
            rend2.material.color = Color.gray;
            rend3.material.color = Color.gray;
            yield return new WaitForSeconds(5f);

            rend3.material.color = Color.green;
            rend1.material.color = Color.gray;
            yield return new WaitForSeconds(5f);

            rend2.material.color = Color.yellow;
            rend1.material.color = Color.gray;
            rend3.material.color = Color.gray;
            yield return new WaitForSeconds(2f);
        }
    }

    void Update()
    {

    }
}