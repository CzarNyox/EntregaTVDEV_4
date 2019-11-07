//uScript Generated Code - Build 1.1.3130
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class CapsuleMovement_U : uScriptLogic
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
   public UnityEngine.Vector3 Direction = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_1_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_3_System_Single = (float) 0;
   System.Single local_4_System_Single = (float) 0;
   public System.Single speed = (float) 1;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_11 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_ClampVector3 logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_6 = new uScriptAct_ClampVector3( );
   UnityEngine.Vector3 logic_uScriptAct_ClampVector3_Target_6 = new Vector3( );
   System.Boolean logic_uScriptAct_ClampVector3_ClampX_6 = (bool) true;
   System.Single logic_uScriptAct_ClampVector3_XMin_6 = (float) -1;
   System.Single logic_uScriptAct_ClampVector3_XMax_6 = (float) 1;
   System.Boolean logic_uScriptAct_ClampVector3_ClampY_6 = (bool) true;
   System.Single logic_uScriptAct_ClampVector3_YMin_6 = (float) -1;
   System.Single logic_uScriptAct_ClampVector3_YMax_6 = (float) 1;
   System.Boolean logic_uScriptAct_ClampVector3_ClampZ_6 = (bool) true;
   System.Single logic_uScriptAct_ClampVector3_ZMin_6 = (float) -1;
   System.Single logic_uScriptAct_ClampVector3_ZMax_6 = (float) 1;
   UnityEngine.Vector3 logic_uScriptAct_ClampVector3_Result_6;
   bool logic_uScriptAct_ClampVector3_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_GetDeltaTime logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_7 = new uScriptAct_GetDeltaTime( );
   System.Single logic_uScriptAct_GetDeltaTime_DeltaTime_7;
   System.Single logic_uScriptAct_GetDeltaTime_SmoothDeltaTime_7;
   System.Single logic_uScriptAct_GetDeltaTime_FixedDeltaTime_7;
   bool logic_uScriptAct_GetDeltaTime_Out_7 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyVector3WithFloat logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_8 = new uScriptAct_MultiplyVector3WithFloat( );
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_8 = new Vector3( );
   System.Single logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_8 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_Result_8;
   bool logic_uScriptAct_MultiplyVector3WithFloat_Out_8 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_9 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_9 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_9 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_9;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_9;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_9 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   UnityEngine.Vector3 method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_translation_10 = new Vector3( );
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == owner_Connection_11 || false == m_RegisteredForEvents )
      {
         owner_Connection_11 = parentGameObject;
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
      
      logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_6.SetParent(g);
      logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_7.SetParent(g);
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_8.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_9.SetParent(g);
      owner_Connection_11 = parentGameObject;
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
      if (true == CheckDebugBreak("9abb92f4-7d50-4fe5-a4aa-97d38e606885", "Global_Update", Relay_OnUpdate_0)) return; 
      Relay_In_6();
   }
   
   void Relay_OnLateUpdate_0()
   {
      if (true == CheckDebugBreak("9abb92f4-7d50-4fe5-a4aa-97d38e606885", "Global_Update", Relay_OnLateUpdate_0)) return; 
   }
   
   void Relay_OnFixedUpdate_0()
   {
      if (true == CheckDebugBreak("9abb92f4-7d50-4fe5-a4aa-97d38e606885", "Global_Update", Relay_OnFixedUpdate_0)) return; 
   }
   
   void Relay_In_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("7d24bcd5-7730-4d72-a98f-5f646df8c62b", "Clamp_Vector3", Relay_In_6)) return; 
         {
            {
               logic_uScriptAct_ClampVector3_Target_6 = Direction;
               
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
         logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_6.In(logic_uScriptAct_ClampVector3_Target_6, logic_uScriptAct_ClampVector3_ClampX_6, logic_uScriptAct_ClampVector3_XMin_6, logic_uScriptAct_ClampVector3_XMax_6, logic_uScriptAct_ClampVector3_ClampY_6, logic_uScriptAct_ClampVector3_YMin_6, logic_uScriptAct_ClampVector3_YMax_6, logic_uScriptAct_ClampVector3_ClampZ_6, logic_uScriptAct_ClampVector3_ZMin_6, logic_uScriptAct_ClampVector3_ZMax_6, out logic_uScriptAct_ClampVector3_Result_6);
         Direction = logic_uScriptAct_ClampVector3_Result_6;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_6.Out;
         
         if ( test_0 == true )
         {
            Relay_In_7();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleMovement_U.uscript at Clamp Vector3.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("8b7698c4-5597-4882-b527-f942ec8dc4cf", "Get_Delta_Time", Relay_In_7)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_7.In(out logic_uScriptAct_GetDeltaTime_DeltaTime_7, out logic_uScriptAct_GetDeltaTime_SmoothDeltaTime_7, out logic_uScriptAct_GetDeltaTime_FixedDeltaTime_7);
         local_3_System_Single = logic_uScriptAct_GetDeltaTime_DeltaTime_7;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_7.Out;
         
         if ( test_0 == true )
         {
            Relay_In_9();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleMovement_U.uscript at Get Delta Time.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_8()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("88e6be1c-afb3-4161-a24b-d4708aa2c284", "Multiply_Vector3_With_Float", Relay_In_8)) return; 
         {
            {
               logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_8 = Direction;
               
            }
            {
               logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_8 = local_4_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_8.In(logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_8, logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_8, out logic_uScriptAct_MultiplyVector3WithFloat_Result_8);
         local_1_UnityEngine_Vector3 = logic_uScriptAct_MultiplyVector3WithFloat_Result_8;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_8.Out;
         
         if ( test_0 == true )
         {
            Relay_Translate_10();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleMovement_U.uscript at Multiply Vector3 With Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_9()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("924eeabe-f2e9-474e-ad09-941d49a69091", "Multiply_Float", Relay_In_9)) return; 
         {
            {
               logic_uScriptAct_MultiplyFloat_v2_A_9 = speed;
               
            }
            {
               logic_uScriptAct_MultiplyFloat_v2_B_9 = local_3_System_Single;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_9.In(logic_uScriptAct_MultiplyFloat_v2_A_9, logic_uScriptAct_MultiplyFloat_v2_B_9, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_9, out logic_uScriptAct_MultiplyFloat_v2_IntResult_9);
         local_4_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_9;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_9.Out;
         
         if ( test_0 == true )
         {
            Relay_In_8();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleMovement_U.uscript at Multiply Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Translate_10()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b595a638-f56d-4057-a969-a091afc77322", "UnityEngine_Transform", Relay_Translate_10)) return; 
         {
            {
            }
            {
               method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_translation_10 = local_1_UnityEngine_Vector3;
               
            }
         }
         {
            UnityEngine.Transform component;
            component = owner_Connection_11.GetComponent<UnityEngine.Transform>();
            if ( null != component )
            {
               component.Translate(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_translation_10);
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleMovement_U.uscript at UnityEngine.Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleMovement_U.uscript:1", local_1_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "00bb8f19-725f-44e3-bb10-b04c3a84cc77", local_1_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleMovement_U.uscript:Direction", Direction);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "9c8d8c9b-5d29-4b8b-9111-3c3defd64b93", Direction);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleMovement_U.uscript:3", local_3_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "3b711b76-391b-4a47-be7d-af0723927d25", local_3_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleMovement_U.uscript:4", local_4_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "863ae871-412d-4d52-bb09-fe2e289a7326", local_4_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleMovement_U.uscript:speed", speed);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "2cd1a641-3365-4757-b595-ff76bd068a5f", speed);
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
