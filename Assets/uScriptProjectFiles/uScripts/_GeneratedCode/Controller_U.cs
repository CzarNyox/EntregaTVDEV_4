//uScript Generated Code - Build 1.1.3130
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Controller_U : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   delegate void ContinueExecution();
   ContinueExecution m_ContinueExecution;
   bool m_Breakpoint = false;
   const int MaxRelayCallCount = 1000;
   int relayCallCount = 0;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   System.Single local_10_System_Single = (float) 1;
   System.Single local_11_System_Single = (float) 0;
   UnityEngine.Vector3 local_3_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_8_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_9_System_Single = (float) 0;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_7 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_ClampVector3 logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_1 = new uScriptAct_ClampVector3( );
   UnityEngine.Vector3 logic_uScriptAct_ClampVector3_Target_1 = new Vector3( );
   System.Boolean logic_uScriptAct_ClampVector3_ClampX_1 = (bool) false;
   System.Single logic_uScriptAct_ClampVector3_XMin_1 = (float) 0;
   System.Single logic_uScriptAct_ClampVector3_XMax_1 = (float) 0;
   System.Boolean logic_uScriptAct_ClampVector3_ClampY_1 = (bool) false;
   System.Single logic_uScriptAct_ClampVector3_YMin_1 = (float) 0;
   System.Single logic_uScriptAct_ClampVector3_YMax_1 = (float) 0;
   System.Boolean logic_uScriptAct_ClampVector3_ClampZ_1 = (bool) false;
   System.Single logic_uScriptAct_ClampVector3_ZMin_1 = (float) 0;
   System.Single logic_uScriptAct_ClampVector3_ZMax_1 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_ClampVector3_Result_1;
   bool logic_uScriptAct_ClampVector3_Out_1 = true;
   //pointer to script instanced logic node
   uScriptAct_GetDeltaTime logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_2 = new uScriptAct_GetDeltaTime( );
   System.Single logic_uScriptAct_GetDeltaTime_DeltaTime_2;
   System.Single logic_uScriptAct_GetDeltaTime_SmoothDeltaTime_2;
   System.Single logic_uScriptAct_GetDeltaTime_FixedDeltaTime_2;
   bool logic_uScriptAct_GetDeltaTime_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_4 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_4 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_4 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_4;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_4;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyVector3WithFloat logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_5 = new uScriptAct_MultiplyVector3WithFloat( );
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_5 = new Vector3( );
   System.Single logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_5 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_Result_5;
   bool logic_uScriptAct_MultiplyVector3WithFloat_Out_5 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   UnityEngine.Vector3 method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_translation_6 = new Vector3( );
   #pragma warning restore 414
   
   public void Awake()
   {
   }
   
   public void Start()
   {
   }
   
   public void OnEnable()
   {
   }
   
   public void OnDisable()
   {
   }
   
   public void Update()
   {
   }
   
   public void OnDestroy()
   {
   }
   
}
