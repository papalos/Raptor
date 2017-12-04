using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldier : MonoBehaviour {
    [SerializeField]
    private Material lighting;
    [SerializeField]
    private Material basis;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Common.movingObj == this.gameObject && Common.target != null)
        {
            if (Mathf.Abs(Common.target.transform.position.x - transform.position.x) < 1 || Mathf.Abs(Common.target.transform.position.z - transform.position.z) < 1)
            {
                this.transform.position = Vector3.MoveTowards(this.transform.position, Common.target.transform.position, .2f);
                if (this.transform.position == Common.target.transform.position)
                {
                    Common.movingObj = null;
                    Common.target = null;
                }
            }
        }
        Debug.Log(Common.target + " ; " + Common.movingObj);
        if (Common.movingObj != this.gameObject)
        {
            GetComponent<Renderer>().material = basis;
        }
    }

    private void OnMouseDown()
    {
        GetComponent<Renderer>().material = lighting;
        Common.movingObj = this.gameObject;
    }
}
