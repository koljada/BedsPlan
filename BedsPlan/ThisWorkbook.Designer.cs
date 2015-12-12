﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Permissions;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Factory = Microsoft.Office.Tools.Excel.Factory;

#pragma warning disable 414
namespace BedsPlan {
    
    
    /// 
    [StartupObject(0)]
    [PermissionSet(SecurityAction.Demand, Name="FullTrust")]
    public sealed partial class ThisWorkbook : WorkbookBase {
        
        internal ActionsPane ActionsPane;
        
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        private Object missing = Type.Missing;
        
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        internal Application ThisApplication;
        
        /// 
        [DebuggerNonUserCode()]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ThisWorkbook(Factory factory, IServiceProvider serviceProvider) : 
                base(factory, serviceProvider, "ThisWorkbook", "ThisWorkbook") {
            Globals.Factory = factory;
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void Initialize() {
            base.Initialize();
            this.ThisApplication = this.GetHostItem<Application>(typeof(Application), "Application");
            Globals.ThisWorkbook = this;
            System.Windows.Forms.Application.EnableVisualStyles();
            this.InitializeCachedData();
            this.InitializeControls();
            this.InitializeComponents();
            this.InitializeData();
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void FinishInitialization() {
            this.InternalStartup();
            this.OnStartup();
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void InitializeDataBindings() {
            this.BeginInitialization();
            this.BindToData();
            this.EndInitialization();
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void InitializeCachedData() {
            if ((this.DataHost == null)) {
                return;
            }
            if (this.DataHost.IsCacheInitialized) {
                this.DataHost.FillCachedData(this);
            }
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void InitializeData() {
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void BindToData() {
        }
        
        /// 
        [DebuggerNonUserCode()]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        private void StartCaching(string MemberName) {
            this.DataHost.StartCaching(this, MemberName);
        }
        
        /// 
        [DebuggerNonUserCode()]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        private void StopCaching(string MemberName) {
            this.DataHost.StopCaching(this, MemberName);
        }
        
        /// 
        [DebuggerNonUserCode()]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        private bool IsCached(string MemberName) {
            return this.DataHost.IsCached(this, MemberName);
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void BeginInitialization() {
            this.BeginInit();
            this.ActionsPane.BeginInit();
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void EndInitialization() {
            this.ActionsPane.EndInit();
            this.EndInit();
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void InitializeControls() {
            this.ActionsPane = Globals.Factory.CreateActionsPane(null, null, "ActionsPane", "ActionsPane", this);
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void InitializeComponents() {
        }
        
        /// 
        [DebuggerNonUserCode()]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        private bool NeedsFill(string MemberName) {
            return this.DataHost.NeedsFill(this, MemberName);
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void OnShutdown() {
            this.ActionsPane.Dispose();
            base.OnShutdown();
        }
    }
    
    /// 
    [DebuggerNonUserCode()]
    [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
    internal sealed partial class Globals {
        
        /// 
        private Globals() {
        }
        
        private static ThisWorkbook _ThisWorkbook;
        
        private static Factory _factory;
        
        private static ThisRibbonCollection _ThisRibbonCollection;
        
        internal static ThisWorkbook ThisWorkbook {
            get {
                return _ThisWorkbook;
            }
            set {
                if ((_ThisWorkbook == null)) {
                    _ThisWorkbook = value;
                }
                else {
                    throw new NotSupportedException();
                }
            }
        }
        
        internal static Factory Factory {
            get {
                return _factory;
            }
            set {
                if ((_factory == null)) {
                    _factory = value;
                }
                else {
                    throw new NotSupportedException();
                }
            }
        }
        
        internal static ThisRibbonCollection Ribbons {
            get {
                if ((_ThisRibbonCollection == null)) {
                    _ThisRibbonCollection = new ThisRibbonCollection(_factory.GetRibbonFactory());
                }
                return _ThisRibbonCollection;
            }
        }
    }
    
    /// 
    [DebuggerNonUserCode()]
    [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "14.0.0.0")]
    internal sealed partial class ThisRibbonCollection : RibbonCollectionBase {
        
        /// 
        internal ThisRibbonCollection(RibbonFactory factory) : 
                base(factory) {
        }
    }
}
