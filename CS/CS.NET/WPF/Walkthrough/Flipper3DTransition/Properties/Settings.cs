﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version:2.0.40903.31
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace SettingNamespace
{


    sealed partial class SettingClass : System.Configuration.ApplicationSettingsBase
    {

        private static SettingClass m_Value;

        private static object m_SyncObject = new object();

        [System.Diagnostics.DebuggerNonUserCode()]
        public static SettingClass Value
        {
            get
            {
                if ((SettingClass.m_Value == null))
                {
                    System.Threading.Monitor.Enter(SettingClass.m_SyncObject);
                    if ((SettingClass.m_Value == null))
                    {
                        try
                        {
                            SettingClass.m_Value = new SettingClass();
                        }
                        finally
                        {
                            System.Threading.Monitor.Exit(SettingClass.m_SyncObject);
                        }
                    }
                }
                return SettingClass.m_Value;
            }
        }
    }
}
