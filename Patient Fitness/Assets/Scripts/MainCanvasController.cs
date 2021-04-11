using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Video;

public class MainCanvasController : MonoBehaviour
{
    public Camera mainCamera;
    public AudioClip actionSquadAudioClip, cartelTerritoryAudioClip, dayToNightAudioClip, grooveOverloadAudioClip, nightCallAudioClip, onVacationAudioClip,
        patrolDutyAudioClip, ReadyToRollAudioClip, StakeoutAudioClip, toHappyEndsAudioClip, trainingDayMontageAudioClip, wordOnTheStreetAudioClip;

    public GameObject startButton, warmupsButton, reasons10Button, reasons50Button;
    public GameObject minute2WarmupButton, minute4WarmupButton, classicWarmupButton, fightersWarmupButton, quickWarmupButton, universalWarmupButton, backButton;
    public GameObject climbersButton, highKneesButton, jumpingJacksButton, lungesButton, plankJumpInsButton, pushUpsButton, squatsButton, finishButton;

    public TMP_Text climbersText, highKneesText, jumpingJacksText, lungesText, plankJumpInsText, pushUpsText, squatsText;

    public Sprite reasons10, reasons50;
    public Sprite minute2Warmup, minute4Warmup, classicWarmup, fightersWarmup, quickWarmup, universalWarmup;

    public GameObject reasonsCanvas, image;
    public GameObject warmupsCanvas, image2;
    public GameObject videoCanvas, videoPlayer;

    public VideoClip climbersVideoClip, highKneesVideoClip, jumpingJacksVideoClip, lungesVideoClip, plankJumpInsVideoClip, pushUpsVideoClip, squatsVideoClip;

    private System.Random random;


    void Start()
    {
        random = new System.Random();
        SelectMusic(random.Next(1, 13));
    }

    void Update()
    {
        if (mainCamera.GetComponent<AudioSource>().isPlaying == false)
        {
            SelectMusic(random.Next(1, 13));
        }
    }

    public void SelectMusic(int i)
    {
        if (i == 1)
        {
            mainCamera.GetComponent<AudioSource>().clip = actionSquadAudioClip;
            mainCamera.GetComponent<AudioSource>().Play();
        }
        else if (i == 2)
        {
            mainCamera.GetComponent<AudioSource>().clip = cartelTerritoryAudioClip;
            mainCamera.GetComponent<AudioSource>().Play();
        }
        else if (i == 3)
        {
            mainCamera.GetComponent<AudioSource>().clip = dayToNightAudioClip;
            mainCamera.GetComponent<AudioSource>().Play();
        }
        else if (i == 4)
        {
            mainCamera.GetComponent<AudioSource>().clip = grooveOverloadAudioClip;
            mainCamera.GetComponent<AudioSource>().Play();
        }
        else if (i == 5)
        {
            mainCamera.GetComponent<AudioSource>().clip = nightCallAudioClip;
            mainCamera.GetComponent<AudioSource>().Play();
        }
        else if (i == 6)
        {
            mainCamera.GetComponent<AudioSource>().clip = onVacationAudioClip;
            mainCamera.GetComponent<AudioSource>().Play();
        }
        else if (i == 7)
        {
            mainCamera.GetComponent<AudioSource>().clip = patrolDutyAudioClip;
            mainCamera.GetComponent<AudioSource>().Play();
        }
        else if (i == 8)
        {
            mainCamera.GetComponent<AudioSource>().clip = ReadyToRollAudioClip;
            mainCamera.GetComponent<AudioSource>().Play();
        }
        else if (i == 9)
        {
            mainCamera.GetComponent<AudioSource>().clip = StakeoutAudioClip;
            mainCamera.GetComponent<AudioSource>().Play();
        }
        else if (i == 10)
        {
            mainCamera.GetComponent<AudioSource>().clip = toHappyEndsAudioClip;
            mainCamera.GetComponent<AudioSource>().Play();
        }
        else if (i == 11)
        {
            mainCamera.GetComponent<AudioSource>().clip = trainingDayMontageAudioClip;
            mainCamera.GetComponent<AudioSource>().Play();
        }
        else if (i == 12)
        {
            mainCamera.GetComponent<AudioSource>().clip = wordOnTheStreetAudioClip;
            mainCamera.GetComponent<AudioSource>().Play();
        }
    }

    public void StartButton()
    {
        System.Random random = new System.Random();

        startButton.SetActive(false);
        warmupsButton.SetActive(false);
        reasons10Button.SetActive(false);
        reasons50Button.SetActive(false);

        climbersText.text = "Climbers: " + random.Next(5, 21); // creates a number between 5 and 20
        highKneesText.text = "High Knees: " + random.Next(5, 21);
        jumpingJacksText.text = "Jumping Jacks: " + random.Next(5, 21);
        lungesText.text = "Lunges: " + random.Next(5, 21);
        plankJumpInsText.text = "Plank Jump-Ins: " + random.Next(5, 21);
        pushUpsText.text = "Push-Ups: " + random.Next(5, 21);
        squatsText.text = "Squats: " + random.Next(5, 21);

        climbersButton.SetActive(true);
        highKneesButton.SetActive(true);
        jumpingJacksButton.SetActive(true);
        lungesButton.SetActive(true);
        plankJumpInsButton.SetActive(true);
        pushUpsButton.SetActive(true);
        squatsButton.SetActive(true);
        finishButton.SetActive(true);
    }


