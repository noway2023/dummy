using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slidercontrol : MonoBehaviour
{
    public Slider[] sliders;
    public GameObject[] joints;
    public Text[] values;
    public Toggle reset;
    int i;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i = -1;
        //reset
        if (reset.isOn)
        {
            foreach (var slider in sliders)
            {
                slider.value = 0;
            }
        }

        // J1
        joints[++i].transform.localEulerAngles = new Vector3(0f, sliders[i].value, 0f);
        values[i].text = Mathf.RoundToInt(sliders[i].value).ToString();
        // J2
        joints[++i].transform.localEulerAngles = new Vector3(sliders[i].value, 0f, 0f);
        values[i].text = Mathf.RoundToInt(sliders[i].value).ToString();
        // J3
        joints[++i].transform.localEulerAngles = new Vector3(sliders[i].value, 0f, 0f);
        values[i].text = Mathf.RoundToInt(sliders[i].value).ToString();
        // J4
        joints[++i].transform.localEulerAngles = new Vector3(0f, 0f, sliders[i].value);
        values[i].text = Mathf.RoundToInt(sliders[i].value).ToString();
        // J5
        joints[++i].transform.localEulerAngles = new Vector3(sliders[i].value, 0f, 0f);
        values[i].text = Mathf.RoundToInt(sliders[i].value).ToString();
        // J6
        joints[++i].transform.localEulerAngles = new Vector3(0f, 0f, sliders[i].value);
        values[i].text = Mathf.RoundToInt(sliders[i].value).ToString();

    }
}
