﻿#pragma checksum "C:\Users\Olivr\Documents\Visual Studio 2015\Projects\App1\App1\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F780595B0459B119B1A6807045646DE7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.btnID = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnID).Click += this.btnID_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.tbID = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 18 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.tbID).TextChanged += this.textBox_TextChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnName = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnName).Click += this.button_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.tbName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 20 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.tbName).TextChanged += this.textBox_TextChanged;
                    #line default
                }
                break;
            case 5:
                {
                    this.ddlName = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 21 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.ddlName).SelectionChanged += this.ddlName_SelectionChanged;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

