using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMaterialChange : MonoBehaviour
{
    public GameObject player;
    public GameObject shieldVFX;
    public Vector3 shieldOffset;

    public Material playerStandard;

    public Material playerZelda;
    public Slider rimAmountSlider;
    public Slider rimThresholdSlider;

    public Material playerToonRamp;

    public Material playerOverlay;
    public Slider lerpAmountSlider;

    public Material playerDissolve;
    public Slider dissolveAmountSlider;
    public Slider noiseScaleSlider;

    public Material playerSnow;
    public Slider snowDepthSlider;
    public Slider rimPowerSlider;

    public Material playerSliced;
    public Slider sliceValueASlider;
    public Slider sliceValueBSlider;

    public Material playerPhaseInAndOut;
    public Slider splitValueSlider;

    public Material playerHologram;

    public Material playerColorRim;
    public Slider colorRimPowerSlider;

    public Material playerGradient;
    public Slider spreadSlider;
    public Slider positionSlider;

    public Material playerGhost;
    public Slider ghostNoiseScaleSlider;
    public Slider ghostNoiseWeightSlider;

    public SkinnedMeshRenderer playerArrowMeshRender;
    public SkinnedMeshRenderer playerBodyMeshRender;
    public SkinnedMeshRenderer playerBowMeshRender;

    public Material water;
    public Slider transparencySlider;
    public Slider rippleSpeedSlider;
    public Slider rippleScaleSlider;
    public Slider rippleDissolveSlider;
    public Slider normalStrengthSlider;
    public Slider foamOffsetSlider;

    public Material snow;
    public Slider upNodeSlider;
    public Slider contrastSlider;
    public Slider levelSlider;
    public Slider glossSlider;

    public Material flame;
    public Slider cutThresholdSlider;
    public Slider detailSlider;
    public Slider speedSlider;
    public Slider centerScaleSlider;

    // Start is called before the first frame update
    void Start()
    {
        rimAmountSlider.gameObject.SetActive(false);
        rimThresholdSlider.gameObject.SetActive(false);

        lerpAmountSlider.gameObject.SetActive(false);

        dissolveAmountSlider.gameObject.SetActive(false);
        noiseScaleSlider.gameObject.SetActive(false);

        snowDepthSlider.gameObject.SetActive(false);
        rimPowerSlider.gameObject.SetActive(false);

        sliceValueASlider.gameObject.SetActive(false);
        sliceValueBSlider.gameObject.SetActive(false);

        splitValueSlider.gameObject.SetActive(false);

        colorRimPowerSlider.gameObject.SetActive(false);

        spreadSlider.gameObject.SetActive(false);
        positionSlider.gameObject.SetActive(false);

        ghostNoiseScaleSlider.gameObject.SetActive(false);
        ghostNoiseWeightSlider.gameObject.SetActive(false);

        transparencySlider.gameObject.SetActive(false);
        rippleSpeedSlider.gameObject.SetActive(false);
        rippleScaleSlider.gameObject.SetActive(false);
        rippleDissolveSlider.gameObject.SetActive(false);
        normalStrengthSlider.gameObject.SetActive(false);
        foamOffsetSlider.gameObject.SetActive(false);

        upNodeSlider.gameObject.SetActive(false);
        contrastSlider.gameObject.SetActive(false);
        levelSlider.gameObject.SetActive(false);
        glossSlider.gameObject.SetActive(false);

        cutThresholdSlider.gameObject.SetActive(false);
        detailSlider.gameObject.SetActive(false);
        speedSlider.gameObject.SetActive(false);
        centerScaleSlider.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Home))
        {
            Application.Quit();
        }

        playerZelda.SetFloat("_RimAmount", rimAmountSlider.value);
        playerZelda.SetFloat("_RimThreshold", rimThresholdSlider.value);

        playerOverlay.SetFloat("_LerpAmount", lerpAmountSlider.value);

        playerDissolve.SetFloat("_DissolveAmount", dissolveAmountSlider.value);
        playerDissolve.SetFloat("_NoiseScale", noiseScaleSlider.value);

        playerSnow.SetFloat("_SnowDepth",snowDepthSlider.value);
        playerSnow.SetFloat("_RimPower", rimPowerSlider.value);

        playerSliced.SetFloat("_SliceValueA", sliceValueASlider.value);
        playerSliced.SetFloat("_SliceValueB", sliceValueBSlider.value);

        playerPhaseInAndOut.SetFloat("_SplitValue", splitValueSlider.value);

        playerColorRim.SetFloat("Vector1_C664DE1F", colorRimPowerSlider.value);

        playerGradient.SetFloat("_Spread", spreadSlider.value);
        playerGradient.SetFloat("_Position", positionSlider.value);

        playerGhost.SetFloat("_GhostNoiseScale", ghostNoiseScaleSlider.value);
        playerGhost.SetFloat("_GhostNoiseWeight", ghostNoiseWeightSlider.value);

        water.SetFloat("_Transparency", transparencySlider.value);
        water.SetFloat("_RippleSpeed", rippleSpeedSlider.value);
        water.SetFloat("_RippleScale", rippleScaleSlider.value);
        water.SetFloat("_RippleDissolve", rippleDissolveSlider.value);
        water.SetFloat("_NormalStrength", normalStrengthSlider.value);
        water.SetFloat("_FoamOffset", foamOffsetSlider.value);

        snow.SetFloat("_UpNode", upNodeSlider.value);
        snow.SetFloat("_Contrast", contrastSlider.value);
        snow.SetFloat("_Level", levelSlider.value);
        snow.SetFloat("_Gloss", glossSlider.value);

        flame.SetFloat("_CutThreshold", cutThresholdSlider.value);
        flame.SetFloat("_Detail", detailSlider.value);
        flame.SetFloat("_Speed", speedSlider.value);
        flame.SetFloat("_CenterScale", centerScaleSlider.value);
    }

    public void GetStandard()
    {
        rimAmountSlider.gameObject.SetActive(false);
        rimThresholdSlider.gameObject.SetActive(false);

        lerpAmountSlider.gameObject.SetActive(false);

        dissolveAmountSlider.gameObject.SetActive(false);
        noiseScaleSlider.gameObject.SetActive(false);

        snowDepthSlider.gameObject.SetActive(false);
        rimPowerSlider.gameObject.SetActive(false);

        sliceValueASlider.gameObject.SetActive(false);
        sliceValueBSlider.gameObject.SetActive(false);

        splitValueSlider.gameObject.SetActive(false);

        colorRimPowerSlider.gameObject.SetActive(false);

        spreadSlider.gameObject.SetActive(false);
        positionSlider.gameObject.SetActive(false);

        ghostNoiseScaleSlider.gameObject.SetActive(false);
        ghostNoiseWeightSlider.gameObject.SetActive(false);

        playerArrowMeshRender.material = playerStandard;
        playerBodyMeshRender.material = playerStandard;
        playerBowMeshRender.material = playerStandard;
    }

    public void GetZelda()
    {
        rimAmountSlider.gameObject.SetActive(false);
        rimThresholdSlider.gameObject.SetActive(false);

        lerpAmountSlider.gameObject.SetActive(false);

        dissolveAmountSlider.gameObject.SetActive(false);
        noiseScaleSlider.gameObject.SetActive(false);

        snowDepthSlider.gameObject.SetActive(false);
        rimPowerSlider.gameObject.SetActive(false);

        sliceValueASlider.gameObject.SetActive(false);
        sliceValueBSlider.gameObject.SetActive(false);

        splitValueSlider.gameObject.SetActive(false);

        colorRimPowerSlider.gameObject.SetActive(false);

        spreadSlider.gameObject.SetActive(false);
        positionSlider.gameObject.SetActive(false);

        ghostNoiseScaleSlider.gameObject.SetActive(false);
        ghostNoiseWeightSlider.gameObject.SetActive(false);

        playerArrowMeshRender.material = playerZelda;
        playerBodyMeshRender.material = playerZelda;
        playerBowMeshRender.material = playerZelda;

        rimAmountSlider.gameObject.SetActive(true);
        rimThresholdSlider.gameObject.SetActive(true);
    }

    public void GetToonRamp()
    {
        rimAmountSlider.gameObject.SetActive(false);
        rimThresholdSlider.gameObject.SetActive(false);

        lerpAmountSlider.gameObject.SetActive(false);

        dissolveAmountSlider.gameObject.SetActive(false);
        noiseScaleSlider.gameObject.SetActive(false);

        snowDepthSlider.gameObject.SetActive(false);
        rimPowerSlider.gameObject.SetActive(false);

        sliceValueASlider.gameObject.SetActive(false);
        sliceValueBSlider.gameObject.SetActive(false);

        splitValueSlider.gameObject.SetActive(false);

        colorRimPowerSlider.gameObject.SetActive(false);

        spreadSlider.gameObject.SetActive(false);
        positionSlider.gameObject.SetActive(false);

        ghostNoiseScaleSlider.gameObject.SetActive(false);
        ghostNoiseWeightSlider.gameObject.SetActive(false);

        playerArrowMeshRender.material = playerToonRamp;
        playerBodyMeshRender.material = playerToonRamp;
        playerBowMeshRender.material = playerToonRamp;

        //no slider
    }

    public void GetOverlay()
    {
        rimAmountSlider.gameObject.SetActive(false);
        rimThresholdSlider.gameObject.SetActive(false);

        lerpAmountSlider.gameObject.SetActive(false);

        dissolveAmountSlider.gameObject.SetActive(false);
        noiseScaleSlider.gameObject.SetActive(false);

        snowDepthSlider.gameObject.SetActive(false);
        rimPowerSlider.gameObject.SetActive(false);

        sliceValueASlider.gameObject.SetActive(false);
        sliceValueBSlider.gameObject.SetActive(false);

        splitValueSlider.gameObject.SetActive(false);

        colorRimPowerSlider.gameObject.SetActive(false);

        spreadSlider.gameObject.SetActive(false);
        positionSlider.gameObject.SetActive(false);

        ghostNoiseScaleSlider.gameObject.SetActive(false);
        ghostNoiseWeightSlider.gameObject.SetActive(false);

        playerArrowMeshRender.material = playerOverlay;
        playerBodyMeshRender.material = playerOverlay;
        playerBowMeshRender.material = playerOverlay;

        lerpAmountSlider.gameObject.SetActive(true);
    }

    public void GetDissove()
    {
        rimAmountSlider.gameObject.SetActive(false);
        rimThresholdSlider.gameObject.SetActive(false);

        lerpAmountSlider.gameObject.SetActive(false);

        dissolveAmountSlider.gameObject.SetActive(false);
        noiseScaleSlider.gameObject.SetActive(false);

        snowDepthSlider.gameObject.SetActive(false);
        rimPowerSlider.gameObject.SetActive(false);

        sliceValueASlider.gameObject.SetActive(false);
        sliceValueBSlider.gameObject.SetActive(false);

        splitValueSlider.gameObject.SetActive(false);

        colorRimPowerSlider.gameObject.SetActive(false);

        spreadSlider.gameObject.SetActive(false);
        positionSlider.gameObject.SetActive(false);

        ghostNoiseScaleSlider.gameObject.SetActive(false);
        ghostNoiseWeightSlider.gameObject.SetActive(false);

        playerArrowMeshRender.material = playerDissolve;
        playerBodyMeshRender.material = playerDissolve;
        playerBowMeshRender.material = playerDissolve;

        dissolveAmountSlider.gameObject.SetActive(true);
        noiseScaleSlider.gameObject.SetActive(true);
    }

    public void GetSnow()
    {
        rimAmountSlider.gameObject.SetActive(false);
        rimThresholdSlider.gameObject.SetActive(false);

        lerpAmountSlider.gameObject.SetActive(false);

        dissolveAmountSlider.gameObject.SetActive(false);
        noiseScaleSlider.gameObject.SetActive(false);

        snowDepthSlider.gameObject.SetActive(false);
        rimPowerSlider.gameObject.SetActive(false);

        sliceValueASlider.gameObject.SetActive(false);
        sliceValueBSlider.gameObject.SetActive(false);

        splitValueSlider.gameObject.SetActive(false);

        colorRimPowerSlider.gameObject.SetActive(false);

        spreadSlider.gameObject.SetActive(false);
        positionSlider.gameObject.SetActive(false);

        ghostNoiseScaleSlider.gameObject.SetActive(false);
        ghostNoiseWeightSlider.gameObject.SetActive(false);

        playerArrowMeshRender.material = playerSnow;
        playerBodyMeshRender.material = playerSnow;
        playerBowMeshRender.material = playerSnow;

        snowDepthSlider.gameObject.SetActive(true);
        rimPowerSlider.gameObject.SetActive(true);
    }

    public void GetSliced()
    {
        rimAmountSlider.gameObject.SetActive(false);
        rimThresholdSlider.gameObject.SetActive(false);

        lerpAmountSlider.gameObject.SetActive(false);

        dissolveAmountSlider.gameObject.SetActive(false);
        noiseScaleSlider.gameObject.SetActive(false);

        snowDepthSlider.gameObject.SetActive(false);
        rimPowerSlider.gameObject.SetActive(false);

        sliceValueASlider.gameObject.SetActive(false);
        sliceValueBSlider.gameObject.SetActive(false);

        splitValueSlider.gameObject.SetActive(false);

        colorRimPowerSlider.gameObject.SetActive(false);

        spreadSlider.gameObject.SetActive(false);
        positionSlider.gameObject.SetActive(false);

        ghostNoiseScaleSlider.gameObject.SetActive(false);
        ghostNoiseWeightSlider.gameObject.SetActive(false);

        playerArrowMeshRender.material = playerSliced;
        playerBodyMeshRender.material = playerSliced;
        playerBowMeshRender.material = playerSliced;

        sliceValueASlider.gameObject.SetActive(true);
        sliceValueBSlider.gameObject.SetActive(true);
    }

    public void GetPhaseInAndOut()
    {
        rimAmountSlider.gameObject.SetActive(false);
        rimThresholdSlider.gameObject.SetActive(false);

        lerpAmountSlider.gameObject.SetActive(false);

        dissolveAmountSlider.gameObject.SetActive(false);
        noiseScaleSlider.gameObject.SetActive(false);

        snowDepthSlider.gameObject.SetActive(false);
        rimPowerSlider.gameObject.SetActive(false);

        sliceValueASlider.gameObject.SetActive(false);
        sliceValueBSlider.gameObject.SetActive(false);

        splitValueSlider.gameObject.SetActive(false);

        colorRimPowerSlider.gameObject.SetActive(false);

        spreadSlider.gameObject.SetActive(false);
        positionSlider.gameObject.SetActive(false);

        ghostNoiseScaleSlider.gameObject.SetActive(false);
        ghostNoiseWeightSlider.gameObject.SetActive(false);

        playerArrowMeshRender.material = playerPhaseInAndOut;
        playerBodyMeshRender.material = playerPhaseInAndOut;
        playerBowMeshRender.material = playerPhaseInAndOut;

        splitValueSlider.gameObject.SetActive(true);
    }

    public void GetHologram()
    {
        rimAmountSlider.gameObject.SetActive(false);
        rimThresholdSlider.gameObject.SetActive(false);

        lerpAmountSlider.gameObject.SetActive(false);

        dissolveAmountSlider.gameObject.SetActive(false);
        noiseScaleSlider.gameObject.SetActive(false);

        snowDepthSlider.gameObject.SetActive(false);
        rimPowerSlider.gameObject.SetActive(false);

        sliceValueASlider.gameObject.SetActive(false);
        sliceValueBSlider.gameObject.SetActive(false);

        splitValueSlider.gameObject.SetActive(false);

        colorRimPowerSlider.gameObject.SetActive(false);

        spreadSlider.gameObject.SetActive(false);
        positionSlider.gameObject.SetActive(false);

        ghostNoiseScaleSlider.gameObject.SetActive(false);
        ghostNoiseWeightSlider.gameObject.SetActive(false);

        playerArrowMeshRender.material = playerHologram;
        playerBodyMeshRender.material = playerHologram;
        playerBowMeshRender.material = playerHologram;

        //no slider
    }

    public void GetColorRim()
    {
        rimAmountSlider.gameObject.SetActive(false);
        rimThresholdSlider.gameObject.SetActive(false);

        lerpAmountSlider.gameObject.SetActive(false);

        dissolveAmountSlider.gameObject.SetActive(false);
        noiseScaleSlider.gameObject.SetActive(false);

        snowDepthSlider.gameObject.SetActive(false);
        rimPowerSlider.gameObject.SetActive(false);

        sliceValueASlider.gameObject.SetActive(false);
        sliceValueBSlider.gameObject.SetActive(false);

        splitValueSlider.gameObject.SetActive(false);

        colorRimPowerSlider.gameObject.SetActive(false);

        spreadSlider.gameObject.SetActive(false);
        positionSlider.gameObject.SetActive(false);

        ghostNoiseScaleSlider.gameObject.SetActive(false);
        ghostNoiseWeightSlider.gameObject.SetActive(false);

        playerArrowMeshRender.material = playerColorRim;
        playerBodyMeshRender.material = playerColorRim;
        playerBowMeshRender.material = playerColorRim;

        colorRimPowerSlider.gameObject.SetActive(true);
    }

    public void GetGradient()
    {
        rimAmountSlider.gameObject.SetActive(false);
        rimThresholdSlider.gameObject.SetActive(false);

        lerpAmountSlider.gameObject.SetActive(false);

        dissolveAmountSlider.gameObject.SetActive(false);
        noiseScaleSlider.gameObject.SetActive(false);

        snowDepthSlider.gameObject.SetActive(false);
        rimPowerSlider.gameObject.SetActive(false);

        sliceValueASlider.gameObject.SetActive(false);
        sliceValueBSlider.gameObject.SetActive(false);

        splitValueSlider.gameObject.SetActive(false);

        colorRimPowerSlider.gameObject.SetActive(false);

        spreadSlider.gameObject.SetActive(false);
        positionSlider.gameObject.SetActive(false);

        ghostNoiseScaleSlider.gameObject.SetActive(false);
        ghostNoiseWeightSlider.gameObject.SetActive(false);

        playerArrowMeshRender.material = playerGradient;
        playerBodyMeshRender.material = playerGradient;
        playerBowMeshRender.material = playerGradient;

        spreadSlider.gameObject.SetActive(true);
        positionSlider.gameObject.SetActive(true);
    }

    public void GetGhost()
    {
        rimAmountSlider.gameObject.SetActive(false);
        rimThresholdSlider.gameObject.SetActive(false);

        lerpAmountSlider.gameObject.SetActive(false);

        dissolveAmountSlider.gameObject.SetActive(false);
        noiseScaleSlider.gameObject.SetActive(false);

        snowDepthSlider.gameObject.SetActive(false);
        rimPowerSlider.gameObject.SetActive(false);

        sliceValueASlider.gameObject.SetActive(false);
        sliceValueBSlider.gameObject.SetActive(false);

        splitValueSlider.gameObject.SetActive(false);

        colorRimPowerSlider.gameObject.SetActive(false);

        spreadSlider.gameObject.SetActive(false);
        positionSlider.gameObject.SetActive(false);

        ghostNoiseScaleSlider.gameObject.SetActive(false);
        ghostNoiseWeightSlider.gameObject.SetActive(false);

        playerArrowMeshRender.material = playerGhost;
        playerBodyMeshRender.material = playerGhost;
        playerBowMeshRender.material = playerGhost;

        ghostNoiseScaleSlider.gameObject.SetActive(true);
        ghostNoiseWeightSlider.gameObject.SetActive(true);
    }

    public void ShieldAppear()
    {
        var vfx = Instantiate(shieldVFX, player.transform) as GameObject;
        vfx.transform.position += shieldOffset;
        Destroy(vfx, 8.5f);
    }

    public void GetWaterSlider()
    {
        transparencySlider.gameObject.SetActive(false);
        rippleSpeedSlider.gameObject.SetActive(false);
        rippleScaleSlider.gameObject.SetActive(false);
        rippleDissolveSlider.gameObject.SetActive(false);
        normalStrengthSlider.gameObject.SetActive(false);
        foamOffsetSlider.gameObject.SetActive(false);

        upNodeSlider.gameObject.SetActive(false);
        contrastSlider.gameObject.SetActive(false);
        levelSlider.gameObject.SetActive(false);
        glossSlider.gameObject.SetActive(false);

        cutThresholdSlider.gameObject.SetActive(false);
        detailSlider.gameObject.SetActive(false);
        speedSlider.gameObject.SetActive(false);
        centerScaleSlider.gameObject.SetActive(false);

        transparencySlider.gameObject.SetActive(true);
        rippleSpeedSlider.gameObject.SetActive(true);
        rippleScaleSlider.gameObject.SetActive(true);
        rippleDissolveSlider.gameObject.SetActive(true);
        normalStrengthSlider.gameObject.SetActive(true);
        foamOffsetSlider.gameObject.SetActive(true);
    }

    public void GetSnowSlider()
    {
        transparencySlider.gameObject.SetActive(false);
        rippleSpeedSlider.gameObject.SetActive(false);
        rippleScaleSlider.gameObject.SetActive(false);
        rippleDissolveSlider.gameObject.SetActive(false);
        normalStrengthSlider.gameObject.SetActive(false);
        foamOffsetSlider.gameObject.SetActive(false);

        upNodeSlider.gameObject.SetActive(false);
        contrastSlider.gameObject.SetActive(false);
        levelSlider.gameObject.SetActive(false);
        glossSlider.gameObject.SetActive(false);

        cutThresholdSlider.gameObject.SetActive(false);
        detailSlider.gameObject.SetActive(false);
        speedSlider.gameObject.SetActive(false);
        centerScaleSlider.gameObject.SetActive(false);

        upNodeSlider.gameObject.SetActive(true);
        contrastSlider.gameObject.SetActive(true);
        levelSlider.gameObject.SetActive(true);
        glossSlider.gameObject.SetActive(true);
    }

    public void GetFlameSlider()
    {
        transparencySlider.gameObject.SetActive(false);
        rippleSpeedSlider.gameObject.SetActive(false);
        rippleScaleSlider.gameObject.SetActive(false);
        rippleDissolveSlider.gameObject.SetActive(false);
        normalStrengthSlider.gameObject.SetActive(false);
        foamOffsetSlider.gameObject.SetActive(false);

        upNodeSlider.gameObject.SetActive(false);
        contrastSlider.gameObject.SetActive(false);
        levelSlider.gameObject.SetActive(false);
        glossSlider.gameObject.SetActive(false);

        cutThresholdSlider.gameObject.SetActive(false);
        detailSlider.gameObject.SetActive(false);
        speedSlider.gameObject.SetActive(false);
        centerScaleSlider.gameObject.SetActive(false);

        cutThresholdSlider.gameObject.SetActive(true);
        detailSlider.gameObject.SetActive(true);
        speedSlider.gameObject.SetActive(true);
        centerScaleSlider.gameObject.SetActive(true);
    }
}
