using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class SysHandler : MonoBehaviour
{
    // We will need 12 ints in order to represent the reputation with each faction

    public Canvas canvas;

    public float repTaurus = 0.0f;
    public float repGemini = 0.0f;
    public float repCancer = 0.0f;
    public float repLeo = 0.0f;
    public float repVirgo = 0.0f;
    public float repLibra = 0.0f;
    public float repScorpio = 0.0f;
    public float repSagi = 0.0f;
    public float repCapri = 0.0f;
    public float repAqua = 0.0f;
   
    public float repAries = 0.0f;
    public float repPiscis = 0.0f;
   
    public Slider sliderTaurus;
    public Slider sliderGemini;
    public Slider sliderCancer;
    public Slider sliderLeo;
    public Slider sliderVirgo;
    public Slider sliderLibra;
    public Slider sliderScorpio;
    public Slider sliderSagi;
    public Slider sliderCapri;
    public Slider sliderAqua;

    public Slider sliderAries;
    public Slider sliderPiscis;



    void Awake()
    {
       repAries = 90.0f;
       repPiscis = 10.0f;

       repTaurus = 50.0f;
       repGemini = 50.0f;
       repCancer = 50.0f;
       repLeo = 50.0f;
       repVirgo = 50.0f;
       repLibra = 50.0f;
       repScorpio = 50.0f;
       repSagi = 50.0f;
       repCapri = 50.0f;
       repAqua = 50.0f;
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Keyboard.current.f2Key.wasPressedThisFrame)
        {
            canvas.enabled = !canvas.enabled;
        }

        UpdateSliders();
    }

    private void UpdateSliders()
    {
        sliderTaurus.value = repTaurus;
        sliderGemini.value = repGemini;
        sliderCancer.value = repCancer;
        sliderLeo.value = repLeo;
        sliderVirgo.value = repVirgo;
        sliderLibra.value = repLibra;
        sliderScorpio.value = repScorpio;
        sliderSagi.value = repSagi;
        sliderCapri.value = repCapri;
        sliderAqua.value = repAqua;


        sliderAries.value = repAries;
        sliderPiscis.value = repPiscis;
    }

    public void PiscisChange(int num)
    {
        repPiscis = repPiscis + num;

        repTaurus = repTaurus + (num/2);
        repAries = repAries - (num / 2);
    }

    public void AriesChange(int num)
    {
        repAries = repAries + num;

        repGemini = repGemini + (num / 2);
        repPiscis = repPiscis - (num / 2);
    }

    public void TaurusChange(int num)
    {
        repTaurus = repTaurus + num;

        repPiscis = repPiscis + (num / 2);
        repLeo = repLeo - (num / 2);
    }

    public void GeminiChange(int num)
    {
        repGemini = repGemini + num;

        repAries = repAries + (num / 2);
        repCapri = repCapri - (num / 2);
    }

    public void LibraChange(int num)
    {
        repLibra = repLibra + num;

        repLeo = repLeo + (num / 2);
        repVirgo = repVirgo - (num / 2);
    }

    public void VirgoChange(int num)
    {
        repVirgo = repVirgo + num;

        repCancer = repCancer + (num / 2);
        repLibra = repLibra - (num / 2);
    }
}
