using UnityEngine;

//public class LoopSegment2 : MonoBehaviour
//{
//    public Animation animation;
//    public string clipName = "FallingApart";

//    public int startFrame = 1458;
//    public int endFrame = 2548;
//    public int totalFrames = 3000; // total frames of the clip

//    void Update()
//    {
//        AnimatorStateInfo state = animation.GetCurrentAnimatorStateInfo(0);

//        // Only act if we're in the FallingApart animation
//        if (state.IsName(clipName))
//        {
//            // Calculate current frame
//            int currentFrame = Mathf.RoundToInt(state.normalizedTime * totalFrames);

//            if (currentFrame >= endFrame)
//            {
//                float newTime = (float)startFrame / totalFrames;
//                animation.Play(clipName, 0, newTime);
//            }
//        }
//    }
//}
