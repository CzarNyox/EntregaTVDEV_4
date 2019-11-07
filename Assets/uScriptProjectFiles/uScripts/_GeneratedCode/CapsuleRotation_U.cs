//uScript Generated Code - Build 1.1.3130
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class CapsuleRotation_U : uScriptLogic
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
   public UnityEngine.Vector3 Ejes = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_16_System_Single = (float) 0;
   System.Single local_17_System_Single = (float) 0;
   UnityEngine.Vector3 local_7_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   public System.Single speed = (float) 1;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_11 = null;
   
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
   uScriptAct_GetDeltaTime logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_2 = new uScriptAct_GetDeltaTime( );
   System.Single logic_uScriptAct_GetDeltaTime_DeltaTime_2;
   System.Single logic_uScriptAct_GetDeltaTime_SmoothDeltaTime_2;
   System.Single logic_uScriptAct_GetDeltaTime_FixedDeltaTime_2;
   bool logic_uScriptAct_GetDeltaTime_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_3 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_3 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_3 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_3;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_3;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_3 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyVector3WithFloat logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_9 = new uScriptAct_MultiplyVector3WithFloat( );
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_9 = new Vector3( );
   System.Single logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_9 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_Result_9;
   bool logic_uScriptAct_MultiplyVector3WithFloat_Out_9 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   UnityEngine.Vector3 method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_eulers_12 = new Vector3( );
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
      
      logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_1.SetParent(g);
      logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_2.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_3.SetParent(g);
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_9.SetParent(g);
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
      if (true == CheckDebugBreak("ec590612-7cf9-4481-a0a0-fd49663277ef", "Global_Update", Relay_OnUpdate_0)) return; 
      Relay_In_1();
   }
   
   void Relay_OnLateUpdate_0()
   {
      if (true == CheckDebugBreak("ec590612-7cf9-4481-a0a0-fd49663277ef", "Global_Update", Relay_OnLateUpdate_0)) return; 
   }
   
   void Relay_OnFixedUpdate_0()
   {
      if (true == CheckDebugBreak("ec590612-7cf9-4481-a0a0-fd49663277ef", "Global_Update", Relay_OnFixedUpdate_0)) return; 
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("5a124e18-bd0b-497e-a255-92316888b4a4", "Clamp_Vector3", Relay_In_1)) return; 
         {
            {
               logic_uScriptAct_ClampVector3_Target_1 = Ejes;
               
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
         Ejes = logic_uScriptAct_ClampVector3_Result_1;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_ClampVector3_uScriptAct_ClampVector3_1.Out;
         
         if ( test_0 == true )
         {
            Relay_In_2();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleRotation_U.uscript at Clamp Vector3.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("5f60b420-7769-4f4e-9293-7ab80b093093", "Get_Delta_Time", Relay_In_2)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_2.In(out logic_uScriptAct_GetDeltaTime_DeltaTime_2, out logic_uScriptAct_GetDeltaTime_SmoothDeltaTime_2, out logic_uScriptAct_GetDeltaTime_FixedDeltaTime_2);
         local_17_System_Single = logic_uScriptAct_GetDeltaTime_DeltaTime_2;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetDeltaTime_uScriptAct_GetDeltaTime_2.Out;
         
         if ( test_0 == true )
         {
            Relay_In_3();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleRotation_U.uscript at Get Delta Time.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_3()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("505a6c11-562d-4b51-8e98-ace76873a39c", "Multiply_Float", Relay_In_3)) return; 
         {
            {
               logic_uScriptAct_MultiplyFloat_v2_A_3 = speed;
               
            }
            {
               logic_uScriptAct_MultiplyFloat_v2_B_3 = local_17_System_Single;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_3.In(logic_uScriptAct_MultiplyFloat_v2_A_3, logic_uScriptAct_MultiplyFloat_v2_B_3, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_3, out logic_uScriptAct_MultiplyFloat_v2_IntResult_3);
         local_16_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_3;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_3.Out;
         
         if ( test_0 == true )
         {
            Relay_In_9();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleRotation_U.uscript at Multiply Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_9()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("56779eea-4793-4ce7-90d5-0f09ecd117ae", "Multiply_Vector3_With_Float", Relay_In_9)) return; 
         {
            {
               logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_9 = Ejes;
               
            }
            {
               logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_9 = local_16_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_9.In(logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_9, logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_9, out logic_uScriptAct_MultiplyVector3WithFloat_Result_9);
         local_7_UnityEngine_Vector3 = logic_uScriptAct_MultiplyVector3WithFloat_Result_9;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_9.Out;
         
         if ( test_0 == true )
         {
            Relay_Rotate_12();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleRotation_U.uscript at Multiply Vector3 With Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Rotate_12()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("51889e1d-874f-4421-aa57-7aaa9ee52e27", "UnityEngine_Transform", Relay_Rotate_12)) return; 
         {
            {
            }
            {
               method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_eulers_12 = local_7_UnityEngine_Vector3;
               
            }
         }
         {
            UnityEngine.Transform component;
            component = owner_Connection_11.GetComponent<UnityEngine.Transform>();
            if ( null != component )
            {
               component.Rotate(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_eulers_12);
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript CapsuleRotation_U.uscript at UnityEngine.Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleRotation_U.uscript:7", local_7_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "6f6c9145-7a12-4475-9c63-93d96e5e50b1", local_7_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleRotation_U.uscript:Ejes", Ejes);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "b4492781-5ce1-4002-9918-e3cd5d6c9d18", Ejes);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleRotation_U.uscript:speed", speed);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "edc07e33-0e2f-4f35-9d69-c983f7a67f95", speed);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleRotation_U.uscript:16", local_16_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "8f9f6d0f-b296-44e9-b455-53cb1c13253b", local_16_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "CapsuleRotation_U.uscript:17", local_17_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "218cb206-704b-4ca4-82ea-e61ec4eb3961", local_17_System_Single);
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
