/**
 * Copyright (C) 2005-2013 by Rivello Multimedia Consulting (RMC).                    
 * code [at] RivelloMultimediaConsulting [dot] com                                                  
 *                                                                      
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the      
 * "Software"), to deal in the Software without restriction, including  
 * without limitation the rights to use, copy, modify, merge, publish,  
 * distribute, sublicense, and#or sell copies of the Software, and to   
 * permit persons to whom the Software is furnished to do so, subject to
 * the following conditions:                                            
 *                                                                      
 * The above copyright notice and this permission notice shall be       
 * included in all copies or substantial portions of the Software.      
 *                                                                      
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,      
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF   
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
 * IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR    
 * OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.     
 * 
 */
// Marks the right margin of code *******************************************************************


//--------------------------------------
//  Imports
//--------------------------------------
using System;

//--------------------------------------
//  Namespace
//--------------------------------------
using UnityEngine;


namespace com.rmc.utilities
{
	
	//--------------------------------------
	//  Namespace Properties
	//--------------------------------------
	
	
	//--------------------------------------
	//  Class Attributes
	//--------------------------------------
	
	
	//--------------------------------------
	//  Class
	//--------------------------------------
	public static class DebugDraw
	{
		
		//--------------------------------------
		//  Attributes 
		//--------------------------------------
		
		//--------------------------------------
		//  Properties
		//--------------------------------------
		
		//--------------------------------------
		//  Methods
		//--------------------------------------

		/// <summary>
		/// Draws the rect.
		/// </summary>
		/// <param name="aRect">A rect.</param>
		/// <param name="zCoordinate_float">Z coordinate_float.</param>
		public static void DrawRect (Rect aRect, float aZPlaneCoordinate_float)
		{
	
			//Debug.Log ("x: " + aRect.x + " ,y= " + aRect.y);
			//DRAW BOX FROM BOTTOM LEFT AND GO CLOCKWISE
			Debug.DrawLine (new Vector3 (aRect.x, aRect.y, aZPlaneCoordinate_float), 								new Vector3 (aRect.x, aRect.y + aRect.height, aZPlaneCoordinate_float));
			Debug.DrawLine (new Vector3 (aRect.x, aRect.y + aRect.height, aZPlaneCoordinate_float), 				new Vector3 (aRect.x + aRect.width, aRect.y + aRect.height, aZPlaneCoordinate_float));
			Debug.DrawLine (new Vector3 (aRect.x + aRect.width, aRect.y + aRect.height, aZPlaneCoordinate_float), new Vector3 (aRect.x + aRect.width, aRect.y, aZPlaneCoordinate_float)	);
			Debug.DrawLine (new Vector3 (aRect.x + aRect.width, aRect.y, aZPlaneCoordinate_float), 				new Vector3 (aRect.x, aRect.y, aZPlaneCoordinate_float));

		}


		/// <summary>
		/// Draws the center point crosshairs for rect.
		/// </summary>
		/// <param name="rect">Rect.</param>
		/// <param name="_zPlaneCoordinate_float">_z plane coordinate_float.</param>
		public static void DrawCenterPointCrosshairsForRect (Rect aRect, float aZPlaneCoordinate_float)
		{
			//Debug.Log ("DRAW" + aRect);
			float crossHairLength_float = 1;

			//LOWER LEFT TO UPPER RIGHT
			Debug.DrawLine 	(
				new Vector3 (aRect.center.x - crossHairLength_float/2, aRect.center.y - crossHairLength_float/2, aZPlaneCoordinate_float), 								
				new Vector3 (aRect.center.x + crossHairLength_float/2, aRect.center.y + crossHairLength_float/2, aZPlaneCoordinate_float) 
			                );

			//UPPER LEFT TO LOWER LEFT
			Debug.DrawLine 	(
				new Vector3 (aRect.center.x - crossHairLength_float/2, aRect.center.y + crossHairLength_float/2, aZPlaneCoordinate_float), 								
				new Vector3 (aRect.center.x + crossHairLength_float/2, aRect.center.y - crossHairLength_float/2, aZPlaneCoordinate_float) 
				);



		}


		//--------------------------------------
		//  Events
		//--------------------------------------



	}
}

