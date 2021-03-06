﻿//-----------------------------------------------------------------------
// <copyright file="Strings.cs" company="Jorge Alberto Hernández Quirino">
// Copyright (c) Jorge Alberto Hernández Quirino 2015-2016. All rights reserved.
// </copyright>
// <author>Jorge Alberto Hernández Quirino</author>
//-----------------------------------------------------------------------
namespace XportBand.Resources
{
	using Windows.ApplicationModel.Resources;
	
	/// <summary>
	/// Class for Localized Resource Strings.
	/// </summary>
	public static class Strings
	{
		
		/// <summary>
		/// Instance to load resources subtree of the currently running app's main ResourceMap.
		/// </summary>
		private static ResourceLoader moResourceLoader = new ResourceLoader();		
				
		/// <summary>
		/// Key for resource string <b>AppBarButtonActivityDetails.Label</b>.
		/// </summary>
		const string APP_BAR_BUTTON_ACTIVITY_DETAILS_LABEL = "details";
		/// <summary>
		/// Inner member for property <see cref="AppBarButtonActivityDetailsLabel"/>.
		/// </summary>
		static string msAppBarButtonActivityDetailsLabel;
		/// <summary>
		/// Gets string value for resource <b>AppBarButtonActivityDetails.Label</b> (<i>"details"</i>).
		/// </summary>
		public static string AppBarButtonActivityDetailsLabel
		{
			get
			{
				if (string.IsNullOrEmpty(msAppBarButtonActivityDetailsLabel))
				{
					msAppBarButtonActivityDetailsLabel = moResourceLoader.GetString("AppBarButtonActivityDetails.Label");
					if (string.IsNullOrEmpty(msAppBarButtonActivityDetailsLabel))
					{
						msAppBarButtonActivityDetailsLabel = APP_BAR_BUTTON_ACTIVITY_DETAILS_LABEL;
					}
				}
				return msAppBarButtonActivityDetailsLabel;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>AppBarButtonExportGpx.Label</b>.
		/// </summary>
		const string APP_BAR_BUTTON_EXPORT_GPX_LABEL = "export gpx";
		/// <summary>
		/// Inner member for property <see cref="AppBarButtonExportGpxLabel"/>.
		/// </summary>
		static string msAppBarButtonExportGpxLabel;
		/// <summary>
		/// Gets string value for resource <b>AppBarButtonExportGpx.Label</b> (<i>"export gpx"</i>).
		/// </summary>
		public static string AppBarButtonExportGpxLabel
		{
			get
			{
				if (string.IsNullOrEmpty(msAppBarButtonExportGpxLabel))
				{
					msAppBarButtonExportGpxLabel = moResourceLoader.GetString("AppBarButtonExportGpx.Label");
					if (string.IsNullOrEmpty(msAppBarButtonExportGpxLabel))
					{
						msAppBarButtonExportGpxLabel = APP_BAR_BUTTON_EXPORT_GPX_LABEL;
					}
				}
				return msAppBarButtonExportGpxLabel;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>AppBarButtonExportTcx.Label</b>.
		/// </summary>
		const string APP_BAR_BUTTON_EXPORT_TCX_LABEL = "export tcx";
		/// <summary>
		/// Inner member for property <see cref="AppBarButtonExportTcxLabel"/>.
		/// </summary>
		static string msAppBarButtonExportTcxLabel;
		/// <summary>
		/// Gets string value for resource <b>AppBarButtonExportTcx.Label</b> (<i>"export tcx"</i>).
		/// </summary>
		public static string AppBarButtonExportTcxLabel
		{
			get
			{
				if (string.IsNullOrEmpty(msAppBarButtonExportTcxLabel))
				{
					msAppBarButtonExportTcxLabel = moResourceLoader.GetString("AppBarButtonExportTcx.Label");
					if (string.IsNullOrEmpty(msAppBarButtonExportTcxLabel))
					{
						msAppBarButtonExportTcxLabel = APP_BAR_BUTTON_EXPORT_TCX_LABEL;
					}
				}
				return msAppBarButtonExportTcxLabel;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>AppBarButtonListActivities.Label</b>.
		/// </summary>
		const string APP_BAR_BUTTON_LIST_ACTIVITIES_LABEL = "activities";
		/// <summary>
		/// Inner member for property <see cref="AppBarButtonListActivitiesLabel"/>.
		/// </summary>
		static string msAppBarButtonListActivitiesLabel;
		/// <summary>
		/// Gets string value for resource <b>AppBarButtonListActivities.Label</b> (<i>"activities"</i>).
		/// </summary>
		public static string AppBarButtonListActivitiesLabel
		{
			get
			{
				if (string.IsNullOrEmpty(msAppBarButtonListActivitiesLabel))
				{
					msAppBarButtonListActivitiesLabel = moResourceLoader.GetString("AppBarButtonListActivities.Label");
					if (string.IsNullOrEmpty(msAppBarButtonListActivitiesLabel))
					{
						msAppBarButtonListActivitiesLabel = APP_BAR_BUTTON_LIST_ACTIVITIES_LABEL;
					}
				}
				return msAppBarButtonListActivitiesLabel;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>AppBarButtonSettings.Label</b>.
		/// </summary>
		const string APP_BAR_BUTTON_SETTINGS_LABEL = "settings";
		/// <summary>
		/// Inner member for property <see cref="AppBarButtonSettingsLabel"/>.
		/// </summary>
		static string msAppBarButtonSettingsLabel;
		/// <summary>
		/// Gets string value for resource <b>AppBarButtonSettings.Label</b> (<i>"settings"</i>).
		/// </summary>
		public static string AppBarButtonSettingsLabel
		{
			get
			{
				if (string.IsNullOrEmpty(msAppBarButtonSettingsLabel))
				{
					msAppBarButtonSettingsLabel = moResourceLoader.GetString("AppBarButtonSettings.Label");
					if (string.IsNullOrEmpty(msAppBarButtonSettingsLabel))
					{
						msAppBarButtonSettingsLabel = APP_BAR_BUTTON_SETTINGS_LABEL;
					}
				}
				return msAppBarButtonSettingsLabel;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ButtonFilterActivityType.Content</b>.
		/// </summary>
		const string BUTTON_FILTER_ACTIVITY_TYPE_CONTENT = "activity types";
		/// <summary>
		/// Inner member for property <see cref="ButtonFilterActivityTypeContent"/>.
		/// </summary>
		static string msButtonFilterActivityTypeContent;
		/// <summary>
		/// Gets string value for resource <b>ButtonFilterActivityType.Content</b> (<i>"activity types"</i>).
		/// </summary>
		public static string ButtonFilterActivityTypeContent
		{
			get
			{
				if (string.IsNullOrEmpty(msButtonFilterActivityTypeContent))
				{
					msButtonFilterActivityTypeContent = moResourceLoader.GetString("ButtonFilterActivityType.Content");
					if (string.IsNullOrEmpty(msButtonFilterActivityTypeContent))
					{
						msButtonFilterActivityTypeContent = BUTTON_FILTER_ACTIVITY_TYPE_CONTENT;
					}
				}
				return msButtonFilterActivityTypeContent;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ButtonSignIn.Content</b>.
		/// </summary>
		const string BUTTON_SIGN_IN_CONTENT = "sign-in";
		/// <summary>
		/// Inner member for property <see cref="ButtonSignInContent"/>.
		/// </summary>
		static string msButtonSignInContent;
		/// <summary>
		/// Gets string value for resource <b>ButtonSignIn.Content</b> (<i>"sign-in"</i>).
		/// </summary>
		public static string ButtonSignInContent
		{
			get
			{
				if (string.IsNullOrEmpty(msButtonSignInContent))
				{
					msButtonSignInContent = moResourceLoader.GetString("ButtonSignIn.Content");
					if (string.IsNullOrEmpty(msButtonSignInContent))
					{
						msButtonSignInContent = BUTTON_SIGN_IN_CONTENT;
					}
				}
				return msButtonSignInContent;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ButtonSignOut.Content</b>.
		/// </summary>
		const string BUTTON_SIGN_OUT_CONTENT = "sign-out";
		/// <summary>
		/// Inner member for property <see cref="ButtonSignOutContent"/>.
		/// </summary>
		static string msButtonSignOutContent;
		/// <summary>
		/// Gets string value for resource <b>ButtonSignOut.Content</b> (<i>"sign-out"</i>).
		/// </summary>
		public static string ButtonSignOutContent
		{
			get
			{
				if (string.IsNullOrEmpty(msButtonSignOutContent))
				{
					msButtonSignOutContent = moResourceLoader.GetString("ButtonSignOut.Content");
					if (string.IsNullOrEmpty(msButtonSignOutContent))
					{
						msButtonSignOutContent = BUTTON_SIGN_OUT_CONTENT;
					}
				}
				return msButtonSignOutContent;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ItemDistanceKilometers.Content</b>.
		/// </summary>
		const string ITEM_DISTANCE_KILOMETERS_CONTENT = "kilometers";
		/// <summary>
		/// Inner member for property <see cref="ItemDistanceKilometersContent"/>.
		/// </summary>
		static string msItemDistanceKilometersContent;
		/// <summary>
		/// Gets string value for resource <b>ItemDistanceKilometers.Content</b> (<i>"kilometers"</i>).
		/// </summary>
		public static string ItemDistanceKilometersContent
		{
			get
			{
				if (string.IsNullOrEmpty(msItemDistanceKilometersContent))
				{
					msItemDistanceKilometersContent = moResourceLoader.GetString("ItemDistanceKilometers.Content");
					if (string.IsNullOrEmpty(msItemDistanceKilometersContent))
					{
						msItemDistanceKilometersContent = ITEM_DISTANCE_KILOMETERS_CONTENT;
					}
				}
				return msItemDistanceKilometersContent;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ItemDistanceMiles.Content</b>.
		/// </summary>
		const string ITEM_DISTANCE_MILES_CONTENT = "miles";
		/// <summary>
		/// Inner member for property <see cref="ItemDistanceMilesContent"/>.
		/// </summary>
		static string msItemDistanceMilesContent;
		/// <summary>
		/// Gets string value for resource <b>ItemDistanceMiles.Content</b> (<i>"miles"</i>).
		/// </summary>
		public static string ItemDistanceMilesContent
		{
			get
			{
				if (string.IsNullOrEmpty(msItemDistanceMilesContent))
				{
					msItemDistanceMilesContent = moResourceLoader.GetString("ItemDistanceMiles.Content");
					if (string.IsNullOrEmpty(msItemDistanceMilesContent))
					{
						msItemDistanceMilesContent = ITEM_DISTANCE_MILES_CONTENT;
					}
				}
				return msItemDistanceMilesContent;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MapPositionEnd.Text</b>.
		/// </summary>
		const string MAP_POSITION_END_TEXT = "end";
		/// <summary>
		/// Inner member for property <see cref="MapPositionEndText"/>.
		/// </summary>
		static string msMapPositionEndText;
		/// <summary>
		/// Gets string value for resource <b>MapPositionEnd.Text</b> (<i>"end"</i>).
		/// </summary>
		public static string MapPositionEndText
		{
			get
			{
				if (string.IsNullOrEmpty(msMapPositionEndText))
				{
					msMapPositionEndText = moResourceLoader.GetString("MapPositionEnd.Text");
					if (string.IsNullOrEmpty(msMapPositionEndText))
					{
						msMapPositionEndText = MAP_POSITION_END_TEXT;
					}
				}
				return msMapPositionEndText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MapPositionStart.Text</b>.
		/// </summary>
		const string MAP_POSITION_START_TEXT = "start";
		/// <summary>
		/// Inner member for property <see cref="MapPositionStartText"/>.
		/// </summary>
		static string msMapPositionStartText;
		/// <summary>
		/// Gets string value for resource <b>MapPositionStart.Text</b> (<i>"start"</i>).
		/// </summary>
		public static string MapPositionStartText
		{
			get
			{
				if (string.IsNullOrEmpty(msMapPositionStartText))
				{
					msMapPositionStartText = moResourceLoader.GetString("MapPositionStart.Text");
					if (string.IsNullOrEmpty(msMapPositionStartText))
					{
						msMapPositionStartText = MAP_POSITION_START_TEXT;
					}
				}
				return msMapPositionStartText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivityDetailsHeader.Label</b>.
		/// </summary>
		const string TEXT_ACTIVITY_DETAILS_HEADER_LABEL = "details";
		/// <summary>
		/// Inner member for property <see cref="TextActivityDetailsHeaderLabel"/>.
		/// </summary>
		static string msTextActivityDetailsHeaderLabel;
		/// <summary>
		/// Gets string value for resource <b>TextActivityDetailsHeader.Label</b> (<i>"details"</i>).
		/// </summary>
		public static string TextActivityDetailsHeaderLabel
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivityDetailsHeaderLabel))
				{
					msTextActivityDetailsHeaderLabel = moResourceLoader.GetString("TextActivityDetailsHeader.Label");
					if (string.IsNullOrEmpty(msTextActivityDetailsHeaderLabel))
					{
						msTextActivityDetailsHeaderLabel = TEXT_ACTIVITY_DETAILS_HEADER_LABEL;
					}
				}
				return msTextActivityDetailsHeaderLabel;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivityDetailsTitle.Text</b>.
		/// </summary>
		const string TEXT_ACTIVITY_DETAILS_TITLE_TEXT = "activity";
		/// <summary>
		/// Inner member for property <see cref="TextActivityDetailsTitleText"/>.
		/// </summary>
		static string msTextActivityDetailsTitleText;
		/// <summary>
		/// Gets string value for resource <b>TextActivityDetailsTitle.Text</b> (<i>"activity"</i>).
		/// </summary>
		public static string TextActivityDetailsTitleText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivityDetailsTitleText))
				{
					msTextActivityDetailsTitleText = moResourceLoader.GetString("TextActivityDetailsTitle.Text");
					if (string.IsNullOrEmpty(msTextActivityDetailsTitleText))
					{
						msTextActivityDetailsTitleText = TEXT_ACTIVITY_DETAILS_TITLE_TEXT;
					}
				}
				return msTextActivityDetailsTitleText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivityDuration.Text</b>.
		/// </summary>
		const string TEXT_ACTIVITY_DURATION_TEXT = "duration:";
		/// <summary>
		/// Inner member for property <see cref="TextActivityDurationText"/>.
		/// </summary>
		static string msTextActivityDurationText;
		/// <summary>
		/// Gets string value for resource <b>TextActivityDuration.Text</b> (<i>"duration:"</i>).
		/// </summary>
		public static string TextActivityDurationText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivityDurationText))
				{
					msTextActivityDurationText = moResourceLoader.GetString("TextActivityDuration.Text");
					if (string.IsNullOrEmpty(msTextActivityDurationText))
					{
						msTextActivityDurationText = TEXT_ACTIVITY_DURATION_TEXT;
					}
				}
				return msTextActivityDurationText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivityElevation.Text</b>.
		/// </summary>
		const string TEXT_ACTIVITY_ELEVATION_TEXT = "elevation:";
		/// <summary>
		/// Inner member for property <see cref="TextActivityElevationText"/>.
		/// </summary>
		static string msTextActivityElevationText;
		/// <summary>
		/// Gets string value for resource <b>TextActivityElevation.Text</b> (<i>"elevation:"</i>).
		/// </summary>
		public static string TextActivityElevationText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivityElevationText))
				{
					msTextActivityElevationText = moResourceLoader.GetString("TextActivityElevation.Text");
					if (string.IsNullOrEmpty(msTextActivityElevationText))
					{
						msTextActivityElevationText = TEXT_ACTIVITY_ELEVATION_TEXT;
					}
				}
				return msTextActivityElevationText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivityElevationGain.Text</b>.
		/// </summary>
		const string TEXT_ACTIVITY_ELEVATION_GAIN_TEXT = "elevation gain:";
		/// <summary>
		/// Inner member for property <see cref="TextActivityElevationGainText"/>.
		/// </summary>
		static string msTextActivityElevationGainText;
		/// <summary>
		/// Gets string value for resource <b>TextActivityElevationGain.Text</b> (<i>"elevation gain:"</i>).
		/// </summary>
		public static string TextActivityElevationGainText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivityElevationGainText))
				{
					msTextActivityElevationGainText = moResourceLoader.GetString("TextActivityElevationGain.Text");
					if (string.IsNullOrEmpty(msTextActivityElevationGainText))
					{
						msTextActivityElevationGainText = TEXT_ACTIVITY_ELEVATION_GAIN_TEXT;
					}
				}
				return msTextActivityElevationGainText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivityElevationLoss.Text</b>.
		/// </summary>
		const string TEXT_ACTIVITY_ELEVATION_LOSS_TEXT = "elevation loss:";
		/// <summary>
		/// Inner member for property <see cref="TextActivityElevationLossText"/>.
		/// </summary>
		static string msTextActivityElevationLossText;
		/// <summary>
		/// Gets string value for resource <b>TextActivityElevationLoss.Text</b> (<i>"elevation loss:"</i>).
		/// </summary>
		public static string TextActivityElevationLossText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivityElevationLossText))
				{
					msTextActivityElevationLossText = moResourceLoader.GetString("TextActivityElevationLoss.Text");
					if (string.IsNullOrEmpty(msTextActivityElevationLossText))
					{
						msTextActivityElevationLossText = TEXT_ACTIVITY_ELEVATION_LOSS_TEXT;
					}
				}
				return msTextActivityElevationLossText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivityHeartRateHeader.Label</b>.
		/// </summary>
		const string TEXT_ACTIVITY_HEART_RATE_HEADER_LABEL = "heart rate";
		/// <summary>
		/// Inner member for property <see cref="TextActivityHeartRateHeaderLabel"/>.
		/// </summary>
		static string msTextActivityHeartRateHeaderLabel;
		/// <summary>
		/// Gets string value for resource <b>TextActivityHeartRateHeader.Label</b> (<i>"heart rate"</i>).
		/// </summary>
		public static string TextActivityHeartRateHeaderLabel
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivityHeartRateHeaderLabel))
				{
					msTextActivityHeartRateHeaderLabel = moResourceLoader.GetString("TextActivityHeartRateHeader.Label");
					if (string.IsNullOrEmpty(msTextActivityHeartRateHeaderLabel))
					{
						msTextActivityHeartRateHeaderLabel = TEXT_ACTIVITY_HEART_RATE_HEADER_LABEL;
					}
				}
				return msTextActivityHeartRateHeaderLabel;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivityMapHeader.Label</b>.
		/// </summary>
		const string TEXT_ACTIVITY_MAP_HEADER_LABEL = "map";
		/// <summary>
		/// Inner member for property <see cref="TextActivityMapHeaderLabel"/>.
		/// </summary>
		static string msTextActivityMapHeaderLabel;
		/// <summary>
		/// Gets string value for resource <b>TextActivityMapHeader.Label</b> (<i>"map"</i>).
		/// </summary>
		public static string TextActivityMapHeaderLabel
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivityMapHeaderLabel))
				{
					msTextActivityMapHeaderLabel = moResourceLoader.GetString("TextActivityMapHeader.Label");
					if (string.IsNullOrEmpty(msTextActivityMapHeaderLabel))
					{
						msTextActivityMapHeaderLabel = TEXT_ACTIVITY_MAP_HEADER_LABEL;
					}
				}
				return msTextActivityMapHeaderLabel;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivityMaxElevation.Text</b>.
		/// </summary>
		const string TEXT_ACTIVITY_MAX_ELEVATION_TEXT = "max elevation:";
		/// <summary>
		/// Inner member for property <see cref="TextActivityMaxElevationText"/>.
		/// </summary>
		static string msTextActivityMaxElevationText;
		/// <summary>
		/// Gets string value for resource <b>TextActivityMaxElevation.Text</b> (<i>"max elevation:"</i>).
		/// </summary>
		public static string TextActivityMaxElevationText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivityMaxElevationText))
				{
					msTextActivityMaxElevationText = moResourceLoader.GetString("TextActivityMaxElevation.Text");
					if (string.IsNullOrEmpty(msTextActivityMaxElevationText))
					{
						msTextActivityMaxElevationText = TEXT_ACTIVITY_MAX_ELEVATION_TEXT;
					}
				}
				return msTextActivityMaxElevationText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivityMinElevation.Text</b>.
		/// </summary>
		const string TEXT_ACTIVITY_MIN_ELEVATION_TEXT = "min elevation:";
		/// <summary>
		/// Inner member for property <see cref="TextActivityMinElevationText"/>.
		/// </summary>
		static string msTextActivityMinElevationText;
		/// <summary>
		/// Gets string value for resource <b>TextActivityMinElevation.Text</b> (<i>"min elevation:"</i>).
		/// </summary>
		public static string TextActivityMinElevationText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivityMinElevationText))
				{
					msTextActivityMinElevationText = moResourceLoader.GetString("TextActivityMinElevation.Text");
					if (string.IsNullOrEmpty(msTextActivityMinElevationText))
					{
						msTextActivityMinElevationText = TEXT_ACTIVITY_MIN_ELEVATION_TEXT;
					}
				}
				return msTextActivityMinElevationText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivityOverallPace.Text</b>.
		/// </summary>
		const string TEXT_ACTIVITY_OVERALL_PACE_TEXT = "overall pace:";
		/// <summary>
		/// Inner member for property <see cref="TextActivityOverallPaceText"/>.
		/// </summary>
		static string msTextActivityOverallPaceText;
		/// <summary>
		/// Gets string value for resource <b>TextActivityOverallPace.Text</b> (<i>"overall pace:"</i>).
		/// </summary>
		public static string TextActivityOverallPaceText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivityOverallPaceText))
				{
					msTextActivityOverallPaceText = moResourceLoader.GetString("TextActivityOverallPace.Text");
					if (string.IsNullOrEmpty(msTextActivityOverallPaceText))
					{
						msTextActivityOverallPaceText = TEXT_ACTIVITY_OVERALL_PACE_TEXT;
					}
				}
				return msTextActivityOverallPaceText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivityPace.Text</b>.
		/// </summary>
		const string TEXT_ACTIVITY_PACE_TEXT = "pace:";
		/// <summary>
		/// Inner member for property <see cref="TextActivityPaceText"/>.
		/// </summary>
		static string msTextActivityPaceText;
		/// <summary>
		/// Gets string value for resource <b>TextActivityPace.Text</b> (<i>"pace:"</i>).
		/// </summary>
		public static string TextActivityPaceText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivityPaceText))
				{
					msTextActivityPaceText = moResourceLoader.GetString("TextActivityPace.Text");
					if (string.IsNullOrEmpty(msTextActivityPaceText))
					{
						msTextActivityPaceText = TEXT_ACTIVITY_PACE_TEXT;
					}
				}
				return msTextActivityPaceText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivitySpeed.Text</b>.
		/// </summary>
		const string TEXT_ACTIVITY_SPEED_TEXT = "speed:";
		/// <summary>
		/// Inner member for property <see cref="TextActivitySpeedText"/>.
		/// </summary>
		static string msTextActivitySpeedText;
		/// <summary>
		/// Gets string value for resource <b>TextActivitySpeed.Text</b> (<i>"speed:"</i>).
		/// </summary>
		public static string TextActivitySpeedText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivitySpeedText))
				{
					msTextActivitySpeedText = moResourceLoader.GetString("TextActivitySpeed.Text");
					if (string.IsNullOrEmpty(msTextActivitySpeedText))
					{
						msTextActivitySpeedText = TEXT_ACTIVITY_SPEED_TEXT;
					}
				}
				return msTextActivitySpeedText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivitySplitsHeader.Label</b>.
		/// </summary>
		const string TEXT_ACTIVITY_SPLITS_HEADER_LABEL = "splits";
		/// <summary>
		/// Inner member for property <see cref="TextActivitySplitsHeaderLabel"/>.
		/// </summary>
		static string msTextActivitySplitsHeaderLabel;
		/// <summary>
		/// Gets string value for resource <b>TextActivitySplitsHeader.Label</b> (<i>"splits"</i>).
		/// </summary>
		public static string TextActivitySplitsHeaderLabel
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivitySplitsHeaderLabel))
				{
					msTextActivitySplitsHeaderLabel = moResourceLoader.GetString("TextActivitySplitsHeader.Label");
					if (string.IsNullOrEmpty(msTextActivitySplitsHeaderLabel))
					{
						msTextActivitySplitsHeaderLabel = TEXT_ACTIVITY_SPLITS_HEADER_LABEL;
					}
				}
				return msTextActivitySplitsHeaderLabel;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivityStartTime.Text</b>.
		/// </summary>
		const string TEXT_ACTIVITY_START_TIME_TEXT = "start time:";
		/// <summary>
		/// Inner member for property <see cref="TextActivityStartTimeText"/>.
		/// </summary>
		static string msTextActivityStartTimeText;
		/// <summary>
		/// Gets string value for resource <b>TextActivityStartTime.Text</b> (<i>"start time:"</i>).
		/// </summary>
		public static string TextActivityStartTimeText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivityStartTimeText))
				{
					msTextActivityStartTimeText = moResourceLoader.GetString("TextActivityStartTime.Text");
					if (string.IsNullOrEmpty(msTextActivityStartTimeText))
					{
						msTextActivityStartTimeText = TEXT_ACTIVITY_START_TIME_TEXT;
					}
				}
				return msTextActivityStartTimeText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivityTotalCalories.Text</b>.
		/// </summary>
		const string TEXT_ACTIVITY_TOTAL_CALORIES_TEXT = "calories:";
		/// <summary>
		/// Inner member for property <see cref="TextActivityTotalCaloriesText"/>.
		/// </summary>
		static string msTextActivityTotalCaloriesText;
		/// <summary>
		/// Gets string value for resource <b>TextActivityTotalCalories.Text</b> (<i>"calories:"</i>).
		/// </summary>
		public static string TextActivityTotalCaloriesText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivityTotalCaloriesText))
				{
					msTextActivityTotalCaloriesText = moResourceLoader.GetString("TextActivityTotalCalories.Text");
					if (string.IsNullOrEmpty(msTextActivityTotalCaloriesText))
					{
						msTextActivityTotalCaloriesText = TEXT_ACTIVITY_TOTAL_CALORIES_TEXT;
					}
				}
				return msTextActivityTotalCaloriesText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivityTotalDistance.Text</b>.
		/// </summary>
		const string TEXT_ACTIVITY_TOTAL_DISTANCE_TEXT = "distance:";
		/// <summary>
		/// Inner member for property <see cref="TextActivityTotalDistanceText"/>.
		/// </summary>
		static string msTextActivityTotalDistanceText;
		/// <summary>
		/// Gets string value for resource <b>TextActivityTotalDistance.Text</b> (<i>"distance:"</i>).
		/// </summary>
		public static string TextActivityTotalDistanceText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivityTotalDistanceText))
				{
					msTextActivityTotalDistanceText = moResourceLoader.GetString("TextActivityTotalDistance.Text");
					if (string.IsNullOrEmpty(msTextActivityTotalDistanceText))
					{
						msTextActivityTotalDistanceText = TEXT_ACTIVITY_TOTAL_DISTANCE_TEXT;
					}
				}
				return msTextActivityTotalDistanceText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextActivityType.Text</b>.
		/// </summary>
		const string TEXT_ACTIVITY_TYPE_TEXT = "type:";
		/// <summary>
		/// Inner member for property <see cref="TextActivityTypeText"/>.
		/// </summary>
		static string msTextActivityTypeText;
		/// <summary>
		/// Gets string value for resource <b>TextActivityType.Text</b> (<i>"type:"</i>).
		/// </summary>
		public static string TextActivityTypeText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextActivityTypeText))
				{
					msTextActivityTypeText = moResourceLoader.GetString("TextActivityType.Text");
					if (string.IsNullOrEmpty(msTextActivityTypeText))
					{
						msTextActivityTypeText = TEXT_ACTIVITY_TYPE_TEXT;
					}
				}
				return msTextActivityTypeText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextAppTitle.Text</b>.
		/// </summary>
		const string TEXT_APP_TITLE_TEXT = "XportBand";
		/// <summary>
		/// Inner member for property <see cref="TextAppTitleText"/>.
		/// </summary>
		static string msTextAppTitleText;
		/// <summary>
		/// Gets string value for resource <b>TextAppTitle.Text</b> (<i>"XportBand"</i>).
		/// </summary>
		public static string TextAppTitleText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextAppTitleText))
				{
					msTextAppTitleText = moResourceLoader.GetString("TextAppTitle.Text");
					if (string.IsNullOrEmpty(msTextAppTitleText))
					{
						msTextAppTitleText = TEXT_APP_TITLE_TEXT;
					}
				}
				return msTextAppTitleText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextAvgSymbol.Text</b>.
		/// </summary>
		const string TEXT_AVG_SYMBOL_TEXT = "⁓";
		/// <summary>
		/// Inner member for property <see cref="TextAvgSymbolText"/>.
		/// </summary>
		static string msTextAvgSymbolText;
		/// <summary>
		/// Gets string value for resource <b>TextAvgSymbol.Text</b> (<i>"⁓"</i>).
		/// </summary>
		public static string TextAvgSymbolText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextAvgSymbolText))
				{
					msTextAvgSymbolText = moResourceLoader.GetString("TextAvgSymbol.Text");
					if (string.IsNullOrEmpty(msTextAvgSymbolText))
					{
						msTextAvgSymbolText = TEXT_AVG_SYMBOL_TEXT;
					}
				}
				return msTextAvgSymbolText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextDistanceUnit.Text</b>.
		/// </summary>
		const string TEXT_DISTANCE_UNIT_TEXT = "distance unit:";
		/// <summary>
		/// Inner member for property <see cref="TextDistanceUnitText"/>.
		/// </summary>
		static string msTextDistanceUnitText;
		/// <summary>
		/// Gets string value for resource <b>TextDistanceUnit.Text</b> (<i>"distance unit:"</i>).
		/// </summary>
		public static string TextDistanceUnitText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextDistanceUnitText))
				{
					msTextDistanceUnitText = moResourceLoader.GetString("TextDistanceUnit.Text");
					if (string.IsNullOrEmpty(msTextDistanceUnitText))
					{
						msTextDistanceUnitText = TEXT_DISTANCE_UNIT_TEXT;
					}
				}
				return msTextDistanceUnitText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextFacebook.Text</b>.
		/// </summary>
		const string TEXT_FACEBOOK_TEXT = "Facebook";
		/// <summary>
		/// Inner member for property <see cref="TextFacebookText"/>.
		/// </summary>
		static string msTextFacebookText;
		/// <summary>
		/// Gets string value for resource <b>TextFacebook.Text</b> (<i>"Facebook"</i>).
		/// </summary>
		public static string TextFacebookText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextFacebookText))
				{
					msTextFacebookText = moResourceLoader.GetString("TextFacebook.Text");
					if (string.IsNullOrEmpty(msTextFacebookText))
					{
						msTextFacebookText = TEXT_FACEBOOK_TEXT;
					}
				}
				return msTextFacebookText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextFilterActivityDistance.Text</b>.
		/// </summary>
		const string TEXT_FILTER_ACTIVITY_DISTANCE_TEXT = "distance";
		/// <summary>
		/// Inner member for property <see cref="TextFilterActivityDistanceText"/>.
		/// </summary>
		static string msTextFilterActivityDistanceText;
		/// <summary>
		/// Gets string value for resource <b>TextFilterActivityDistance.Text</b> (<i>"distance"</i>).
		/// </summary>
		public static string TextFilterActivityDistanceText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextFilterActivityDistanceText))
				{
					msTextFilterActivityDistanceText = moResourceLoader.GetString("TextFilterActivityDistance.Text");
					if (string.IsNullOrEmpty(msTextFilterActivityDistanceText))
					{
						msTextFilterActivityDistanceText = TEXT_FILTER_ACTIVITY_DISTANCE_TEXT;
					}
				}
				return msTextFilterActivityDistanceText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextFilterActivityPeriod.Text</b>.
		/// </summary>
		const string TEXT_FILTER_ACTIVITY_PERIOD_TEXT = "period";
		/// <summary>
		/// Inner member for property <see cref="TextFilterActivityPeriodText"/>.
		/// </summary>
		static string msTextFilterActivityPeriodText;
		/// <summary>
		/// Gets string value for resource <b>TextFilterActivityPeriod.Text</b> (<i>"period"</i>).
		/// </summary>
		public static string TextFilterActivityPeriodText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextFilterActivityPeriodText))
				{
					msTextFilterActivityPeriodText = moResourceLoader.GetString("TextFilterActivityPeriod.Text");
					if (string.IsNullOrEmpty(msTextFilterActivityPeriodText))
					{
						msTextFilterActivityPeriodText = TEXT_FILTER_ACTIVITY_PERIOD_TEXT;
					}
				}
				return msTextFilterActivityPeriodText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextFilterActivityType.Text</b>.
		/// </summary>
		const string TEXT_FILTER_ACTIVITY_TYPE_TEXT = "activity types";
		/// <summary>
		/// Inner member for property <see cref="TextFilterActivityTypeText"/>.
		/// </summary>
		static string msTextFilterActivityTypeText;
		/// <summary>
		/// Gets string value for resource <b>TextFilterActivityType.Text</b> (<i>"activity types"</i>).
		/// </summary>
		public static string TextFilterActivityTypeText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextFilterActivityTypeText))
				{
					msTextFilterActivityTypeText = moResourceLoader.GetString("TextFilterActivityType.Text");
					if (string.IsNullOrEmpty(msTextFilterActivityTypeText))
					{
						msTextFilterActivityTypeText = TEXT_FILTER_ACTIVITY_TYPE_TEXT;
					}
				}
				return msTextFilterActivityTypeText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextHeartRate.Text</b>.
		/// </summary>
		const string TEXT_HEART_RATE_TEXT = "heart rate";
		/// <summary>
		/// Inner member for property <see cref="TextHeartRateText"/>.
		/// </summary>
		static string msTextHeartRateText;
		/// <summary>
		/// Gets string value for resource <b>TextHeartRate.Text</b> (<i>"heart rate"</i>).
		/// </summary>
		public static string TextHeartRateText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextHeartRateText))
				{
					msTextHeartRateText = moResourceLoader.GetString("TextHeartRate.Text");
					if (string.IsNullOrEmpty(msTextHeartRateText))
					{
						msTextHeartRateText = TEXT_HEART_RATE_TEXT;
					}
				}
				return msTextHeartRateText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextHeartRateAvg.Text</b>.
		/// </summary>
		const string TEXT_HEART_RATE_AVG_TEXT = "average:";
		/// <summary>
		/// Inner member for property <see cref="TextHeartRateAvgText"/>.
		/// </summary>
		static string msTextHeartRateAvgText;
		/// <summary>
		/// Gets string value for resource <b>TextHeartRateAvg.Text</b> (<i>"average:"</i>).
		/// </summary>
		public static string TextHeartRateAvgText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextHeartRateAvgText))
				{
					msTextHeartRateAvgText = moResourceLoader.GetString("TextHeartRateAvg.Text");
					if (string.IsNullOrEmpty(msTextHeartRateAvgText))
					{
						msTextHeartRateAvgText = TEXT_HEART_RATE_AVG_TEXT;
					}
				}
				return msTextHeartRateAvgText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextHeartRateMax.Text</b>.
		/// </summary>
		const string TEXT_HEART_RATE_MAX_TEXT = "maximum:";
		/// <summary>
		/// Inner member for property <see cref="TextHeartRateMaxText"/>.
		/// </summary>
		static string msTextHeartRateMaxText;
		/// <summary>
		/// Gets string value for resource <b>TextHeartRateMax.Text</b> (<i>"maximum:"</i>).
		/// </summary>
		public static string TextHeartRateMaxText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextHeartRateMaxText))
				{
					msTextHeartRateMaxText = moResourceLoader.GetString("TextHeartRateMax.Text");
					if (string.IsNullOrEmpty(msTextHeartRateMaxText))
					{
						msTextHeartRateMaxText = TEXT_HEART_RATE_MAX_TEXT;
					}
				}
				return msTextHeartRateMaxText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextHeartRateMin.Text</b>.
		/// </summary>
		const string TEXT_HEART_RATE_MIN_TEXT = "minimum: ";
		/// <summary>
		/// Inner member for property <see cref="TextHeartRateMinText"/>.
		/// </summary>
		static string msTextHeartRateMinText;
		/// <summary>
		/// Gets string value for resource <b>TextHeartRateMin.Text</b> (<i>"minimum: "</i>).
		/// </summary>
		public static string TextHeartRateMinText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextHeartRateMinText))
				{
					msTextHeartRateMinText = moResourceLoader.GetString("TextHeartRateMin.Text");
					if (string.IsNullOrEmpty(msTextHeartRateMinText))
					{
						msTextHeartRateMinText = TEXT_HEART_RATE_MIN_TEXT;
					}
				}
				return msTextHeartRateMinText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextHeartRateMinutes.Text</b>.
		/// </summary>
		const string TEXT_HEART_RATE_MINUTES_TEXT = "minutes";
		/// <summary>
		/// Inner member for property <see cref="TextHeartRateMinutesText"/>.
		/// </summary>
		static string msTextHeartRateMinutesText;
		/// <summary>
		/// Gets string value for resource <b>TextHeartRateMinutes.Text</b> (<i>"minutes"</i>).
		/// </summary>
		public static string TextHeartRateMinutesText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextHeartRateMinutesText))
				{
					msTextHeartRateMinutesText = moResourceLoader.GetString("TextHeartRateMinutes.Text");
					if (string.IsNullOrEmpty(msTextHeartRateMinutesText))
					{
						msTextHeartRateMinutesText = TEXT_HEART_RATE_MINUTES_TEXT;
					}
				}
				return msTextHeartRateMinutesText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextHeartRateZone.Text</b>.
		/// </summary>
		const string TEXT_HEART_RATE_ZONE_TEXT = "zone";
		/// <summary>
		/// Inner member for property <see cref="TextHeartRateZoneText"/>.
		/// </summary>
		static string msTextHeartRateZoneText;
		/// <summary>
		/// Gets string value for resource <b>TextHeartRateZone.Text</b> (<i>"zone"</i>).
		/// </summary>
		public static string TextHeartRateZoneText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextHeartRateZoneText))
				{
					msTextHeartRateZoneText = moResourceLoader.GetString("TextHeartRateZone.Text");
					if (string.IsNullOrEmpty(msTextHeartRateZoneText))
					{
						msTextHeartRateZoneText = TEXT_HEART_RATE_ZONE_TEXT;
					}
				}
				return msTextHeartRateZoneText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextHeartRateZoneAerobic.Text</b>.
		/// </summary>
		const string TEXT_HEART_RATE_ZONE_AEROBIC_TEXT = "aerobic [70%-80%]";
		/// <summary>
		/// Inner member for property <see cref="TextHeartRateZoneAerobicText"/>.
		/// </summary>
		static string msTextHeartRateZoneAerobicText;
		/// <summary>
		/// Gets string value for resource <b>TextHeartRateZoneAerobic.Text</b> (<i>"aerobic [70%-80%]"</i>).
		/// </summary>
		public static string TextHeartRateZoneAerobicText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextHeartRateZoneAerobicText))
				{
					msTextHeartRateZoneAerobicText = moResourceLoader.GetString("TextHeartRateZoneAerobic.Text");
					if (string.IsNullOrEmpty(msTextHeartRateZoneAerobicText))
					{
						msTextHeartRateZoneAerobicText = TEXT_HEART_RATE_ZONE_AEROBIC_TEXT;
					}
				}
				return msTextHeartRateZoneAerobicText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextHeartRateZoneAnaerobic.Text</b>.
		/// </summary>
		const string TEXT_HEART_RATE_ZONE_ANAEROBIC_TEXT = "anaerobic [80%-90%]";
		/// <summary>
		/// Inner member for property <see cref="TextHeartRateZoneAnaerobicText"/>.
		/// </summary>
		static string msTextHeartRateZoneAnaerobicText;
		/// <summary>
		/// Gets string value for resource <b>TextHeartRateZoneAnaerobic.Text</b> (<i>"anaerobic [80%-90%]"</i>).
		/// </summary>
		public static string TextHeartRateZoneAnaerobicText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextHeartRateZoneAnaerobicText))
				{
					msTextHeartRateZoneAnaerobicText = moResourceLoader.GetString("TextHeartRateZoneAnaerobic.Text");
					if (string.IsNullOrEmpty(msTextHeartRateZoneAnaerobicText))
					{
						msTextHeartRateZoneAnaerobicText = TEXT_HEART_RATE_ZONE_ANAEROBIC_TEXT;
					}
				}
				return msTextHeartRateZoneAnaerobicText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextHeartRateZoneFitness.Text</b>.
		/// </summary>
		const string TEXT_HEART_RATE_ZONE_FITNESS_TEXT = "fitness [60%-70%]";
		/// <summary>
		/// Inner member for property <see cref="TextHeartRateZoneFitnessText"/>.
		/// </summary>
		static string msTextHeartRateZoneFitnessText;
		/// <summary>
		/// Gets string value for resource <b>TextHeartRateZoneFitness.Text</b> (<i>"fitness [60%-70%]"</i>).
		/// </summary>
		public static string TextHeartRateZoneFitnessText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextHeartRateZoneFitnessText))
				{
					msTextHeartRateZoneFitnessText = moResourceLoader.GetString("TextHeartRateZoneFitness.Text");
					if (string.IsNullOrEmpty(msTextHeartRateZoneFitnessText))
					{
						msTextHeartRateZoneFitnessText = TEXT_HEART_RATE_ZONE_FITNESS_TEXT;
					}
				}
				return msTextHeartRateZoneFitnessText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextHeartRateZoneHealthy.Text</b>.
		/// </summary>
		const string TEXT_HEART_RATE_ZONE_HEALTHY_TEXT = "healthy [50%-60%]";
		/// <summary>
		/// Inner member for property <see cref="TextHeartRateZoneHealthyText"/>.
		/// </summary>
		static string msTextHeartRateZoneHealthyText;
		/// <summary>
		/// Gets string value for resource <b>TextHeartRateZoneHealthy.Text</b> (<i>"healthy [50%-60%]"</i>).
		/// </summary>
		public static string TextHeartRateZoneHealthyText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextHeartRateZoneHealthyText))
				{
					msTextHeartRateZoneHealthyText = moResourceLoader.GetString("TextHeartRateZoneHealthy.Text");
					if (string.IsNullOrEmpty(msTextHeartRateZoneHealthyText))
					{
						msTextHeartRateZoneHealthyText = TEXT_HEART_RATE_ZONE_HEALTHY_TEXT;
					}
				}
				return msTextHeartRateZoneHealthyText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextHeartRateZoneOverRedline.Text</b>.
		/// </summary>
		const string TEXT_HEART_RATE_ZONE_OVER_REDLINE_TEXT = "over redline [>100%]";
		/// <summary>
		/// Inner member for property <see cref="TextHeartRateZoneOverRedlineText"/>.
		/// </summary>
		static string msTextHeartRateZoneOverRedlineText;
		/// <summary>
		/// Gets string value for resource <b>TextHeartRateZoneOverRedline.Text</b> (<i>"over redline [>100%]"</i>).
		/// </summary>
		public static string TextHeartRateZoneOverRedlineText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextHeartRateZoneOverRedlineText))
				{
					msTextHeartRateZoneOverRedlineText = moResourceLoader.GetString("TextHeartRateZoneOverRedline.Text");
					if (string.IsNullOrEmpty(msTextHeartRateZoneOverRedlineText))
					{
						msTextHeartRateZoneOverRedlineText = TEXT_HEART_RATE_ZONE_OVER_REDLINE_TEXT;
					}
				}
				return msTextHeartRateZoneOverRedlineText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextHeartRateZoneRedline.Text</b>.
		/// </summary>
		const string TEXT_HEART_RATE_ZONE_REDLINE_TEXT = "redline [90%-100%]";
		/// <summary>
		/// Inner member for property <see cref="TextHeartRateZoneRedlineText"/>.
		/// </summary>
		static string msTextHeartRateZoneRedlineText;
		/// <summary>
		/// Gets string value for resource <b>TextHeartRateZoneRedline.Text</b> (<i>"redline [90%-100%]"</i>).
		/// </summary>
		public static string TextHeartRateZoneRedlineText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextHeartRateZoneRedlineText))
				{
					msTextHeartRateZoneRedlineText = moResourceLoader.GetString("TextHeartRateZoneRedline.Text");
					if (string.IsNullOrEmpty(msTextHeartRateZoneRedlineText))
					{
						msTextHeartRateZoneRedlineText = TEXT_HEART_RATE_ZONE_REDLINE_TEXT;
					}
				}
				return msTextHeartRateZoneRedlineText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextHeartRateZones.Text</b>.
		/// </summary>
		const string TEXT_HEART_RATE_ZONES_TEXT = "zones";
		/// <summary>
		/// Inner member for property <see cref="TextHeartRateZonesText"/>.
		/// </summary>
		static string msTextHeartRateZonesText;
		/// <summary>
		/// Gets string value for resource <b>TextHeartRateZones.Text</b> (<i>"zones"</i>).
		/// </summary>
		public static string TextHeartRateZonesText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextHeartRateZonesText))
				{
					msTextHeartRateZonesText = moResourceLoader.GetString("TextHeartRateZones.Text");
					if (string.IsNullOrEmpty(msTextHeartRateZonesText))
					{
						msTextHeartRateZonesText = TEXT_HEART_RATE_ZONES_TEXT;
					}
				}
				return msTextHeartRateZonesText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextHeartRateZoneUnderHealthy.Text</b>.
		/// </summary>
		const string TEXT_HEART_RATE_ZONE_UNDER_HEALTHY_TEXT = "underhealthy [<50%]";
		/// <summary>
		/// Inner member for property <see cref="TextHeartRateZoneUnderHealthyText"/>.
		/// </summary>
		static string msTextHeartRateZoneUnderHealthyText;
		/// <summary>
		/// Gets string value for resource <b>TextHeartRateZoneUnderHealthy.Text</b> (<i>"underhealthy [<50%]"</i>).
		/// </summary>
		public static string TextHeartRateZoneUnderHealthyText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextHeartRateZoneUnderHealthyText))
				{
					msTextHeartRateZoneUnderHealthyText = moResourceLoader.GetString("TextHeartRateZoneUnderHealthy.Text");
					if (string.IsNullOrEmpty(msTextHeartRateZoneUnderHealthyText))
					{
						msTextHeartRateZoneUnderHealthyText = TEXT_HEART_RATE_ZONE_UNDER_HEALTHY_TEXT;
					}
				}
				return msTextHeartRateZoneUnderHealthyText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextMaxSymbol.Text</b>.
		/// </summary>
		const string TEXT_MAX_SYMBOL_TEXT = "↑";
		/// <summary>
		/// Inner member for property <see cref="TextMaxSymbolText"/>.
		/// </summary>
		static string msTextMaxSymbolText;
		/// <summary>
		/// Gets string value for resource <b>TextMaxSymbol.Text</b> (<i>"↑"</i>).
		/// </summary>
		public static string TextMaxSymbolText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextMaxSymbolText))
				{
					msTextMaxSymbolText = moResourceLoader.GetString("TextMaxSymbol.Text");
					if (string.IsNullOrEmpty(msTextMaxSymbolText))
					{
						msTextMaxSymbolText = TEXT_MAX_SYMBOL_TEXT;
					}
				}
				return msTextMaxSymbolText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextMicrosoftHealth.Text</b>.
		/// </summary>
		const string TEXT_MICROSOFT_HEALTH_TEXT = "Microsoft Health";
		/// <summary>
		/// Inner member for property <see cref="TextMicrosoftHealthText"/>.
		/// </summary>
		static string msTextMicrosoftHealthText;
		/// <summary>
		/// Gets string value for resource <b>TextMicrosoftHealth.Text</b> (<i>"Microsoft Health"</i>).
		/// </summary>
		public static string TextMicrosoftHealthText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextMicrosoftHealthText))
				{
					msTextMicrosoftHealthText = moResourceLoader.GetString("TextMicrosoftHealth.Text");
					if (string.IsNullOrEmpty(msTextMicrosoftHealthText))
					{
						msTextMicrosoftHealthText = TEXT_MICROSOFT_HEALTH_TEXT;
					}
				}
				return msTextMicrosoftHealthText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextMinSymbol.Text</b>.
		/// </summary>
		const string TEXT_MIN_SYMBOL_TEXT = "↓";
		/// <summary>
		/// Inner member for property <see cref="TextMinSymbolText"/>.
		/// </summary>
		static string msTextMinSymbolText;
		/// <summary>
		/// Gets string value for resource <b>TextMinSymbol.Text</b> (<i>"↓"</i>).
		/// </summary>
		public static string TextMinSymbolText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextMinSymbolText))
				{
					msTextMinSymbolText = moResourceLoader.GetString("TextMinSymbol.Text");
					if (string.IsNullOrEmpty(msTextMinSymbolText))
					{
						msTextMinSymbolText = TEXT_MIN_SYMBOL_TEXT;
					}
				}
				return msTextMinSymbolText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextNoMapDisclaimer.Text</b>.
		/// </summary>
		const string TEXT_NO_MAP_DISCLAIMER_TEXT = "Map data not found for current activity.";
		/// <summary>
		/// Inner member for property <see cref="TextNoMapDisclaimerText"/>.
		/// </summary>
		static string msTextNoMapDisclaimerText;
		/// <summary>
		/// Gets string value for resource <b>TextNoMapDisclaimer.Text</b> (<i>"Map data not found for current activity."</i>).
		/// </summary>
		public static string TextNoMapDisclaimerText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextNoMapDisclaimerText))
				{
					msTextNoMapDisclaimerText = moResourceLoader.GetString("TextNoMapDisclaimer.Text");
					if (string.IsNullOrEmpty(msTextNoMapDisclaimerText))
					{
						msTextNoMapDisclaimerText = TEXT_NO_MAP_DISCLAIMER_TEXT;
					}
				}
				return msTextNoMapDisclaimerText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextRunkeeper.Text</b>.
		/// </summary>
		const string TEXT_RUNKEEPER_TEXT = "Runkeeper";
		/// <summary>
		/// Inner member for property <see cref="TextRunkeeperText"/>.
		/// </summary>
		static string msTextRunkeeperText;
		/// <summary>
		/// Gets string value for resource <b>TextRunkeeper.Text</b> (<i>"Runkeeper"</i>).
		/// </summary>
		public static string TextRunkeeperText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextRunkeeperText))
				{
					msTextRunkeeperText = moResourceLoader.GetString("TextRunkeeper.Text");
					if (string.IsNullOrEmpty(msTextRunkeeperText))
					{
						msTextRunkeeperText = TEXT_RUNKEEPER_TEXT;
					}
				}
				return msTextRunkeeperText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextServices.Text</b>.
		/// </summary>
		const string TEXT_SERVICES_TEXT = "services";
		/// <summary>
		/// Inner member for property <see cref="TextServicesText"/>.
		/// </summary>
		static string msTextServicesText;
		/// <summary>
		/// Gets string value for resource <b>TextServices.Text</b> (<i>"services"</i>).
		/// </summary>
		public static string TextServicesText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextServicesText))
				{
					msTextServicesText = moResourceLoader.GetString("TextServices.Text");
					if (string.IsNullOrEmpty(msTextServicesText))
					{
						msTextServicesText = TEXT_SERVICES_TEXT;
					}
				}
				return msTextServicesText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextSettingsTitle.Text</b>.
		/// </summary>
		const string TEXT_SETTINGS_TITLE_TEXT = "settings";
		/// <summary>
		/// Inner member for property <see cref="TextSettingsTitleText"/>.
		/// </summary>
		static string msTextSettingsTitleText;
		/// <summary>
		/// Gets string value for resource <b>TextSettingsTitle.Text</b> (<i>"settings"</i>).
		/// </summary>
		public static string TextSettingsTitleText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextSettingsTitleText))
				{
					msTextSettingsTitleText = moResourceLoader.GetString("TextSettingsTitle.Text");
					if (string.IsNullOrEmpty(msTextSettingsTitleText))
					{
						msTextSettingsTitleText = TEXT_SETTINGS_TITLE_TEXT;
					}
				}
				return msTextSettingsTitleText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextSignInDisclaimer.Text</b>.
		/// </summary>
		const string TEXT_SIGN_IN_DISCLAIMER_TEXT = "Not connected to Microsoft Health service. Open 'settings' and sign-in.";
		/// <summary>
		/// Inner member for property <see cref="TextSignInDisclaimerText"/>.
		/// </summary>
		static string msTextSignInDisclaimerText;
		/// <summary>
		/// Gets string value for resource <b>TextSignInDisclaimer.Text</b> (<i>"Not connected to Microsoft Health service. Open 'settings' and sign-in."</i>).
		/// </summary>
		public static string TextSignInDisclaimerText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextSignInDisclaimerText))
				{
					msTextSignInDisclaimerText = moResourceLoader.GetString("TextSignInDisclaimer.Text");
					if (string.IsNullOrEmpty(msTextSignInDisclaimerText))
					{
						msTextSignInDisclaimerText = TEXT_SIGN_IN_DISCLAIMER_TEXT;
					}
				}
				return msTextSignInDisclaimerText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ToggleActivityDistanceKilometer.Text</b>.
		/// </summary>
		const string TOGGLE_ACTIVITY_DISTANCE_KILOMETER_TEXT = "kilometers";
		/// <summary>
		/// Inner member for property <see cref="ToggleActivityDistanceKilometerText"/>.
		/// </summary>
		static string msToggleActivityDistanceKilometerText;
		/// <summary>
		/// Gets string value for resource <b>ToggleActivityDistanceKilometer.Text</b> (<i>"kilometers"</i>).
		/// </summary>
		public static string ToggleActivityDistanceKilometerText
		{
			get
			{
				if (string.IsNullOrEmpty(msToggleActivityDistanceKilometerText))
				{
					msToggleActivityDistanceKilometerText = moResourceLoader.GetString("ToggleActivityDistanceKilometer.Text");
					if (string.IsNullOrEmpty(msToggleActivityDistanceKilometerText))
					{
						msToggleActivityDistanceKilometerText = TOGGLE_ACTIVITY_DISTANCE_KILOMETER_TEXT;
					}
				}
				return msToggleActivityDistanceKilometerText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ToggleActivityDistanceMile.Text</b>.
		/// </summary>
		const string TOGGLE_ACTIVITY_DISTANCE_MILE_TEXT = "miles";
		/// <summary>
		/// Inner member for property <see cref="ToggleActivityDistanceMileText"/>.
		/// </summary>
		static string msToggleActivityDistanceMileText;
		/// <summary>
		/// Gets string value for resource <b>ToggleActivityDistanceMile.Text</b> (<i>"miles"</i>).
		/// </summary>
		public static string ToggleActivityDistanceMileText
		{
			get
			{
				if (string.IsNullOrEmpty(msToggleActivityDistanceMileText))
				{
					msToggleActivityDistanceMileText = moResourceLoader.GetString("ToggleActivityDistanceMile.Text");
					if (string.IsNullOrEmpty(msToggleActivityDistanceMileText))
					{
						msToggleActivityDistanceMileText = TOGGLE_ACTIVITY_DISTANCE_MILE_TEXT;
					}
				}
				return msToggleActivityDistanceMileText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ToggleActivityPeriodAll.Text</b>.
		/// </summary>
		const string TOGGLE_ACTIVITY_PERIOD_ALL_TEXT = "all";
		/// <summary>
		/// Inner member for property <see cref="ToggleActivityPeriodAllText"/>.
		/// </summary>
		static string msToggleActivityPeriodAllText;
		/// <summary>
		/// Gets string value for resource <b>ToggleActivityPeriodAll.Text</b> (<i>"all"</i>).
		/// </summary>
		public static string ToggleActivityPeriodAllText
		{
			get
			{
				if (string.IsNullOrEmpty(msToggleActivityPeriodAllText))
				{
					msToggleActivityPeriodAllText = moResourceLoader.GetString("ToggleActivityPeriodAll.Text");
					if (string.IsNullOrEmpty(msToggleActivityPeriodAllText))
					{
						msToggleActivityPeriodAllText = TOGGLE_ACTIVITY_PERIOD_ALL_TEXT;
					}
				}
				return msToggleActivityPeriodAllText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ToggleActivityPeriodDay.Text</b>.
		/// </summary>
		const string TOGGLE_ACTIVITY_PERIOD_DAY_TEXT = "last day";
		/// <summary>
		/// Inner member for property <see cref="ToggleActivityPeriodDayText"/>.
		/// </summary>
		static string msToggleActivityPeriodDayText;
		/// <summary>
		/// Gets string value for resource <b>ToggleActivityPeriodDay.Text</b> (<i>"last day"</i>).
		/// </summary>
		public static string ToggleActivityPeriodDayText
		{
			get
			{
				if (string.IsNullOrEmpty(msToggleActivityPeriodDayText))
				{
					msToggleActivityPeriodDayText = moResourceLoader.GetString("ToggleActivityPeriodDay.Text");
					if (string.IsNullOrEmpty(msToggleActivityPeriodDayText))
					{
						msToggleActivityPeriodDayText = TOGGLE_ACTIVITY_PERIOD_DAY_TEXT;
					}
				}
				return msToggleActivityPeriodDayText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ToggleActivityPeriodMonth.Text</b>.
		/// </summary>
		const string TOGGLE_ACTIVITY_PERIOD_MONTH_TEXT = "last month";
		/// <summary>
		/// Inner member for property <see cref="ToggleActivityPeriodMonthText"/>.
		/// </summary>
		static string msToggleActivityPeriodMonthText;
		/// <summary>
		/// Gets string value for resource <b>ToggleActivityPeriodMonth.Text</b> (<i>"last month"</i>).
		/// </summary>
		public static string ToggleActivityPeriodMonthText
		{
			get
			{
				if (string.IsNullOrEmpty(msToggleActivityPeriodMonthText))
				{
					msToggleActivityPeriodMonthText = moResourceLoader.GetString("ToggleActivityPeriodMonth.Text");
					if (string.IsNullOrEmpty(msToggleActivityPeriodMonthText))
					{
						msToggleActivityPeriodMonthText = TOGGLE_ACTIVITY_PERIOD_MONTH_TEXT;
					}
				}
				return msToggleActivityPeriodMonthText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ToggleActivityPeriodWeek.Text</b>.
		/// </summary>
		const string TOGGLE_ACTIVITY_PERIOD_WEEK_TEXT = "last week";
		/// <summary>
		/// Inner member for property <see cref="ToggleActivityPeriodWeekText"/>.
		/// </summary>
		static string msToggleActivityPeriodWeekText;
		/// <summary>
		/// Gets string value for resource <b>ToggleActivityPeriodWeek.Text</b> (<i>"last week"</i>).
		/// </summary>
		public static string ToggleActivityPeriodWeekText
		{
			get
			{
				if (string.IsNullOrEmpty(msToggleActivityPeriodWeekText))
				{
					msToggleActivityPeriodWeekText = moResourceLoader.GetString("ToggleActivityPeriodWeek.Text");
					if (string.IsNullOrEmpty(msToggleActivityPeriodWeekText))
					{
						msToggleActivityPeriodWeekText = TOGGLE_ACTIVITY_PERIOD_WEEK_TEXT;
					}
				}
				return msToggleActivityPeriodWeekText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ToggleActivityPeriodYear.Text</b>.
		/// </summary>
		const string TOGGLE_ACTIVITY_PERIOD_YEAR_TEXT = "last year";
		/// <summary>
		/// Inner member for property <see cref="ToggleActivityPeriodYearText"/>.
		/// </summary>
		static string msToggleActivityPeriodYearText;
		/// <summary>
		/// Gets string value for resource <b>ToggleActivityPeriodYear.Text</b> (<i>"last year"</i>).
		/// </summary>
		public static string ToggleActivityPeriodYearText
		{
			get
			{
				if (string.IsNullOrEmpty(msToggleActivityPeriodYearText))
				{
					msToggleActivityPeriodYearText = moResourceLoader.GetString("ToggleActivityPeriodYear.Text");
					if (string.IsNullOrEmpty(msToggleActivityPeriodYearText))
					{
						msToggleActivityPeriodYearText = TOGGLE_ACTIVITY_PERIOD_YEAR_TEXT;
					}
				}
				return msToggleActivityPeriodYearText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ToggleActivityTypeBike.Text</b>.
		/// </summary>
		const string TOGGLE_ACTIVITY_TYPE_BIKE_TEXT = "bike";
		/// <summary>
		/// Inner member for property <see cref="ToggleActivityTypeBikeText"/>.
		/// </summary>
		static string msToggleActivityTypeBikeText;
		/// <summary>
		/// Gets string value for resource <b>ToggleActivityTypeBike.Text</b> (<i>"bike"</i>).
		/// </summary>
		public static string ToggleActivityTypeBikeText
		{
			get
			{
				if (string.IsNullOrEmpty(msToggleActivityTypeBikeText))
				{
					msToggleActivityTypeBikeText = moResourceLoader.GetString("ToggleActivityTypeBike.Text");
					if (string.IsNullOrEmpty(msToggleActivityTypeBikeText))
					{
						msToggleActivityTypeBikeText = TOGGLE_ACTIVITY_TYPE_BIKE_TEXT;
					}
				}
				return msToggleActivityTypeBikeText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ToggleActivityTypeExercise.Text</b>.
		/// </summary>
		const string TOGGLE_ACTIVITY_TYPE_EXERCISE_TEXT = "exercise";
		/// <summary>
		/// Inner member for property <see cref="ToggleActivityTypeExerciseText"/>.
		/// </summary>
		static string msToggleActivityTypeExerciseText;
		/// <summary>
		/// Gets string value for resource <b>ToggleActivityTypeExercise.Text</b> (<i>"exercise"</i>).
		/// </summary>
		public static string ToggleActivityTypeExerciseText
		{
			get
			{
				if (string.IsNullOrEmpty(msToggleActivityTypeExerciseText))
				{
					msToggleActivityTypeExerciseText = moResourceLoader.GetString("ToggleActivityTypeExercise.Text");
					if (string.IsNullOrEmpty(msToggleActivityTypeExerciseText))
					{
						msToggleActivityTypeExerciseText = TOGGLE_ACTIVITY_TYPE_EXERCISE_TEXT;
					}
				}
				return msToggleActivityTypeExerciseText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ToggleActivityTypeGolf.Text</b>.
		/// </summary>
		const string TOGGLE_ACTIVITY_TYPE_GOLF_TEXT = "golf";
		/// <summary>
		/// Inner member for property <see cref="ToggleActivityTypeGolfText"/>.
		/// </summary>
		static string msToggleActivityTypeGolfText;
		/// <summary>
		/// Gets string value for resource <b>ToggleActivityTypeGolf.Text</b> (<i>"golf"</i>).
		/// </summary>
		public static string ToggleActivityTypeGolfText
		{
			get
			{
				if (string.IsNullOrEmpty(msToggleActivityTypeGolfText))
				{
					msToggleActivityTypeGolfText = moResourceLoader.GetString("ToggleActivityTypeGolf.Text");
					if (string.IsNullOrEmpty(msToggleActivityTypeGolfText))
					{
						msToggleActivityTypeGolfText = TOGGLE_ACTIVITY_TYPE_GOLF_TEXT;
					}
				}
				return msToggleActivityTypeGolfText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ToggleActivityTypeGuided.Text</b>.
		/// </summary>
		const string TOGGLE_ACTIVITY_TYPE_GUIDED_TEXT = "guided workout";
		/// <summary>
		/// Inner member for property <see cref="ToggleActivityTypeGuidedText"/>.
		/// </summary>
		static string msToggleActivityTypeGuidedText;
		/// <summary>
		/// Gets string value for resource <b>ToggleActivityTypeGuided.Text</b> (<i>"guided workout"</i>).
		/// </summary>
		public static string ToggleActivityTypeGuidedText
		{
			get
			{
				if (string.IsNullOrEmpty(msToggleActivityTypeGuidedText))
				{
					msToggleActivityTypeGuidedText = moResourceLoader.GetString("ToggleActivityTypeGuided.Text");
					if (string.IsNullOrEmpty(msToggleActivityTypeGuidedText))
					{
						msToggleActivityTypeGuidedText = TOGGLE_ACTIVITY_TYPE_GUIDED_TEXT;
					}
				}
				return msToggleActivityTypeGuidedText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ToggleActivityTypeRun.Text</b>.
		/// </summary>
		const string TOGGLE_ACTIVITY_TYPE_RUN_TEXT = "run";
		/// <summary>
		/// Inner member for property <see cref="ToggleActivityTypeRunText"/>.
		/// </summary>
		static string msToggleActivityTypeRunText;
		/// <summary>
		/// Gets string value for resource <b>ToggleActivityTypeRun.Text</b> (<i>"run"</i>).
		/// </summary>
		public static string ToggleActivityTypeRunText
		{
			get
			{
				if (string.IsNullOrEmpty(msToggleActivityTypeRunText))
				{
					msToggleActivityTypeRunText = moResourceLoader.GetString("ToggleActivityTypeRun.Text");
					if (string.IsNullOrEmpty(msToggleActivityTypeRunText))
					{
						msToggleActivityTypeRunText = TOGGLE_ACTIVITY_TYPE_RUN_TEXT;
					}
				}
				return msToggleActivityTypeRunText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ToggleActivityTypeSleep.Text</b>.
		/// </summary>
		const string TOGGLE_ACTIVITY_TYPE_SLEEP_TEXT = "sleep";
		/// <summary>
		/// Inner member for property <see cref="ToggleActivityTypeSleepText"/>.
		/// </summary>
		static string msToggleActivityTypeSleepText;
		/// <summary>
		/// Gets string value for resource <b>ToggleActivityTypeSleep.Text</b> (<i>"sleep"</i>).
		/// </summary>
		public static string ToggleActivityTypeSleepText
		{
			get
			{
				if (string.IsNullOrEmpty(msToggleActivityTypeSleepText))
				{
					msToggleActivityTypeSleepText = moResourceLoader.GetString("ToggleActivityTypeSleep.Text");
					if (string.IsNullOrEmpty(msToggleActivityTypeSleepText))
					{
						msToggleActivityTypeSleepText = TOGGLE_ACTIVITY_TYPE_SLEEP_TEXT;
					}
				}
				return msToggleActivityTypeSleepText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageButtonOK</b>.
		/// </summary>
		const string MESSAGE_BUTTON_O_K = "ok";
		/// <summary>
		/// Inner member for property <see cref="MessageButtonOK"/>.
		/// </summary>
		static string msMessageButtonOK;
		/// <summary>
		/// Gets string value for resource <b>MessageButtonOK</b> (<i>"ok"</i>).
		/// </summary>
		public static string MessageButtonOK
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageButtonOK))
				{
					msMessageButtonOK = moResourceLoader.GetString("MessageButtonOK");
					if (string.IsNullOrEmpty(msMessageButtonOK))
					{
						msMessageButtonOK = MESSAGE_BUTTON_O_K;
					}
				}
				return msMessageButtonOK;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageContentErrorOperation</b>.
		/// </summary>
		const string MESSAGE_CONTENT_ERROR_OPERATION = "an error occurred during operation. wait a moment and try again.";
		/// <summary>
		/// Inner member for property <see cref="MessageContentErrorOperation"/>.
		/// </summary>
		static string msMessageContentErrorOperation;
		/// <summary>
		/// Gets string value for resource <b>MessageContentErrorOperation</b> (<i>"an error occurred during operation. wait a moment and try again."</i>).
		/// </summary>
		public static string MessageContentErrorOperation
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageContentErrorOperation))
				{
					msMessageContentErrorOperation = moResourceLoader.GetString("MessageContentErrorOperation");
					if (string.IsNullOrEmpty(msMessageContentErrorOperation))
					{
						msMessageContentErrorOperation = MESSAGE_CONTENT_ERROR_OPERATION;
					}
				}
				return msMessageContentErrorOperation;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageTitleError</b>.
		/// </summary>
		const string MESSAGE_TITLE_ERROR = "error";
		/// <summary>
		/// Inner member for property <see cref="MessageTitleError"/>.
		/// </summary>
		static string msMessageTitleError;
		/// <summary>
		/// Gets string value for resource <b>MessageTitleError</b> (<i>"error"</i>).
		/// </summary>
		public static string MessageTitleError
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageTitleError))
				{
					msMessageTitleError = moResourceLoader.GetString("MessageTitleError");
					if (string.IsNullOrEmpty(msMessageTitleError))
					{
						msMessageTitleError = MESSAGE_TITLE_ERROR;
					}
				}
				return msMessageTitleError;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>AppBarButtonActivitiesExportCSV.Label</b>.
		/// </summary>
		const string APP_BAR_BUTTON_ACTIVITIES_EXPORT_C_S_V_LABEL = "export activities to csv";
		/// <summary>
		/// Inner member for property <see cref="AppBarButtonActivitiesExportCSVLabel"/>.
		/// </summary>
		static string msAppBarButtonActivitiesExportCSVLabel;
		/// <summary>
		/// Gets string value for resource <b>AppBarButtonActivitiesExportCSV.Label</b> (<i>"export activities to csv"</i>).
		/// </summary>
		public static string AppBarButtonActivitiesExportCSVLabel
		{
			get
			{
				if (string.IsNullOrEmpty(msAppBarButtonActivitiesExportCSVLabel))
				{
					msAppBarButtonActivitiesExportCSVLabel = moResourceLoader.GetString("AppBarButtonActivitiesExportCSV.Label");
					if (string.IsNullOrEmpty(msAppBarButtonActivitiesExportCSVLabel))
					{
						msAppBarButtonActivitiesExportCSVLabel = APP_BAR_BUTTON_ACTIVITIES_EXPORT_C_S_V_LABEL;
					}
				}
				return msAppBarButtonActivitiesExportCSVLabel;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>FileCSVActivitiesHeader</b>.
		/// </summary>
		const string FILE_C_S_V_ACTIVITIES_HEADER = "StartTime,Type,Duration,AvgHR,MaxHR,MinHR,Calories,Distance,Pace,EleGain,EleLoss,EleMax,EleMin,HRUnderHealthy,HRHealthy,HRFitness,HRAerobic,HRAnaerobic,HRRedline,HROverReline";
		/// <summary>
		/// Inner member for property <see cref="FileCSVActivitiesHeader"/>.
		/// </summary>
		static string msFileCSVActivitiesHeader;
		/// <summary>
		/// Gets string value for resource <b>FileCSVActivitiesHeader</b> (<i>"StartTime,Type,Duration,AvgHR,MaxHR,MinHR,Calories,Distance,Pace,EleGain,EleLoss,EleMax,EleMin,HRUnderHealthy,HRHealthy,HRFitness,HRAerobic,HRAnaerobic,HRRedline,HROverReline"</i>).
		/// </summary>
		public static string FileCSVActivitiesHeader
		{
			get
			{
				if (string.IsNullOrEmpty(msFileCSVActivitiesHeader))
				{
					msFileCSVActivitiesHeader = moResourceLoader.GetString("FileCSVActivitiesHeader");
					if (string.IsNullOrEmpty(msFileCSVActivitiesHeader))
					{
						msFileCSVActivitiesHeader = FILE_C_S_V_ACTIVITIES_HEADER;
					}
				}
				return msFileCSVActivitiesHeader;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageButtonCancel</b>.
		/// </summary>
		const string MESSAGE_BUTTON_CANCEL = "cancel";
		/// <summary>
		/// Inner member for property <see cref="MessageButtonCancel"/>.
		/// </summary>
		static string msMessageButtonCancel;
		/// <summary>
		/// Gets string value for resource <b>MessageButtonCancel</b> (<i>"cancel"</i>).
		/// </summary>
		public static string MessageButtonCancel
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageButtonCancel))
				{
					msMessageButtonCancel = moResourceLoader.GetString("MessageButtonCancel");
					if (string.IsNullOrEmpty(msMessageButtonCancel))
					{
						msMessageButtonCancel = MESSAGE_BUTTON_CANCEL;
					}
				}
				return msMessageButtonCancel;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageButtonNo</b>.
		/// </summary>
		const string MESSAGE_BUTTON_NO = "no";
		/// <summary>
		/// Inner member for property <see cref="MessageButtonNo"/>.
		/// </summary>
		static string msMessageButtonNo;
		/// <summary>
		/// Gets string value for resource <b>MessageButtonNo</b> (<i>"no"</i>).
		/// </summary>
		public static string MessageButtonNo
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageButtonNo))
				{
					msMessageButtonNo = moResourceLoader.GetString("MessageButtonNo");
					if (string.IsNullOrEmpty(msMessageButtonNo))
					{
						msMessageButtonNo = MESSAGE_BUTTON_NO;
					}
				}
				return msMessageButtonNo;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageButtonYes</b>.
		/// </summary>
		const string MESSAGE_BUTTON_YES = "yes";
		/// <summary>
		/// Inner member for property <see cref="MessageButtonYes"/>.
		/// </summary>
		static string msMessageButtonYes;
		/// <summary>
		/// Gets string value for resource <b>MessageButtonYes</b> (<i>"yes"</i>).
		/// </summary>
		public static string MessageButtonYes
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageButtonYes))
				{
					msMessageButtonYes = moResourceLoader.GetString("MessageButtonYes");
					if (string.IsNullOrEmpty(msMessageButtonYes))
					{
						msMessageButtonYes = MESSAGE_BUTTON_YES;
					}
				}
				return msMessageButtonYes;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageContentExportCSVFail</b>.
		/// </summary>
		const string MESSAGE_CONTENT_EXPORT_C_S_V_FAIL = "activities couldn't be exported to: {0}";
		/// <summary>
		/// Inner member for property <see cref="MessageContentExportCSVFail"/>.
		/// </summary>
		static string msMessageContentExportCSVFail;
		/// <summary>
		/// Gets string value for resource <b>MessageContentExportCSVFail</b> (<i>"activities couldn't be exported to: {0}"</i>).
		/// </summary>
		public static string MessageContentExportCSVFail
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageContentExportCSVFail))
				{
					msMessageContentExportCSVFail = moResourceLoader.GetString("MessageContentExportCSVFail");
					if (string.IsNullOrEmpty(msMessageContentExportCSVFail))
					{
						msMessageContentExportCSVFail = MESSAGE_CONTENT_EXPORT_C_S_V_FAIL;
					}
				}
				return msMessageContentExportCSVFail;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageContentExportCSVSuccess</b>.
		/// </summary>
		const string MESSAGE_CONTENT_EXPORT_C_S_V_SUCCESS = "activities exported to: {0}";
		/// <summary>
		/// Inner member for property <see cref="MessageContentExportCSVSuccess"/>.
		/// </summary>
		static string msMessageContentExportCSVSuccess;
		/// <summary>
		/// Gets string value for resource <b>MessageContentExportCSVSuccess</b> (<i>"activities exported to: {0}"</i>).
		/// </summary>
		public static string MessageContentExportCSVSuccess
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageContentExportCSVSuccess))
				{
					msMessageContentExportCSVSuccess = moResourceLoader.GetString("MessageContentExportCSVSuccess");
					if (string.IsNullOrEmpty(msMessageContentExportCSVSuccess))
					{
						msMessageContentExportCSVSuccess = MESSAGE_CONTENT_EXPORT_C_S_V_SUCCESS;
					}
				}
				return msMessageContentExportCSVSuccess;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageContentExportEmptyGPSData</b>.
		/// </summary>
		const string MESSAGE_CONTENT_EXPORT_EMPTY_G_P_S_DATA = "seems that current activity doesn't contains valid gps data. ¿export anyway?";
		/// <summary>
		/// Inner member for property <see cref="MessageContentExportEmptyGPSData"/>.
		/// </summary>
		static string msMessageContentExportEmptyGPSData;
		/// <summary>
		/// Gets string value for resource <b>MessageContentExportEmptyGPSData</b> (<i>"seems that current activity doesn't contains valid gps data. ¿export anyway?"</i>).
		/// </summary>
		public static string MessageContentExportEmptyGPSData
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageContentExportEmptyGPSData))
				{
					msMessageContentExportEmptyGPSData = moResourceLoader.GetString("MessageContentExportEmptyGPSData");
					if (string.IsNullOrEmpty(msMessageContentExportEmptyGPSData))
					{
						msMessageContentExportEmptyGPSData = MESSAGE_CONTENT_EXPORT_EMPTY_G_P_S_DATA;
					}
				}
				return msMessageContentExportEmptyGPSData;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageContentActivityExportFail</b>.
		/// </summary>
		const string MESSAGE_CONTENT_ACTIVITY_EXPORT_FAIL = "activity couldn't be exported to: {0}";
		/// <summary>
		/// Inner member for property <see cref="MessageContentActivityExportFail"/>.
		/// </summary>
		static string msMessageContentActivityExportFail;
		/// <summary>
		/// Gets string value for resource <b>MessageContentActivityExportFail</b> (<i>"activity couldn't be exported to: {0}"</i>).
		/// </summary>
		public static string MessageContentActivityExportFail
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageContentActivityExportFail))
				{
					msMessageContentActivityExportFail = moResourceLoader.GetString("MessageContentActivityExportFail");
					if (string.IsNullOrEmpty(msMessageContentActivityExportFail))
					{
						msMessageContentActivityExportFail = MESSAGE_CONTENT_ACTIVITY_EXPORT_FAIL;
					}
				}
				return msMessageContentActivityExportFail;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageContentActivityExportSuccess</b>.
		/// </summary>
		const string MESSAGE_CONTENT_ACTIVITY_EXPORT_SUCCESS = "activity exported to: {0}";
		/// <summary>
		/// Inner member for property <see cref="MessageContentActivityExportSuccess"/>.
		/// </summary>
		static string msMessageContentActivityExportSuccess;
		/// <summary>
		/// Gets string value for resource <b>MessageContentActivityExportSuccess</b> (<i>"activity exported to: {0}"</i>).
		/// </summary>
		public static string MessageContentActivityExportSuccess
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageContentActivityExportSuccess))
				{
					msMessageContentActivityExportSuccess = moResourceLoader.GetString("MessageContentActivityExportSuccess");
					if (string.IsNullOrEmpty(msMessageContentActivityExportSuccess))
					{
						msMessageContentActivityExportSuccess = MESSAGE_CONTENT_ACTIVITY_EXPORT_SUCCESS;
					}
				}
				return msMessageContentActivityExportSuccess;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageContentSelectActivityType</b>.
		/// </summary>
		const string MESSAGE_CONTENT_SELECT_ACTIVITY_TYPE = "select at least one activity type to filter.";
		/// <summary>
		/// Inner member for property <see cref="MessageContentSelectActivityType"/>.
		/// </summary>
		static string msMessageContentSelectActivityType;
		/// <summary>
		/// Gets string value for resource <b>MessageContentSelectActivityType</b> (<i>"select at least one activity type to filter."</i>).
		/// </summary>
		public static string MessageContentSelectActivityType
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageContentSelectActivityType))
				{
					msMessageContentSelectActivityType = moResourceLoader.GetString("MessageContentSelectActivityType");
					if (string.IsNullOrEmpty(msMessageContentSelectActivityType))
					{
						msMessageContentSelectActivityType = MESSAGE_CONTENT_SELECT_ACTIVITY_TYPE;
					}
				}
				return msMessageContentSelectActivityType;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageTitleExportCSV</b>.
		/// </summary>
		const string MESSAGE_TITLE_EXPORT_C_S_V = "export csv";
		/// <summary>
		/// Inner member for property <see cref="MessageTitleExportCSV"/>.
		/// </summary>
		static string msMessageTitleExportCSV;
		/// <summary>
		/// Gets string value for resource <b>MessageTitleExportCSV</b> (<i>"export csv"</i>).
		/// </summary>
		public static string MessageTitleExportCSV
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageTitleExportCSV))
				{
					msMessageTitleExportCSV = moResourceLoader.GetString("MessageTitleExportCSV");
					if (string.IsNullOrEmpty(msMessageTitleExportCSV))
					{
						msMessageTitleExportCSV = MESSAGE_TITLE_EXPORT_C_S_V;
					}
				}
				return msMessageTitleExportCSV;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageTitleExportGPX</b>.
		/// </summary>
		const string MESSAGE_TITLE_EXPORT_G_P_X = "export gpx";
		/// <summary>
		/// Inner member for property <see cref="MessageTitleExportGPX"/>.
		/// </summary>
		static string msMessageTitleExportGPX;
		/// <summary>
		/// Gets string value for resource <b>MessageTitleExportGPX</b> (<i>"export gpx"</i>).
		/// </summary>
		public static string MessageTitleExportGPX
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageTitleExportGPX))
				{
					msMessageTitleExportGPX = moResourceLoader.GetString("MessageTitleExportGPX");
					if (string.IsNullOrEmpty(msMessageTitleExportGPX))
					{
						msMessageTitleExportGPX = MESSAGE_TITLE_EXPORT_G_P_X;
					}
				}
				return msMessageTitleExportGPX;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageTitleFilterActivities</b>.
		/// </summary>
		const string MESSAGE_TITLE_FILTER_ACTIVITIES = "filter activities";
		/// <summary>
		/// Inner member for property <see cref="MessageTitleFilterActivities"/>.
		/// </summary>
		static string msMessageTitleFilterActivities;
		/// <summary>
		/// Gets string value for resource <b>MessageTitleFilterActivities</b> (<i>"filter activities"</i>).
		/// </summary>
		public static string MessageTitleFilterActivities
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageTitleFilterActivities))
				{
					msMessageTitleFilterActivities = moResourceLoader.GetString("MessageTitleFilterActivities");
					if (string.IsNullOrEmpty(msMessageTitleFilterActivities))
					{
						msMessageTitleFilterActivities = MESSAGE_TITLE_FILTER_ACTIVITIES;
					}
				}
				return msMessageTitleFilterActivities;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextDistanceUnitShortKilometer.Text</b>.
		/// </summary>
		const string TEXT_DISTANCE_UNIT_SHORT_KILOMETER_TEXT = "km";
		/// <summary>
		/// Inner member for property <see cref="TextDistanceUnitShortKilometerText"/>.
		/// </summary>
		static string msTextDistanceUnitShortKilometerText;
		/// <summary>
		/// Gets string value for resource <b>TextDistanceUnitShortKilometer.Text</b> (<i>"km"</i>).
		/// </summary>
		public static string TextDistanceUnitShortKilometerText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextDistanceUnitShortKilometerText))
				{
					msTextDistanceUnitShortKilometerText = moResourceLoader.GetString("TextDistanceUnitShortKilometer.Text");
					if (string.IsNullOrEmpty(msTextDistanceUnitShortKilometerText))
					{
						msTextDistanceUnitShortKilometerText = TEXT_DISTANCE_UNIT_SHORT_KILOMETER_TEXT;
					}
				}
				return msTextDistanceUnitShortKilometerText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextDistanceUnitShortMile.Text</b>.
		/// </summary>
		const string TEXT_DISTANCE_UNIT_SHORT_MILE_TEXT = "mi";
		/// <summary>
		/// Inner member for property <see cref="TextDistanceUnitShortMileText"/>.
		/// </summary>
		static string msTextDistanceUnitShortMileText;
		/// <summary>
		/// Gets string value for resource <b>TextDistanceUnitShortMile.Text</b> (<i>"mi"</i>).
		/// </summary>
		public static string TextDistanceUnitShortMileText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextDistanceUnitShortMileText))
				{
					msTextDistanceUnitShortMileText = moResourceLoader.GetString("TextDistanceUnitShortMile.Text");
					if (string.IsNullOrEmpty(msTextDistanceUnitShortMileText))
					{
						msTextDistanceUnitShortMileText = TEXT_DISTANCE_UNIT_SHORT_MILE_TEXT;
					}
				}
				return msTextDistanceUnitShortMileText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextNoSplitsDisclaimer.Text</b>.
		/// </summary>
		const string TEXT_NO_SPLITS_DISCLAIMER_TEXT = "Split data not found for current activity";
		/// <summary>
		/// Inner member for property <see cref="TextNoSplitsDisclaimerText"/>.
		/// </summary>
		static string msTextNoSplitsDisclaimerText;
		/// <summary>
		/// Gets string value for resource <b>TextNoSplitsDisclaimer.Text</b> (<i>"Split data not found for current activity"</i>).
		/// </summary>
		public static string TextNoSplitsDisclaimerText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextNoSplitsDisclaimerText))
				{
					msTextNoSplitsDisclaimerText = moResourceLoader.GetString("TextNoSplitsDisclaimer.Text");
					if (string.IsNullOrEmpty(msTextNoSplitsDisclaimerText))
					{
						msTextNoSplitsDisclaimerText = TEXT_NO_SPLITS_DISCLAIMER_TEXT;
					}
				}
				return msTextNoSplitsDisclaimerText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextSettingsAboutHeader.Label</b>.
		/// </summary>
		const string TEXT_SETTINGS_ABOUT_HEADER_LABEL = "about";
		/// <summary>
		/// Inner member for property <see cref="TextSettingsAboutHeaderLabel"/>.
		/// </summary>
		static string msTextSettingsAboutHeaderLabel;
		/// <summary>
		/// Gets string value for resource <b>TextSettingsAboutHeader.Label</b> (<i>"about"</i>).
		/// </summary>
		public static string TextSettingsAboutHeaderLabel
		{
			get
			{
				if (string.IsNullOrEmpty(msTextSettingsAboutHeaderLabel))
				{
					msTextSettingsAboutHeaderLabel = moResourceLoader.GetString("TextSettingsAboutHeader.Label");
					if (string.IsNullOrEmpty(msTextSettingsAboutHeaderLabel))
					{
						msTextSettingsAboutHeaderLabel = TEXT_SETTINGS_ABOUT_HEADER_LABEL;
					}
				}
				return msTextSettingsAboutHeaderLabel;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextSettingsAppDescription.Text</b>.
		/// </summary>
		const string TEXT_SETTINGS_APP_DESCRIPTION_TEXT = "eXport your Microsoft Band activities:\r\n- Filter by Type/Period\r\n- See Details/Heart Rate/Splits/Map\r\n- Export List to CSV\r\n- Export GPS activities to GPX/TCX\r\n- Sync to Nike+";
		/// <summary>
		/// Inner member for property <see cref="TextSettingsAppDescriptionText"/>.
		/// </summary>
		static string msTextSettingsAppDescriptionText;
		/// <summary>
		/// Gets string value for resource <b>TextSettingsAppDescription.Text</b> (<i>"eXport your Microsoft Band activities: - Filter by Type/Period - See Details/Heart Rate/Splits/Map - Export List to CSV - Export GPS activities to GPX/TCX - Sync to Nike+"</i>).
		/// </summary>
		public static string TextSettingsAppDescriptionText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextSettingsAppDescriptionText))
				{
					msTextSettingsAppDescriptionText = moResourceLoader.GetString("TextSettingsAppDescription.Text");
					if (string.IsNullOrEmpty(msTextSettingsAppDescriptionText))
					{
						msTextSettingsAppDescriptionText = TEXT_SETTINGS_APP_DESCRIPTION_TEXT;
					}
				}
				return msTextSettingsAppDescriptionText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextSettingsServicesHeader.Label</b>.
		/// </summary>
		const string TEXT_SETTINGS_SERVICES_HEADER_LABEL = "services";
		/// <summary>
		/// Inner member for property <see cref="TextSettingsServicesHeaderLabel"/>.
		/// </summary>
		static string msTextSettingsServicesHeaderLabel;
		/// <summary>
		/// Gets string value for resource <b>TextSettingsServicesHeader.Label</b> (<i>"services"</i>).
		/// </summary>
		public static string TextSettingsServicesHeaderLabel
		{
			get
			{
				if (string.IsNullOrEmpty(msTextSettingsServicesHeaderLabel))
				{
					msTextSettingsServicesHeaderLabel = moResourceLoader.GetString("TextSettingsServicesHeader.Label");
					if (string.IsNullOrEmpty(msTextSettingsServicesHeaderLabel))
					{
						msTextSettingsServicesHeaderLabel = TEXT_SETTINGS_SERVICES_HEADER_LABEL;
					}
				}
				return msTextSettingsServicesHeaderLabel;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextSplitAvgHRHeader.Text</b>.
		/// </summary>
		const string TEXT_SPLIT_AVG_H_R_HEADER_TEXT = "avg hr";
		/// <summary>
		/// Inner member for property <see cref="TextSplitAvgHRHeaderText"/>.
		/// </summary>
		static string msTextSplitAvgHRHeaderText;
		/// <summary>
		/// Gets string value for resource <b>TextSplitAvgHRHeader.Text</b> (<i>"avg hr"</i>).
		/// </summary>
		public static string TextSplitAvgHRHeaderText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextSplitAvgHRHeaderText))
				{
					msTextSplitAvgHRHeaderText = moResourceLoader.GetString("TextSplitAvgHRHeader.Text");
					if (string.IsNullOrEmpty(msTextSplitAvgHRHeaderText))
					{
						msTextSplitAvgHRHeaderText = TEXT_SPLIT_AVG_H_R_HEADER_TEXT;
					}
				}
				return msTextSplitAvgHRHeaderText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextSplitDurationHeader.Text</b>.
		/// </summary>
		const string TEXT_SPLIT_DURATION_HEADER_TEXT = "duration";
		/// <summary>
		/// Inner member for property <see cref="TextSplitDurationHeaderText"/>.
		/// </summary>
		static string msTextSplitDurationHeaderText;
		/// <summary>
		/// Gets string value for resource <b>TextSplitDurationHeader.Text</b> (<i>"duration"</i>).
		/// </summary>
		public static string TextSplitDurationHeaderText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextSplitDurationHeaderText))
				{
					msTextSplitDurationHeaderText = moResourceLoader.GetString("TextSplitDurationHeader.Text");
					if (string.IsNullOrEmpty(msTextSplitDurationHeaderText))
					{
						msTextSplitDurationHeaderText = TEXT_SPLIT_DURATION_HEADER_TEXT;
					}
				}
				return msTextSplitDurationHeaderText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageTitleExportTCX</b>.
		/// </summary>
		const string MESSAGE_TITLE_EXPORT_T_C_X = "export tcx";
		/// <summary>
		/// Inner member for property <see cref="MessageTitleExportTCX"/>.
		/// </summary>
		static string msMessageTitleExportTCX;
		/// <summary>
		/// Gets string value for resource <b>MessageTitleExportTCX</b> (<i>"export tcx"</i>).
		/// </summary>
		public static string MessageTitleExportTCX
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageTitleExportTCX))
				{
					msMessageTitleExportTCX = moResourceLoader.GetString("MessageTitleExportTCX");
					if (string.IsNullOrEmpty(msMessageTitleExportTCX))
					{
						msMessageTitleExportTCX = MESSAGE_TITLE_EXPORT_T_C_X;
					}
				}
				return msMessageTitleExportTCX;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ButtonNikePlusClear.Content</b>.
		/// </summary>
		const string BUTTON_NIKE_PLUS_CLEAR_CONTENT = "clear";
		/// <summary>
		/// Inner member for property <see cref="ButtonNikePlusClearContent"/>.
		/// </summary>
		static string msButtonNikePlusClearContent;
		/// <summary>
		/// Gets string value for resource <b>ButtonNikePlusClear.Content</b> (<i>"clear"</i>).
		/// </summary>
		public static string ButtonNikePlusClearContent
		{
			get
			{
				if (string.IsNullOrEmpty(msButtonNikePlusClearContent))
				{
					msButtonNikePlusClearContent = moResourceLoader.GetString("ButtonNikePlusClear.Content");
					if (string.IsNullOrEmpty(msButtonNikePlusClearContent))
					{
						msButtonNikePlusClearContent = BUTTON_NIKE_PLUS_CLEAR_CONTENT;
					}
				}
				return msButtonNikePlusClearContent;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ButtonNikePlusValidate.Content</b>.
		/// </summary>
		const string BUTTON_NIKE_PLUS_VALIDATE_CONTENT = "validate";
		/// <summary>
		/// Inner member for property <see cref="ButtonNikePlusValidateContent"/>.
		/// </summary>
		static string msButtonNikePlusValidateContent;
		/// <summary>
		/// Gets string value for resource <b>ButtonNikePlusValidate.Content</b> (<i>"validate"</i>).
		/// </summary>
		public static string ButtonNikePlusValidateContent
		{
			get
			{
				if (string.IsNullOrEmpty(msButtonNikePlusValidateContent))
				{
					msButtonNikePlusValidateContent = moResourceLoader.GetString("ButtonNikePlusValidate.Content");
					if (string.IsNullOrEmpty(msButtonNikePlusValidateContent))
					{
						msButtonNikePlusValidateContent = BUTTON_NIKE_PLUS_VALIDATE_CONTENT;
					}
				}
				return msButtonNikePlusValidateContent;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextNikePlusPassword.Text</b>.
		/// </summary>
		const string TEXT_NIKE_PLUS_PASSWORD_TEXT = "password:";
		/// <summary>
		/// Inner member for property <see cref="TextNikePlusPasswordText"/>.
		/// </summary>
		static string msTextNikePlusPasswordText;
		/// <summary>
		/// Gets string value for resource <b>TextNikePlusPassword.Text</b> (<i>"password:"</i>).
		/// </summary>
		public static string TextNikePlusPasswordText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextNikePlusPasswordText))
				{
					msTextNikePlusPasswordText = moResourceLoader.GetString("TextNikePlusPassword.Text");
					if (string.IsNullOrEmpty(msTextNikePlusPasswordText))
					{
						msTextNikePlusPasswordText = TEXT_NIKE_PLUS_PASSWORD_TEXT;
					}
				}
				return msTextNikePlusPasswordText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>TextNikePlusUser.Text</b>.
		/// </summary>
		const string TEXT_NIKE_PLUS_USER_TEXT = "user (e-mail):";
		/// <summary>
		/// Inner member for property <see cref="TextNikePlusUserText"/>.
		/// </summary>
		static string msTextNikePlusUserText;
		/// <summary>
		/// Gets string value for resource <b>TextNikePlusUser.Text</b> (<i>"user (e-mail):"</i>).
		/// </summary>
		public static string TextNikePlusUserText
		{
			get
			{
				if (string.IsNullOrEmpty(msTextNikePlusUserText))
				{
					msTextNikePlusUserText = moResourceLoader.GetString("TextNikePlusUser.Text");
					if (string.IsNullOrEmpty(msTextNikePlusUserText))
					{
						msTextNikePlusUserText = TEXT_NIKE_PLUS_USER_TEXT;
					}
				}
				return msTextNikePlusUserText;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageButtonMoreDetails</b>.
		/// </summary>
		const string MESSAGE_BUTTON_MORE_DETAILS = "more details";
		/// <summary>
		/// Inner member for property <see cref="MessageButtonMoreDetails"/>.
		/// </summary>
		static string msMessageButtonMoreDetails;
		/// <summary>
		/// Gets string value for resource <b>MessageButtonMoreDetails</b> (<i>"more details"</i>).
		/// </summary>
		public static string MessageButtonMoreDetails
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageButtonMoreDetails))
				{
					msMessageButtonMoreDetails = moResourceLoader.GetString("MessageButtonMoreDetails");
					if (string.IsNullOrEmpty(msMessageButtonMoreDetails))
					{
						msMessageButtonMoreDetails = MESSAGE_BUTTON_MORE_DETAILS;
					}
				}
				return msMessageButtonMoreDetails;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageContentNikePlusPasswordPattern</b>.
		/// </summary>
		const string MESSAGE_CONTENT_NIKE_PLUS_PASSWORD_PATTERN = "your password contains a greater than symbol, ampersand or apostrophe (>, & or '), click 'more details' for further information.";
		/// <summary>
		/// Inner member for property <see cref="MessageContentNikePlusPasswordPattern"/>.
		/// </summary>
		static string msMessageContentNikePlusPasswordPattern;
		/// <summary>
		/// Gets string value for resource <b>MessageContentNikePlusPasswordPattern</b> (<i>"your password contains a greater than symbol, ampersand or apostrophe (>, & or '), click 'more details' for further information."</i>).
		/// </summary>
		public static string MessageContentNikePlusPasswordPattern
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageContentNikePlusPasswordPattern))
				{
					msMessageContentNikePlusPasswordPattern = moResourceLoader.GetString("MessageContentNikePlusPasswordPattern");
					if (string.IsNullOrEmpty(msMessageContentNikePlusPasswordPattern))
					{
						msMessageContentNikePlusPasswordPattern = MESSAGE_CONTENT_NIKE_PLUS_PASSWORD_PATTERN;
					}
				}
				return msMessageContentNikePlusPasswordPattern;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageContentNikePlusValidateFail</b>.
		/// </summary>
		const string MESSAGE_CONTENT_NIKE_PLUS_VALIDATE_FAIL = "failed to connect to nike+, wait a moment or validate user/pasword, and try again.";
		/// <summary>
		/// Inner member for property <see cref="MessageContentNikePlusValidateFail"/>.
		/// </summary>
		static string msMessageContentNikePlusValidateFail;
		/// <summary>
		/// Gets string value for resource <b>MessageContentNikePlusValidateFail</b> (<i>"failed to connect to nike+, wait a moment or validate user/pasword, and try again."</i>).
		/// </summary>
		public static string MessageContentNikePlusValidateFail
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageContentNikePlusValidateFail))
				{
					msMessageContentNikePlusValidateFail = moResourceLoader.GetString("MessageContentNikePlusValidateFail");
					if (string.IsNullOrEmpty(msMessageContentNikePlusValidateFail))
					{
						msMessageContentNikePlusValidateFail = MESSAGE_CONTENT_NIKE_PLUS_VALIDATE_FAIL;
					}
				}
				return msMessageContentNikePlusValidateFail;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageContentNikePlusValidateSuccess</b>.
		/// </summary>
		const string MESSAGE_CONTENT_NIKE_PLUS_VALIDATE_SUCCESS = "successfully connected to nike+.";
		/// <summary>
		/// Inner member for property <see cref="MessageContentNikePlusValidateSuccess"/>.
		/// </summary>
		static string msMessageContentNikePlusValidateSuccess;
		/// <summary>
		/// Gets string value for resource <b>MessageContentNikePlusValidateSuccess</b> (<i>"successfully connected to nike+."</i>).
		/// </summary>
		public static string MessageContentNikePlusValidateSuccess
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageContentNikePlusValidateSuccess))
				{
					msMessageContentNikePlusValidateSuccess = moResourceLoader.GetString("MessageContentNikePlusValidateSuccess");
					if (string.IsNullOrEmpty(msMessageContentNikePlusValidateSuccess))
					{
						msMessageContentNikePlusValidateSuccess = MESSAGE_CONTENT_NIKE_PLUS_VALIDATE_SUCCESS;
					}
				}
				return msMessageContentNikePlusValidateSuccess;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageTitleNikePlus</b>.
		/// </summary>
		const string MESSAGE_TITLE_NIKE_PLUS = "nike+";
		/// <summary>
		/// Inner member for property <see cref="MessageTitleNikePlus"/>.
		/// </summary>
		static string msMessageTitleNikePlus;
		/// <summary>
		/// Gets string value for resource <b>MessageTitleNikePlus</b> (<i>"nike+"</i>).
		/// </summary>
		public static string MessageTitleNikePlus
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageTitleNikePlus))
				{
					msMessageTitleNikePlus = moResourceLoader.GetString("MessageTitleNikePlus");
					if (string.IsNullOrEmpty(msMessageTitleNikePlus))
					{
						msMessageTitleNikePlus = MESSAGE_TITLE_NIKE_PLUS;
					}
				}
				return msMessageTitleNikePlus;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>AppBarButtonSyncNikePlus.Label</b>.
		/// </summary>
		const string APP_BAR_BUTTON_SYNC_NIKE_PLUS_LABEL = "sync nike+";
		/// <summary>
		/// Inner member for property <see cref="AppBarButtonSyncNikePlusLabel"/>.
		/// </summary>
		static string msAppBarButtonSyncNikePlusLabel;
		/// <summary>
		/// Gets string value for resource <b>AppBarButtonSyncNikePlus.Label</b> (<i>"sync nike+"</i>).
		/// </summary>
		public static string AppBarButtonSyncNikePlusLabel
		{
			get
			{
				if (string.IsNullOrEmpty(msAppBarButtonSyncNikePlusLabel))
				{
					msAppBarButtonSyncNikePlusLabel = moResourceLoader.GetString("AppBarButtonSyncNikePlus.Label");
					if (string.IsNullOrEmpty(msAppBarButtonSyncNikePlusLabel))
					{
						msAppBarButtonSyncNikePlusLabel = APP_BAR_BUTTON_SYNC_NIKE_PLUS_LABEL;
					}
				}
				return msAppBarButtonSyncNikePlusLabel;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageContentNikePlusSync</b>.
		/// </summary>
		const string MESSAGE_CONTENT_NIKE_PLUS_SYNC = "activity synchronized to nike+.";
		/// <summary>
		/// Inner member for property <see cref="MessageContentNikePlusSync"/>.
		/// </summary>
		static string msMessageContentNikePlusSync;
		/// <summary>
		/// Gets string value for resource <b>MessageContentNikePlusSync</b> (<i>"activity synchronized to nike+."</i>).
		/// </summary>
		public static string MessageContentNikePlusSync
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageContentNikePlusSync))
				{
					msMessageContentNikePlusSync = moResourceLoader.GetString("MessageContentNikePlusSync");
					if (string.IsNullOrEmpty(msMessageContentNikePlusSync))
					{
						msMessageContentNikePlusSync = MESSAGE_CONTENT_NIKE_PLUS_SYNC;
					}
				}
				return msMessageContentNikePlusSync;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageContentNikePlusSyncFail</b>.
		/// </summary>
		const string MESSAGE_CONTENT_NIKE_PLUS_SYNC_FAIL = "activity couldn't be synchronized to nike+. wait a moment and try again.";
		/// <summary>
		/// Inner member for property <see cref="MessageContentNikePlusSyncFail"/>.
		/// </summary>
		static string msMessageContentNikePlusSyncFail;
		/// <summary>
		/// Gets string value for resource <b>MessageContentNikePlusSyncFail</b> (<i>"activity couldn't be synchronized to nike+. wait a moment and try again."</i>).
		/// </summary>
		public static string MessageContentNikePlusSyncFail
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageContentNikePlusSyncFail))
				{
					msMessageContentNikePlusSyncFail = moResourceLoader.GetString("MessageContentNikePlusSyncFail");
					if (string.IsNullOrEmpty(msMessageContentNikePlusSyncFail))
					{
						msMessageContentNikePlusSyncFail = MESSAGE_CONTENT_NIKE_PLUS_SYNC_FAIL;
					}
				}
				return msMessageContentNikePlusSyncFail;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>MessageContentNikePlusSyncWithFuel</b>.
		/// </summary>
		const string MESSAGE_CONTENT_NIKE_PLUS_SYNC_WITH_FUEL = "activity synchronized to nike+. fuel gain: {0:N0}";
		/// <summary>
		/// Inner member for property <see cref="MessageContentNikePlusSyncWithFuel"/>.
		/// </summary>
		static string msMessageContentNikePlusSyncWithFuel;
		/// <summary>
		/// Gets string value for resource <b>MessageContentNikePlusSyncWithFuel</b> (<i>"activity synchronized to nike+. fuel gain: {0:N0}"</i>).
		/// </summary>
		public static string MessageContentNikePlusSyncWithFuel
		{
			get
			{
				if (string.IsNullOrEmpty(msMessageContentNikePlusSyncWithFuel))
				{
					msMessageContentNikePlusSyncWithFuel = moResourceLoader.GetString("MessageContentNikePlusSyncWithFuel");
					if (string.IsNullOrEmpty(msMessageContentNikePlusSyncWithFuel))
					{
						msMessageContentNikePlusSyncWithFuel = MESSAGE_CONTENT_NIKE_PLUS_SYNC_WITH_FUEL;
					}
				}
				return msMessageContentNikePlusSyncWithFuel;
			}
		}
				
		/// <summary>
		/// Key for resource string <b>ToggleActivityTypeHike.Text</b>.
		/// </summary>
		const string TOGGLE_ACTIVITY_TYPE_HIKE_TEXT = "hike";
		/// <summary>
		/// Inner member for property <see cref="ToggleActivityTypeHikeText"/>.
		/// </summary>
		static string msToggleActivityTypeHikeText;
		/// <summary>
		/// Gets string value for resource <b>ToggleActivityTypeHike.Text</b> (<i>"hike"</i>).
		/// </summary>
		public static string ToggleActivityTypeHikeText
		{
			get
			{
				if (string.IsNullOrEmpty(msToggleActivityTypeHikeText))
				{
					msToggleActivityTypeHikeText = moResourceLoader.GetString("ToggleActivityTypeHike.Text");
					if (string.IsNullOrEmpty(msToggleActivityTypeHikeText))
					{
						msToggleActivityTypeHikeText = TOGGLE_ACTIVITY_TYPE_HIKE_TEXT;
					}
				}
				return msToggleActivityTypeHikeText;
			}
		}
				
	}
	
}

