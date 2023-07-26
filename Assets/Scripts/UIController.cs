using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* The UI is in the first level
 * Control UI only exists for 10 seconds
 */
public class UIController : MonoBehaviour
{
    private float StartTime;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        StartTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;
        if(time-StartTime > 10)
        {
            canvas.enabled = false;
        }
    }
}
