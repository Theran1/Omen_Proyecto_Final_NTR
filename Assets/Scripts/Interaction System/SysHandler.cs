using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SysHandler : MonoBehaviour
{
    // We will need 12 ints in order to represent the reputation with each faction


    float repTaurus = 0.0f;
    float repGemini = 0.0f;
    float repCancer = 0.0f;
    float repLeo = 0.0f;
    float repVirgo = 0.0f;
    float repLibra = 0.0f;
    float repScorpio = 0.0f;
    float repSagi = 0.0f;
    float repCapri = 0.0f;
    float repAqua = 0.0f;

    float repAries = 0.0f;
    float repPiscis = 0.0f;

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



    void Start()
    {
        repAries = 90.0f;
        repPiscis = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
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

}
