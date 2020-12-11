using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectManager : MonoBehaviour
{
    // All models
    public GameObject male1;
    public GameObject male2;
    public GameObject male3;
    public GameObject male4;
    public GameObject male5;
    public GameObject male6;

    public GameObject female1;
    public GameObject female2;
    public GameObject female3;
    public GameObject female4;
    public GameObject female5;
    public GameObject female6;

    // All UI things
    public Slider ageSlide;

    public static bool ismale = true;
    public static int age = 1;

    // All other things
    public int rs = 10;

    void Start()
    {
        Resolution[] resolutions = Screen.resolutions;

        // Print the resolutions
        foreach (var res in resolutions)
        {
            Debug.Log(res.width + "x" + res.height + " : " + res.refreshRate);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if((ObjectManager.ismale) && (age == 1)){
            male1.SetActive(true);
        } else {
            male1.SetActive(false);
        }

        if((ObjectManager.ismale) && (age == 2)){
            male2.SetActive(true);
        } else {
            male2.SetActive(false);
        }

        if((ObjectManager.ismale) && (age == 3)){
            male3.SetActive(true);
        } else {
            male3.SetActive(false);
        }

        if((ObjectManager.ismale) && (age == 4)){
            male4.SetActive(true);
        } else {
            male4.SetActive(false);
        }

        if((ObjectManager.ismale) && (age == 5)){
            male5.SetActive(true);
        } else {
            male5.SetActive(false);
        }

        if((ObjectManager.ismale) && (age == 6)){
            male6.SetActive(true);
        } else {
            male6.SetActive(false);
        }

        if(!(ObjectManager.ismale) && (age == 1)){
            female1.SetActive(true);
        } else {
            female1.SetActive(false);
        }

        if(!(ObjectManager.ismale) && (age == 2)){
            female2.SetActive(true);
        } else {
            female2.SetActive(false);
        }

        if(!(ObjectManager.ismale) && (age == 3)){
            female3.SetActive(true);
        } else {
            female3.SetActive(false);
        }

        if(!(ObjectManager.ismale) && (age == 4)){
            female4.SetActive(true);
        } else {
            female4.SetActive(false);
        }

        if(!(ObjectManager.ismale) && (age == 5)){
            female5.SetActive(true);
        } else {
            female5.SetActive(false);
        }

        if(!(ObjectManager.ismale) && (age == 6)){
            female6.SetActive(true);
        } else {
            female6.SetActive(false);
        }
    }

    void FixedUpdate(){
        if(Input.GetKey(KeyCode.R)){
            male1.transform.Rotate(0,rs,0);
            male2.transform.Rotate(0,rs,0);
            male3.transform.Rotate(0,rs,0);
            male4.transform.Rotate(0,rs,0);
            male5.transform.Rotate(0,rs,0);
            male6.transform.Rotate(0,rs,0);

            female1.transform.Rotate(0,rs,0);
            female2.transform.Rotate(0,rs,0);
            female3.transform.Rotate(0,rs,0);
            female4.transform.Rotate(0,rs,0);
            female5.transform.Rotate(0,rs,0);
            female6.transform.Rotate(0,rs,0);
        }

        if(Input.GetKeyDown(KeyCode.G)){
                if(age <= 5){
                    age = age + 1;
                    ageSlide.value = age;
                }
                else {
                    age = 1;
                    ageSlide.value = age;
                }
        }

        switch ((int)ageSlide.value)
        {
            case 1:
                ObjectManager.age = 1;
                break;
            case 2:
                ObjectManager.age = 2;
                break;
            case 3:
                ObjectManager.age = 3;
                break;
            case 4:
                ObjectManager.age = 4;
                break;
            case 5:
                ObjectManager.age = 5;
                break;
            case 6:
                ObjectManager.age = 6;
                break;
            default:
                ObjectManager.age = 1;
                break;
        }
    }

    public void changeGender(){
        if((ObjectManager.ismale)){
            ObjectManager.ismale = false;
        }else{
            ObjectManager.ismale = true;
        }
    }
    
    // public void fixError1()
    // {
    //     male1.transform.position = new Vector3(0,0,-26);
    //     female1.transform.position = new Vector3(0,0,-26);
    // }
}
