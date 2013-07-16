using UnityEngine;
using System.Collections;

public enum Swipe{Left,Right,Up,Down};

public class SwipeTest : MonoBehaviour {
        float screenDiagonalSize;
        float minSwipeDistancePixels;
        bool touchStarted;
        Vector2 touchStartPos;
        public float minSwipeDistance = .1f;
        public static event System.Action<Swipe> OnSwipeDetected;
		float[,] correctVal = new float[,] { {90, .5f, .5f, .5f}, 
											{90, .5f, .5f, .5f}, 
											{90, .5f, .5f, .5f},
											{90, .5f, .5f, .5f},
											{90, .5f, .5f, .5f},
	{90, .5f, .5f, .5f},
	{90, .5f, .5f, .5f},
	{90, .5f, .5f, .5f},
	{90, .5f, .5f, .5f},
	{90, .5f, .5f, .5f},
	{90, .5f, .5f, .5f},
	{90, .5f, .5f, .5f},
		{90, .5f, .5f, .5f},
		{90, .5f, .5f, .5f},
		{90, .5f, .5f, .5f},
		{90, .5f, .5f, .5f},
		{90, .5f, .5f, .5f},
		{90, .5f, .5f, .5f},
		{90, .5f, .5f, .5f},
		{90, .5f, .5f, .5f},
		{90, .5f, .5f, .5f},
		{90, .5f, .5f, .5f},
		{90, .5f, .5f, .5f},{90, .5f, .5f, .5f},{90, .5f, .5f, .5f}
	};
		int maxTests = 25;
		private int testNumber;
		public AnimationTest animTest;
	
	
        
        void Start() {
                screenDiagonalSize = Mathf.Sqrt(Screen.width * Screen.width + Screen.height * Screen.height);
                minSwipeDistancePixels = minSwipeDistance * screenDiagonalSize; 
				print ("HELLO MegaWorldPathDeform");
				testNumber = 0;
        }
        
        void Update() {
                if (Input.touchCount > 0) {
                                var touch = Input.touches[0];
                                
                                switch (touch.phase) {
                                
                                case TouchPhase.Began:
                                        touchStarted = true;
                                        touchStartPos = touch.position;
                                        break;
                                        
                                case TouchPhase.Ended:
                                        if (touchStarted) {
                                                this.TestCorrectSwipeGesture(touch);
                                                touchStarted = false;
                                        }
                                        break;
                                        
                                case TouchPhase.Canceled:
                                        touchStarted = false;
                                        break;
                                        
                                case TouchPhase.Stationary:
                                        break;

                                case TouchPhase.Moved:
                                        break;
                        }
                }               
        }
        
        void TestCorrectSwipeGesture(Touch touch){
                        Vector2 lastPos = touch.position;
                        float distance = Vector2.Distance(lastPos, touchStartPos);
                        
						if(testNumber < maxTests){
							if (TestSwipeDirection(touch, testNumber)){
								if (TestSwipeLocation(touch, testNumber)){
									if (TestSwipeDistance(touch, testNumber)){
										callNewAnimation();
									}
								}
							}
		              }
                
        }
	
			bool TestSwipeDirection(Touch touch, int testNum){
				Vector2 lastPos = touch.position;
		        float distance = Vector2.Distance(lastPos, touchStartPos);
				float correctAngle = correctVal[testNum,0];
				bool correct = false;
		        if (distance > minSwipeDistancePixels) {
					float dy = lastPos.y - touchStartPos.y;
					float dx = lastPos.x - touchStartPos.x;
		            float angle = Mathf.Rad2Deg * Mathf.Atan2(dx, dy);
					print("Angle is: " + angle);
					
					if( (angle < correctAngle +10) && (angle > correctAngle - 10) )
					{
						correct = true;
					}
					angle += 180;
					if( (angle < correctAngle +10) && (angle > correctAngle - 10) )
					{
						correct = true;
					}
				}  
				return correct;
			}
			
			bool TestSwipeLocation(Touch touch, int testNum){
		        Vector2 lastPos = touch.position;
				bool correct = false;
				Vector2 midpoint = new Vector2((touchStartPos.x + lastPos.x)/2,(touchStartPos.y + lastPos.y)/2);
				Vector2 correctMidpoint = new Vector2(correctVal[testNum,1] * Screen.width,correctVal[testNum,2] * Screen.height);
				print ("midPoint is " + midpoint);
				float spaceX = (float) Screen.width * .1f;
				float spaceY = (float) Screen.height * .1f;
				if( ( ( midpoint.x < (correctMidpoint.x + spaceX) ) && ( midpoint.x > (correctMidpoint.x - spaceX) )  ) &&  
					( ( midpoint.y < (correctMidpoint.y + spaceY) ) && ( midpoint.y > (correctMidpoint.y - spaceY) )  ) )
				{
					correct = true;
				}
				return correct;
				
			}
			
			bool TestSwipeDistance(Touch touch, int testNum){  //Tests the Swipe Distance to see if it correpsonds to the 
				Vector2 lastPos = touch.position;
				float distance = Vector2.Distance(lastPos, touchStartPos);
				float angle = correctVal[testNum,0] * 2 * Mathf.PI / 360;
				angle = angle + Mathf.PI/2;
				if(angle > Mathf.PI * 2)
				{
					angle -= Mathf.PI * 2;
				}
				float correctDistance = Mathf.Sqrt(   Mathf.Pow(correctVal[testNum,3] * Screen.width * Mathf.Cos(angle) ,2)+ 
																Mathf.Pow(correctVal[testNum,3] * Screen.height * Mathf.Sin(angle),2 ) );
				float space = correctDistance * .2f;	
				bool correct = false;
				print("distance is " + distance);
				if( (distance < correctDistance + space ) && (distance > correctDistance - space ) )
				{
					correct = true;
					print("Swipe Correct!");
				}
				return correct;
		
			}
		
			void callNewAnimation(){
				animTest.booleanChange();
				testNumber++;
			}
	
			public void resetTest(){
				testNumber = 0;
			}
				
	
}