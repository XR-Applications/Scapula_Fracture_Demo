using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganManager : MonoBehaviour
{
    //ref organs in scene
    public GameObject MuscleSkin;
    public List<GameObject> Hernia;
    public GameObject Vessels;

    bool muscleOnOff = true;
    bool vesselOnOff = true;
    bool herniaOnOff = true;

    private GameObject[] organsInScene = new GameObject[] { };
    public void TurnMuscleOnOff()
    {
        AudioControl.Instance.PlayBtnPressFX();

        if (muscleOnOff == true)
        {
            MuscleSkin.SetActive(false);
            muscleOnOff = false;
        }
        else
        {
            MuscleSkin.SetActive(true);
            muscleOnOff = true;
        }
    }

    public void TurnVesselOnOff()
    {
        AudioControl.Instance.PlayBtnPressFX();

        if (vesselOnOff == true)
        {
            Vessels.SetActive(false);
            vesselOnOff = false;
        }
        else
        {
            Vessels.SetActive(true);
            vesselOnOff = true;
        }
    }

    public void TurnHerniaOnOff()
    {
        AudioControl.Instance.PlayBtnPressFX();

        if (herniaOnOff == true)
        {
            foreach (var hernia in Hernia)
            {
                hernia.SetActive(false);
            }
            herniaOnOff = false;
        }
        else
        {
            foreach (var hernia in Hernia)
            {
                hernia.SetActive(true);
            }
            herniaOnOff = true;
        }
    }

    public void SetOrganTransparency(float alphaVal)
    {
        //find active organ in scene
        organsInScene = GameObject.FindGameObjectsWithTag("Organ");
        if(organsInScene != null)
        {
            foreach (var organ in organsInScene)
            {
                //cache color of organ
                Color color = organ.GetComponent<MeshRenderer>().material.color;
                color.a = alphaVal;
                organ.GetComponent<MeshRenderer>().material.color = color;
            }
        }
    }
}
