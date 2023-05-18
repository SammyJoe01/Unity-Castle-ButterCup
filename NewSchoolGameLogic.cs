using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NewSchoolGameLogic : MonoBehaviour
{
    public TMP_Text storyContent;
    public StorySegments startingStorySegment;
    private StorySegments currentStory;
   
   
    // Start is called before the first frame update
    void Start()
    {
        currentStory = startingStorySegment;
        storyContent.text = startingStorySegment.storyText;
        
    }

    // Update is called once per frame
    void Update()
    {
        var nextStorySegments = currentStory.nextStorySegments;

        for (int i = 0; i < nextStorySegments.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                currentStory = nextStorySegments[i];
              
            }
        }

        if (currentStory.storyText != "Exit Game")
        {
            storyContent.text = currentStory.storyText;
        } else
        {
            ExitGame();
        }
    }
    
    private void ExitGame()
    {
        Application.Quit();
        //Debug.Log("Exit Game");
    }
}