    // Main Menu

    public void WarmupsButton()
    {
        startButton.SetActive(false);
        warmupsButton.SetActive(false);
        reasons10Button.SetActive(false);
        reasons50Button.SetActive(false);

        minute2WarmupButton.SetActive(true);
        minute4WarmupButton.SetActive(true);
        classicWarmupButton.SetActive(true);
        fightersWarmupButton.SetActive(true);
        quickWarmupButton.SetActive(true);
        universalWarmupButton.SetActive(true);
        backButton.SetActive(true);
    }

    public void Reasons10Button()
    {
        reasonsCanvas.SetActive(true);
        image.GetComponent<Image>().sprite = reasons10;
    }

    public void Reasons50Button()
    {
        reasonsCanvas.SetActive(true);
        image.GetComponent<Image>().sprite = reasons50;
    }

    public void CloseReasonsButton()
    {
        reasonsCanvas.SetActive(false);
    }


    // Start

    public void ClimbersButton()
    {
        finishButton.SetActive(false);
        videoPlayer.GetComponent<VideoPlayer>().clip = climbersVideoClip;
        videoCanvas.SetActive(true);    
    }

    public void HighKneesButton()
    {
        finishButton.SetActive(false);
        videoPlayer.GetComponent<VideoPlayer>().clip = highKneesVideoClip;
        videoCanvas.SetActive(true);
    }
    
    public void JumpingJacksButton()
    {
        finishButton.SetActive(false);
        videoPlayer.GetComponent<VideoPlayer>().clip = jumpingJacksVideoClip;
        videoCanvas.SetActive(true);
    }

    public void LungesButton()
    {
        finishButton.SetActive(false);
        videoPlayer.GetComponent<VideoPlayer>().clip = lungesVideoClip;
        videoCanvas.SetActive(true);
    }

    public void PlankJumpInsButton()
    {
        finishButton.SetActive(false);
        videoPlayer.GetComponent<VideoPlayer>().clip = plankJumpInsVideoClip;
        videoCanvas.SetActive(true);
    }

    public void PushUpsButton()
    {
        finishButton.SetActive(false);
        videoPlayer.GetComponent<VideoPlayer>().clip = pushUpsVideoClip;
        videoCanvas.SetActive(true);
    }

    public void SquatsButton()
    {
        finishButton.SetActive(false);
        videoPlayer.GetComponent<VideoPlayer>().clip = squatsVideoClip;
        videoCanvas.SetActive(true);
    }

    public void CloseVideoButton()
    {
        finishButton.SetActive(true);
        videoCanvas.SetActive(false);
    }

    public void FinishButton()
    {
        climbersButton.SetActive(false);
        highKneesButton.SetActive(false);
        jumpingJacksButton.SetActive(false);
        lungesButton.SetActive(false);
        plankJumpInsButton.SetActive(false);
        pushUpsButton.SetActive(false);
        squatsButton.SetActive(false);
        finishButton.SetActive(false);

        startButton.SetActive(true);
        warmupsButton.SetActive(true);
        reasons10Button.SetActive(true);
        reasons50Button.SetActive(true);
    }


    // Warmups

    public void Minute2WarmupButton()
    {
        warmupsCanvas.SetActive(true);
        image2.GetComponent<Image>().sprite = minute2Warmup;
    }

    public void Minute4WarmupButton()
    {
        warmupsCanvas.SetActive(true);
        image2.GetComponent<Image>().sprite = minute4Warmup;
    }

    public void ClassicWarmupButton()
    {
        warmupsCanvas.SetActive(true);
        image2.GetComponent<Image>().sprite = classicWarmup;
    }

    public void FightersWarmupButton()
    {
        warmupsCanvas.SetActive(true);
        image2.GetComponent<Image>().sprite = fightersWarmup;
    }

    public void QuickWarmupButton()
    {
        warmupsCanvas.SetActive(true);
        image2.GetComponent<Image>().sprite = quickWarmup;
    }

    public void UniversalWarmupButton()
    {
        warmupsCanvas.SetActive(true);
        image2.GetComponent<Image>().sprite = universalWarmup;
    }

    public void CloseWarmupButton()
    {
        warmupsCanvas.SetActive(false);
    }

    public void BackButton()
    {
        minute2WarmupButton.SetActive(false);
        minute4WarmupButton.SetActive(false);
        classicWarmupButton.SetActive(false);
        fightersWarmupButton.SetActive(false);
        quickWarmupButton.SetActive(false);
        universalWarmupButton.SetActive(false);
        backButton.SetActive(false);

        startButton.SetActive(true);
        warmupsButton.SetActive(true);
        reasons10Button.SetActive(true);
        reasons50Button.SetActive(true);
    }
}
