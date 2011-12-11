//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface IRibbonUI SupportByLibraryAttribute Office, 12,14
	///</summary>
	[SupportByLibraryAttribute("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IRibbonUI : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IRibbonUI);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRibbonUI(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRibbonUI(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRibbonUI(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRibbonUI() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRibbonUI(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public void Invalidate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Invalidate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="ControlID">string ControlID</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public void InvalidateControl(string controlID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(controlID);
			Invoker.Method(this, "InvalidateControl", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// </summary>
		/// <param name="ControlID">string ControlID</param>
		[SupportByLibraryAttribute("Office", 14)]
		public void InvalidateControlMso(string controlID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(controlID);
			Invoker.Method(this, "InvalidateControlMso", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// </summary>
		/// <param name="ControlID">string ControlID</param>
		[SupportByLibraryAttribute("Office", 14)]
		public void ActivateTab(string controlID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(controlID);
			Invoker.Method(this, "ActivateTab", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// </summary>
		/// <param name="ControlID">string ControlID</param>
		[SupportByLibraryAttribute("Office", 14)]
		public void ActivateTabMso(string controlID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(controlID);
			Invoker.Method(this, "ActivateTabMso", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// </summary>
		/// <param name="ControlID">string ControlID</param>
		/// <param name="Namespace">string Namespace</param>
		[SupportByLibraryAttribute("Office", 14)]
		public void ActivateTabQ(string controlID, string _namespace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(controlID, _namespace);
			Invoker.Method(this, "ActivateTabQ", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}