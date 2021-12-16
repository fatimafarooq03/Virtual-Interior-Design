using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bedbuttonsroom4 : MonoBehaviour
{

    [SerializeField]
    Button bed1Btn, bed2Btn, bed3Btn;
    [SerializeField]
    GameObject bed1room4, bed2room4, bed3room4;

    // Start is called before the first frame update
    void Start()
    {
        bed1Btn.onClick.AddListener(bed1BtnPressed);
        bed2Btn.onClick.AddListener(bed2BtnPressed);
        bed3Btn.onClick.AddListener(bed3BtnPressed);
    }

    void bed1BtnPressed()
    {
        Debug.Log("Bed 1");
        GameObject bed = Instantiate(bed1room4);
        bed.transform.position = Camera.main.transform.position + 4 * Camera.main.transform.forward;
    }

    void bed2BtnPressed()
    {
        GameObject bed = Instantiate(bed2room4);
        bed.transform.position = Camera.main.transform.position + 4 * Camera.main.transform.forward;
    }


    void bed3BtnPressed()
    {
        GameObject bed = Instantiate(bed3room4);
        bed.transform.position = Camera.main.transform.position + 4 * Camera.main.transform.forward;
    }



    // Update is called once per frame
    void Update()
    {

    }

    GameObject GetClickedObject(out RaycastHit hit)
    {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
        {
            target = hit.collider.gameObject;
        }

        return target;
    }
}
