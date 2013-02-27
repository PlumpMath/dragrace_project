using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class dragtree_ai : MonoBehaviour
{

    public string pslight = "prestagelights";
    public string slight = "stagelights";
    public GameObject[] psl_obj;
    public GameObject[] sl_obj;
    public GameObject yt1l;
    public GameObject yt2l;
    public GameObject yt3l;
    public GameObject yt1r;
    public GameObject yt2r;
    public GameObject yt3r;
    public GameObject greenleft;
    public GameObject greenright;
    public GameObject redleft;
    public GameObject redright;
    public bool jumped_left;
    public bool jumped_right;
    public float treetime = 0.5f;
    // Use this for initialization
    void Start()
    {
        yt1l.light.enabled = false;
        yt2l.light.enabled = false;
        yt3l.light.enabled = false;
        yt1r.light.enabled = false;
        yt2r.light.enabled = false;
        yt3r.light.enabled = false;
        greenleft.light.enabled = false;
        greenright.light.enabled = false;
        redleft.light.enabled = false;
        redright.light.enabled = false;
        psl_obj = GameObject.FindGameObjectsWithTag(pslight);
        sl_obj = GameObject.FindGameObjectsWithTag(slight);
        foreach (GameObject psl in psl_obj)
        {
            psl.light.enabled = false;
        }
        foreach (GameObject sl in sl_obj)
        {
            sl.light.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(treelit());
        }
    }
    void pre_stage()
    {
        //Start of tree. Player must be ready
        foreach (GameObject psl in psl_obj)
        {
            psl.light.enabled = true;
        }
    }

    void stage()
    {
        //tree is about to trip teirs.No stopping now.
        foreach (GameObject sl in sl_obj)
        {
            sl.light.enabled = true;
        }
    }

    void teir1()
    {
        //quickly flow through teirs
        yt1l.light.enabled = true;
        yt1r.light.enabled = true;

    }

    void teir2()
    {
        //quickly flow through teirs
        yt2l.light.enabled = true;
        yt2r.light.enabled = true;
    }

    void teir3()
    {
        //quickly flow through teirs
        yt3l.light.enabled = true;
        yt3r.light.enabled = true;
    }

    void green()
    {
        //if line is jumped then disable green light for that lane
        //Once lit disable red and prevent a jump
        //LEFT

        //if line is jumped then disable green light for that lane
        //Once lit disable red and prevent a jump
        //right


        //TEMP
        greenleft.light.enabled = true;
        greenright.light.enabled = true;
    }

    void red()
    {
        //if line is jumped then enable red light
        //if player jumps the line
        //LEFT

        //if player jump the line
        //right
    }
    IEnumerator treelit()
    {
        //forces tree to start.
        pre_stage();
        yield return new WaitForSeconds(treetime);
        stage();
        yield return new WaitForSeconds(treetime);
        teir1();
        yield return new WaitForSeconds(treetime);
        teir2();
        yield return new WaitForSeconds(treetime);
        teir3();
        yield return new WaitForSeconds(treetime);
        green();
    }
}
