using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story Segment")]

public class StorySegments : ScriptableObject
{
    [TextArea(25,14)] public string storyText;
    public StorySegments[] nextStorySegments;
}
