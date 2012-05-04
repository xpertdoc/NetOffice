//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.OutlookApi.GlobalHelperModules
{
	///<summary>
	/// Module GlobalModule
	///</summary>
	[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsModule)]
	public static class GlobalModule
	{

		#region Fields

		private static COMObject _instance;

        internal static COMObject Instance
        {
	        get
	        {
		        return _instance;
	        }
	        set
	        {
		        if( (null == value) || (null == _instance) )
			        _instance = value;				
        	}
        }

		#endregion
		#region Properties

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Class", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Parent", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static NetOffice.OfficeApi.Assistant Assistant
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Assistant", paramsArray);
				NetOffice.OfficeApi.Assistant newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.Assistant.LateBindingApiWrapperType) as NetOffice.OfficeApi.Assistant;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static string Version
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Version", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static NetOffice.OfficeApi.COMAddIns COMAddIns
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "COMAddIns", paramsArray);
				NetOffice.OfficeApi.COMAddIns newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.COMAddIns.LateBindingApiWrapperType) as NetOffice.OfficeApi.COMAddIns;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static NetOffice.OutlookApi._Explorers Explorers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Explorers", paramsArray);
				NetOffice.OutlookApi._Explorers newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.OutlookApi._Explorers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static NetOffice.OutlookApi._Inspectors Inspectors
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Inspectors", paramsArray);
				NetOffice.OutlookApi._Inspectors newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.OutlookApi._Inspectors;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static NetOffice.OfficeApi.LanguageSettings LanguageSettings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "LanguageSettings", paramsArray);
				NetOffice.OfficeApi.LanguageSettings newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.LanguageSettings.LateBindingApiWrapperType) as NetOffice.OfficeApi.LanguageSettings;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static string ProductCode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ProductCode", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static NetOffice.OfficeApi.AnswerWizard AnswerWizard
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "AnswerWizard", paramsArray);
				NetOffice.OfficeApi.AnswerWizard newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.AnswerWizard.LateBindingApiWrapperType) as NetOffice.OfficeApi.AnswerWizard;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static NetOffice.OfficeApi.Enums.MsoFeatureInstall FeatureInstall
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "FeatureInstall", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoFeatureInstall)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(_instance, "FeatureInstall", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 10,11,12,14)]
		public static NetOffice.OutlookApi._Reminders Reminders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Reminders", paramsArray);
				NetOffice.OutlookApi._Reminders newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.OutlookApi._Reminders;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public static string DefaultProfileName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "DefaultProfileName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public static bool IsTrusted
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "IsTrusted", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public static NetOffice.OfficeApi.IAssistance Assistance
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Assistance", paramsArray);
				NetOffice.OfficeApi.IAssistance newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.IAssistance.LateBindingApiWrapperType) as NetOffice.OfficeApi.IAssistance;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public static NetOffice.OutlookApi.TimeZones TimeZones
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "TimeZones", paramsArray);
				NetOffice.OutlookApi.TimeZones newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OutlookApi.TimeZones.LateBindingApiWrapperType) as NetOffice.OutlookApi.TimeZones;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 14)]
		public static NetOffice.OfficeApi.PickerDialog PickerDialog
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "PickerDialog", paramsArray);
				NetOffice.OfficeApi.PickerDialog newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.PickerDialog.LateBindingApiWrapperType) as NetOffice.OfficeApi.PickerDialog;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static NetOffice.OutlookApi._Explorer ActiveExplorer()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(_instance, "ActiveExplorer", paramsArray);
			NetOffice.OutlookApi._Explorer newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.OutlookApi._Explorer;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static NetOffice.OutlookApi._Inspector ActiveInspector()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(_instance, "ActiveInspector", paramsArray);
			NetOffice.OutlookApi._Inspector newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.OutlookApi._Inspector;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="itemType">NetOffice.OutlookApi.Enums.OlItemType ItemType</param>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static object CreateItem(NetOffice.OutlookApi.Enums.OlItemType itemType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(itemType);
			object returnItem = Invoker.MethodReturn(_instance, "CreateItem", paramsArray);
			object newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="templatePath">string TemplatePath</param>
		/// <param name="inFolder">optional object InFolder</param>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static object CreateItemFromTemplate(string templatePath, object inFolder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(templatePath, inFolder);
			object returnItem = Invoker.MethodReturn(_instance, "CreateItemFromTemplate", paramsArray);
			object newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="templatePath">string TemplatePath</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static object CreateItemFromTemplate(string templatePath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(templatePath);
			object returnItem = Invoker.MethodReturn(_instance, "CreateItemFromTemplate", paramsArray);
			object newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="objectName">string ObjectName</param>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static object CreateObject(string objectName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(objectName);
			object returnItem = Invoker.MethodReturn(_instance, "CreateObject", paramsArray);
			object newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">string Type</param>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static NetOffice.OutlookApi._NameSpace GetNamespace(string type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(_instance, "GetNamespace", paramsArray);
			NetOffice.OutlookApi._NameSpace newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.OutlookApi._NameSpace;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static void Quit()
		{
			object[] paramsArray = null;
			Invoker.Method(_instance, "Quit", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public static object ActiveWindow()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(_instance, "ActiveWindow", paramsArray);
			object newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14
		/// </summary>
		/// <param name="filePath">string FilePath</param>
		/// <param name="destFolderPath">string DestFolderPath</param>
		[SupportByVersionAttribute("Outlook", 10,11,12,14)]
		public static object CopyFile(string filePath, string destFolderPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filePath, destFolderPath);
			object returnItem = Invoker.MethodReturn(_instance, "CopyFile", paramsArray);
			object newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14
		/// </summary>
		/// <param name="scope">string Scope</param>
		/// <param name="filter">optional object Filter</param>
		/// <param name="searchSubFolders">optional object SearchSubFolders</param>
		/// <param name="tag">optional object Tag</param>
		[SupportByVersionAttribute("Outlook", 10,11,12,14)]
		public static NetOffice.OutlookApi.Search AdvancedSearch(string scope, object filter, object searchSubFolders, object tag)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(scope, filter, searchSubFolders, tag);
			object returnItem = Invoker.MethodReturn(_instance, "AdvancedSearch", paramsArray);
			NetOffice.OutlookApi.Search newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.OutlookApi.Search.LateBindingApiWrapperType) as NetOffice.OutlookApi.Search;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14
		/// </summary>
		/// <param name="scope">string Scope</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 10,11,12,14)]
		public static NetOffice.OutlookApi.Search AdvancedSearch(string scope)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(scope);
			object returnItem = Invoker.MethodReturn(_instance, "AdvancedSearch", paramsArray);
			NetOffice.OutlookApi.Search newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.OutlookApi.Search.LateBindingApiWrapperType) as NetOffice.OutlookApi.Search;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14
		/// </summary>
		/// <param name="scope">string Scope</param>
		/// <param name="filter">optional object Filter</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 10,11,12,14)]
		public static NetOffice.OutlookApi.Search AdvancedSearch(string scope, object filter)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(scope, filter);
			object returnItem = Invoker.MethodReturn(_instance, "AdvancedSearch", paramsArray);
			NetOffice.OutlookApi.Search newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.OutlookApi.Search.LateBindingApiWrapperType) as NetOffice.OutlookApi.Search;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14
		/// </summary>
		/// <param name="scope">string Scope</param>
		/// <param name="filter">optional object Filter</param>
		/// <param name="searchSubFolders">optional object SearchSubFolders</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 10,11,12,14)]
		public static NetOffice.OutlookApi.Search AdvancedSearch(string scope, object filter, object searchSubFolders)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(scope, filter, searchSubFolders);
			object returnItem = Invoker.MethodReturn(_instance, "AdvancedSearch", paramsArray);
			NetOffice.OutlookApi.Search newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.OutlookApi.Search.LateBindingApiWrapperType) as NetOffice.OutlookApi.Search;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14
		/// </summary>
		/// <param name="lookInFolders">string LookInFolders</param>
		[SupportByVersionAttribute("Outlook", 10,11,12,14)]
		public static bool IsSearchSynchronous(string lookInFolders)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(lookInFolders);
			object returnItem = Invoker.MethodReturn(_instance, "IsSearchSynchronous", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Outlook 10, 11, 12, 14
		/// </summary>
		/// <param name="pvar">object pvar</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Outlook", 10,11,12,14)]
		public static void GetNewNickNames(object pvar)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvar);
			Invoker.Method(_instance, "GetNewNickNames", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14
		/// </summary>
		/// <param name="item">object Item</param>
		/// <param name="referenceType">NetOffice.OutlookApi.Enums.OlReferenceType ReferenceType</param>
		[SupportByVersionAttribute("Outlook", 12,14)]
		public static object GetObjectReference(object item, NetOffice.OutlookApi.Enums.OlReferenceType referenceType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(item, referenceType);
			object returnItem = Invoker.MethodReturn(_instance, "GetObjectReference", paramsArray);
			object newObject = NetOffice.Factory.CreateObjectFromComProxy(_instance,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		/// <param name="regionName">string RegionName</param>
		[SupportByVersionAttribute("Outlook", 14)]
		public static void RefreshFormRegionDefinition(string regionName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(regionName);
			Invoker.Method(_instance, "RefreshFormRegionDefinition", paramsArray);
		}

		#endregion
	}
}