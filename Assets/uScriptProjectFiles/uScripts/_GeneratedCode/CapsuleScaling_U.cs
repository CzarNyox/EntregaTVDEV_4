//uScript Generated Code - Build 1.1.3130
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class CapsuleScaling_U : uScriptLogic
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
   public UnityEngine.Vector3 AxesToScale = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_12_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_14_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_5_System_Single = (float) 0;
   System.Single local_6_System_Single = (float) 0;
   UnityEngine.Vector3 local_9_UnityEngine_Vector3 = new Vector3( (float)1, (float)1, (float)1 );
   public System.Single scaleUnits = (float) 0;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_10 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_ClampVector3 logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_1 = new uScriptAct_ClampVector3( );
   UnityEngine.Vector3 logic_uScriptAct_ClampVector3_Target_1 = new Vector3( );
   System.Boolean logic_uScriptAct_ClampVector3_ClampX_1 = (bool) true;
   System.Single logic_uScriptAct_ClampVector3_XMin_1 = (float) -1;
   System.Single logic_uScriptAct_ClampVector3_XMax_1 = (float) 1;
   System.Boolean logic_uScriptAct_ClampVector3_ClampY_1 = (bool) true;
   System.Single logic_uScriptAct_ClampVector3_YMin_1 = (float) -1;
   System.Single logic_uScriptAct_ClampVector3_YMax_1 = (float) 1;
   System.Boolean logic_uScriptAct_ClampVector3_ClampZ_1 = (bool) true;
   System.Single logic_uScriptAct_ClampVector3_ZMin_1 = (float) -1;
   System.Single logic_uScriptAct_ClampVector3_ZMax_1 = (float) 1;
   UnityEngine.Vector3 logic_uScriptAct_ClampVector3_Result_1;
   bool logic_uScriptAct_ClampVector3_Out_1 = true;
   //pointer to script instanced logic node
   uScriptAct_GetDeltaTime logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_3 = new uScriptAct_GetDeltaTime( );
   System.Single logic_uScriptAct_GetDeltaTime_DeltaTime_3;
   System.Single logic_uScriptAct_GetDeltaTime_SmoothDeltaTime_3;
   System.Single logic_uScriptAct_GetDeltaTime_FixedDeltaTime_3;
   bool logic_uScriptAct_GetDeltaTime_Out_3 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_7 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_7 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_7 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_7;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_7;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_7 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyVector3WithFloat logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_8 = new uScriptAct_MultiplyVector3WithFloat( );
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_8 = new Vector3( );
   System.Single logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_8 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_Result_8;
   bool logic_uScriptAct_MultiplyVector3WithFloat_Out_8 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectScale logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_11 = new uScriptAct_SetGameObjectScale( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectScale_Target_11 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectScale_Scale_11 = new Vector3( );
   bool logic_uScriptAct_SetGameObjectScale_Out_11 = true;
   //pointer to script instanced logic node
   uScriptAct_GetGameObjectScale logic_uScriptAct_GetGameObjectScale_uScriptAct_GetGameObjectScale_13 = new uScriptAct_GetGameObjectScale( );
   UnityEngine.GameObject logic_uScriptAct_GetGameObjectScale_Target_13 = default(UnityEngine.GameObject);
   UnityEngine.Vector3 logic_uScriptAct_GetGameObjectScale_Scale_13;
   System.Single logic_uScriptAct_GetGameObjectScale_X_13;
   System.Single logic_uScriptAct_GetGameObjectScale_Y_13;
   System.Single logic_uScriptAct_GetGameObjectScale_Z_13;
   bool logic_uScriptAct_GetGameObjectScale_Out_13 = true;
   //pointer to script instanced logic node
   uScriptAct_AddVector3_v2 logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_15 = new uScriptAct_AddVector3_v2( );
   UnityEngine.Vector3 logic_uScriptAct_AddVector3_v2_A_15 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_AddVector3_v2_B_15 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_AddVector3_v2_Result_15;
   bool logic_uScriptAct_AddVector3_v2_Out_15 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == owner_Connection_10 || false == m_RegisteredForEvents )
      {
         owner_Connection_10 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_0 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_0 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_0 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_0.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_0;
                  component.OnLateUpdate += Instance_OnLateUpdate_0;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_0;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_0 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_0;
               component.OnLateUpdate -= Instance_OnLateUpdate_0;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_1.SetParent(g);
      logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_3.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_7.SetParent(g);
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_8.SetParent(g);
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_11.SetParent(g);
      logic_uScriptAct_GetGameObjectScale_uScriptAct_GetGameObjectScale_13.SetParent(g);
      logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_15.SetParent(g);
      owner_Connection_10 = parentGameObject;
   }
   public void Awake()
   {
      
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      //reset each Update, and increments each method call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      if ( null != m_ContinueExecution )
      {
         ContinueExecution continueEx = m_ContinueExecution;
         m_ContinueExecution = null;
         m_Breakpoint = false;
         continueEx( );
         return;
      }
      UpdateEditorValues( );
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_OnUpdate_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_0( );
   }
   
   void Instance_OnLateUpdate_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_0( );
   }
   
   void Instance_OnFixedUpdate_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_0( );
   }
   
   void Relay_OnUpdate_0()
   {
      if (true == CheckDebugBreak("849ac160-cc68-496f-821f-a57e0560bd8c", "Global_Update", Relay_OnUpdate_0)) return; 
      Relay_In_1();
   }
   
   void Relay_OnLateUpdate_0()
   {
      if (true == CheckDebugBreak("849ac160-cc68-496f-821f-a57e0560bd8c", "Global_Update", Relay_OnLateUpdate_0)) return; 
   }
   
   void Relay_OnFixedUpdate_0()
   {
      if (true == CheckDebugBreak("849ac160-cc68-496f-821f-a57e0560bd8c", "Global_Update", Relay_OnFixedUpdate_0)) return; 
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("cd9779f8-0f1c-4c11-a1d2-b52046cc32c4", "Clamp_Vector3", Relay_In_1)) return; 
         {
            {
               logic_uScriptAct_ClampVector3_Target_1 = AxesToScale;
               
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_1.In(logic_uScriptAct_ClampVector3_Target_1, logic_uScriptAct_ClampVector3_ClampX_1, logic_uScriptAct_ClampVector3_XMin_1, logic_uScriptAct_ClampVector3_XMax_1, logic_uScriptAct_ClampVector3_ClampY_1, logic_uScriptAct_ClampVector3_YMin_1, logic_uScriptAct_ClampVector3_YMax_1, logic_uScriptAct_ClampVector3_ClampZ_1, logic_uScriptAct_ClampVector3_ZMin_1, logic_uScriptAct_ClampVector3_ZMax_1, out logic_uScriptAct_ClampVector3_Result_1);
         AxesToScale = logic_uScriptAct_ClampVector3_Result_1;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_1.Out;
         
         if ( test_0 == true )
         {
            Relay_In_3();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleScaling_U.uscript at Clamp Vector3.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_3()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("13b245cf-0619-4e28-b5bc-942489c3ecf7", "Get_Delta_Time", Relay_In_3)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_3.In(out logic_uScriptAct_GetDeltaTime_DeltaTime_3, out logic_uScriptAct_GetDeltaTime_SmoothDeltaTime_3, out logic_uScriptAct_GetDeltaTime_FixedDeltaTime_3);
         local_6_System_Single = logic_uScriptAct_GetDeltaTime_DeltaTime_3;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_3.Out;
         
         if ( test_0 == true )
         {
            Relay_In_7();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleScaling_U.uscript at Get Delta Time.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4905102e-e73d-48f8-8d87-bd632dd764d4", "Multiply_Float", Relay_In_7)) return; 
         {
            {
               logic_uScriptAct_MultiplyFloat_v2_A_7 = scaleUnits;
               
            }
            {
               logic_uScriptAct_MultiplyFloat_v2_B_7 = local_6_System_Single;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_7.In(logic_uScriptAct_MultiplyFloat_v2_A_7, logic_uScriptAct_MultiplyFloat_v2_B_7, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_7, out logic_uScriptAct_MultiplyFloat_v2_IntResult_7);
         local_5_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_7;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_7.Out;
         
         if ( test_0 == true )
         {
            Relay_In_8();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleScaling_U.uscript at Multiply Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_8()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("145e9094-ae0a-4163-a313-a23a4994ae71", "Multiply_Vector3_With_Float", Relay_In_8)) return; 
         {
            {
               logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_8 = AxesToScale;
               
            }
            {
               logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_8 = local_5_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_8.In(logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_8, logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_8, out logic_uScriptAct_MultiplyVector3WithFloat_Result_8);
         local_14_UnityEngine_Vector3 = logic_uScriptAct_MultiplyVector3WithFloat_Result_8;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_8.Out;
         
         if ( test_0 == true )
         {
            Relay_In_13();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleScaling_U.uscript at Multiply Vector3 With Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_11()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1093acf8-9a7b-40c5-ab72-39225abbdcbe", "Set_Scale", Relay_In_11)) return; 
         {
            {
               int index = 0;
               if ( logic_uScriptAct_SetGameObjectScale_Target_11.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_SetGameObjectScale_Target_11, index + 1);
               }
               logic_uScriptAct_SetGameObjectScale_Target_11[ index++ ] = owner_Connection_10;
               
            }
            {
               logic_uScriptAct_SetGameObjectScale_Scale_11 = local_9_UnityEngine_Vector3;
               
            }
         }
         logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_11.In(logic_uScriptAct_SetGameObjectScale_Target_11, logic_uScriptAct_SetGameObjectScale_Scale_11);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleScaling_U.uscript at Set Scale.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_13()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ca604559-12df-4d64-8d71-6b9ade12e830", "Get_Scale", Relay_In_13)) return; 
         {
            {
               logic_uScriptAct_GetGameObjectScale_Target_13 = owner_Connection_10;
               
            }
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetGameObjectScale_uScriptAct_GetGameObjectScale_13.In(logic_uScriptAct_GetGameObjectScale_Target_13, out logic_uScriptAct_GetGameObjectScale_Scale_13, out logic_uScriptAct_GetGameObjectScale_X_13, out logic_uScriptAct_GetGameObjectScale_Y_13, out logic_uScriptAct_GetGameObjectScale_Z_13);
         local_12_UnityEngine_Vector3 = logic_uScriptAct_GetGameObjectScale_Scale_13;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetGameObjectScale_uScriptAct_GetGameObjectScale_13.Out;
         
         if ( test_0 == true )
         {
            Relay_In_15();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleScaling_U.uscript at Get Scale.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("f4aa30ff-f086-47b4-a8f1-f391df91c1c6", "Add_Vector3", Relay_In_15)) return; 
         {
            {
               logic_uScriptAct_AddVector3_v2_A_15 = local_12_UnityEngine_Vector3;
               
            }
            {
               logic_uScriptAct_AddVector3_v2_B_15 = local_14_UnityEngine_Vector3;
               
            }
            {
            }
         }
         logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_15.In(logic_uScriptAct_AddVector3_v2_A_15, logic_uScriptAct_AddVector3_v2_B_15, out logic_uScriptAct_AddVector3_v2_Result_15);
         local_9_UnityEngine_Vector3 = logic_uScriptAct_AddVector3_v2_Result_15;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_15.Out;
         
         if ( test_0 == true )
         {
            Relay_In_11();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleScaling_U.uscript at Add Vector3.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleScaling_U.uscript:AxesToScale", AxesToScale);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "b6a35333-a63d-43b7-ba1a-60e089f061cb", AxesToScale);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleScaling_U.uscript:scaleUnits", scaleUnits);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "de5a221d-7688-486f-aa51-5b6a576dfc44", scaleUnits);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleScaling_U.uscript:5", local_5_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "99d6ebf5-fce7-47cd-bb65-a323d3680651", local_5_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleScaling_U.uscript:6", local_6_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "ba13bb00-5b11-4ea2-afb8-347dc3423d8c", local_6_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleScaling_U.uscript:9", local_9_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "81824c14-668d-4ff0-b876-dd08c63bbb9b", local_9_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleScaling_U.uscript:12", local_12_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "fe740964-8ed4-4290-8504-3369becea703", local_12_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleScaling_U.uscript:14", local_14_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "6c1a3df4-ed79-4be4-ba44-37cdd04cc428", local_14_UnityEngine_Vector3);
   }
   bool CheckDebugBreak(string guid, string name, ContinueExecution method)
   {
      if (true == m_Breakpoint) return true;
      
      if (true == uScript_MasterComponent.FindBreakpoint(guid))
      {
         if (uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint == guid)
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = "";
         }
         else
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = guid;
            UpdateEditorValues( );
            UnityEngine.Debug.Log("uScript BREAK Node:" + name + " ((Time: " + Time.time + "");
            UnityEngine.Debug.Break();
            #if (!UNITY_FLASH)
            m_ContinueExecution = new ContinueExecution(method);
            #endif
            m_Breakpoint = true;
            return true;
         }
      }
      return false;
   }
}
