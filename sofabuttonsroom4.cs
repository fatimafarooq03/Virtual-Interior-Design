using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sofabuttonsroom4 : MonoBehaviour
{

    [SerializeField]
    Button sofa1Btn, sofa2Btn, sofa3Btn, sofa4Btn, sofa5Btn;
    [SerializeField]
    GameObject sofa1room4, sofa2room4, sofa3room4, sofa4room4, sofa5room4;

    // Start is called before the first frame update
    void Start()
    {
        sofa1Btn.onClick.AddListener(sofa1BtnPressed);
        sofa2Btn.onClick.AddListener(sofa2BtnPressed);
        sofa3Btn.onClick.AddListener(sofa3BtnPressed);
        sofa4Btn.onClick.AddListener(sofa4BtnPressed);
        sofa5Btn.onClick.AddListener(sofa5BtnPressed);

    }

    void sofa1BtnPressed()
    {
        Debug.Log("Sofa 1");
        GameObject sofa = Instantiate(sofa1room4);
        sofa.transform.position = Camera.main.transform.position + 4 * Camera.main.transform.forward;

    }

    void sofa2BtnPressed()
    {
        GameObject sofa = Instantiate(sofa2room4);
        sofa.transform.position = Camera.main.transform.position + 4 * Camera.main.transform.forward;
    }




    void sofa3BtnPressed()
    {
        GameObject sofa = Instantiate(sofa3room4);
        sofa.transform.position = Camera.main.transform.position + 4 * Camera.main.transform.forward;
    }

    void sofa4BtnPressed()
    {
        GameObject sofa = Instantiate(sofa4room4);
        sofa.transform.position = Camera.main.transform.position + 4 * Camera.main.transform.forward;
    }

    void sofa5BtnPressed()
    {
        GameObject sofa = Instantiate(sofa5room4);
        sofa.transform.position = Camera.main.transform.position + 4 * Camera.main.transform.forward;
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
