﻿//-----------------------------------------------------------------------
// <copyright file="SettingsViewModel.cs" company="Jorge Alberto Hernández Quirino">
// Copyright (c) Jorge Alberto Hernández Quirino 2015-2016. All rights reserved.
// </copyright>
// <author>Jorge Alberto Hernández Quirino</author>
//-----------------------------------------------------------------------
namespace XportBand.ViewModel
{
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;
    using GalaSoft.MvvmLight.Messaging;
    using GalaSoft.MvvmLight.Views;
    using Model;
    using MSHealthAPI;
    using NikePlusAPI;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows.Input;
    using Windows.ApplicationModel;
    using Windows.UI.Core;
    using Windows.UI.Xaml.Controls;

    /// <summary>
    /// ViewModel for Settings view.
    /// </summary>
    /// <seealso cref="GalaSoft.MvvmLight.ViewModelBase" />
    /// <seealso cref="XportBand.Model.INavigable" />
    public sealed class SettingsViewModel : ViewModelBase, INavigable
    {

        #region Constants

        /// <summary>
        /// Service: Microsoft Health.
        /// </summary>
        private const string SERVICE_MSHEALTH = "MSHealth";

        /// <summary>
        /// Service: Runkeeper.
        /// </summary>
        private const string SERVICE_RUNKEEPER = "Runkeeper";

        /// <summary>
        /// Service: Nike+.
        /// </summary>
        private const string SERVICE_NIKEPLUS = "Nike+";

        /// <summary>
        /// Service: Facebook.
        /// </summary>
        private const string SERVICE_FACEBOOK = "Facebook";

        #endregion Constants

        #region Inner Members

        /// <summary>
        /// Dialog service instance.
        /// </summary>
        private readonly IDialogService moDialogService;

        /// <summary>
        /// Navigation service instance.
        /// </summary>
        private readonly INavigationService moNavigationService;

        /// <summary>
        /// Microsoft Health service instance.
        /// </summary>
        private readonly IMSHealthClient moMSHealthClient;

        /// <summary>
        /// Nike+ service instance.
        /// </summary>
        private readonly INikePlusClient moNikePlusClient;

        /// <summary>
        /// Inner member for <see cref="MSHealthProfile"/> property.
        /// </summary>
        private MSHealthProfile moMSHealthProfile;

        /// <summary>
        /// Inner member for <see cref="IsMSHealthSignedIn"/> property.
        /// </summary>
        private bool mbIsMSHealthSignedIn = false;

        /// <summary>
        /// Inner member for <see cref="IsMSHealthRunning"/> property.
        /// </summary>
        private bool mbIsMSHealthRunning = false;

        /// <summary>
        /// Inner member for <see cref="DistanceUnits"/> property.
        /// </summary>
        private ObservableCollection<DistanceUnit> moDistanceUnits;

        /// <summary>
        /// Inner member for <see cref="SelectedDistanceUnit"/> property.
        /// </summary>
        private DistanceUnit moSelectedDistanceUnit;

        /// <summary>
        /// Inner member for <see cref="NikePlusUser"/> property.
        /// </summary>
        private string msNikePlusUser;

        /// <summary>
        /// Inner member for <see cref="NikePlusPassword"/> property.
        /// </summary>
        private string msNikePlusPassword;

        /// <summary>
        /// Inner member for <see cref="IsNikePlusRunning"/> property.
        /// </summary>
        private bool mbIsNikePlusRunning = false;

        /// <summary>
        /// Inner member for <see cref="ShowSignIn"/> property.
        /// </summary>
        private bool mbShowSignIn = false;

        /// <summary>
        /// Inner member for <see cref="IsRunningRequest"/> property.
        /// </summary>
        private bool mbIsRunningRequest = false;

        /// <summary>
        /// Inner member for <see cref="AppVersion"/> property.
        /// </summary>
        private string msAppVersion;

        /// <summary>
        /// Name of current running service.
        /// </summary>
        private string msRunningService;

        #endregion Inner Members

        #region Properties

        /// <summary>
        /// Gets or sets the Microsoft Health Profile data for signed-in user.
        /// </summary>
        public MSHealthProfile MSHealthProfile
        {
            get { return moMSHealthProfile; }
            set { Set<MSHealthProfile>(() => MSHealthProfile, ref moMSHealthProfile, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether user is signed-into Microsoft Health.
        /// </summary>
        public bool IsMSHealthSignedIn
        {
            get { return mbIsMSHealthSignedIn; }
            set { Set<bool>(() => IsMSHealthSignedIn, ref mbIsMSHealthSignedIn, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether Microsoft Health request is running.
        /// </summary>
        public bool IsMSHealthRunning
        {
            get { return mbIsMSHealthRunning; }
            set { Set<bool>(() => IsMSHealthRunning, ref mbIsMSHealthRunning, value); }
        }

        /// <summary>
        /// Gets the collection of allowed distance units.
        /// </summary>
        public ObservableCollection<DistanceUnit> DistanceUnits
        {
            get
            {
                if (moDistanceUnits == null)
                {
                    List<DistanceUnit> loDistanceUnits = new List<DistanceUnit>();
                    loDistanceUnits.Add(new DistanceUnit()
                    {
                        Key = DistanceUnit.DISTANCE_MILE,
                        Description = Resources.Strings.ItemDistanceMilesContent,
                    });
                    loDistanceUnits.Add(new DistanceUnit()
                    {
                        Key = DistanceUnit.DISTANCE_KILOMETER,
                        Description = Resources.Strings.ItemDistanceKilometersContent,
                    });
                    moDistanceUnits = new ObservableCollection<DistanceUnit>(loDistanceUnits);
                }
                return moDistanceUnits;
            }
        }

        /// <summary>
        /// Gets or sets the selected distance unit.
        /// </summary>
        public DistanceUnit SelectedDistanceUnit
        {
            get { return moSelectedDistanceUnit; }
            set
            {
                Set<DistanceUnit>(() => SelectedDistanceUnit, ref moSelectedDistanceUnit, value);
                if (value != null)
                    Settings.MSHealthFilterDistance = value.Key;
            }
        }

        /// <summary>
        /// Gets or sets the Nike+ User (e-mail).
        /// </summary>
        public string NikePlusUser
        {
            get { return msNikePlusUser; }
            set
            {
                Set<string>(() => NikePlusUser, ref msNikePlusUser, value);
                ((RelayCommand)ValidateNikePlusCredentialCommand).RaiseCanExecuteChanged();
                ((RelayCommand)ClearNikePlusCredentialCommand).RaiseCanExecuteChanged();
            }
        }

        /// <summary>
        /// Gets or sets the Nike+ Password.
        /// </summary>
        public string NikePlusPassword
        {
            get { return msNikePlusPassword; }
            set
            {
                Set<string>(() => NikePlusPassword, ref msNikePlusPassword, value);
                ((RelayCommand)ValidateNikePlusCredentialCommand).RaiseCanExecuteChanged();
                ((RelayCommand)ClearNikePlusCredentialCommand).RaiseCanExecuteChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether Nike+ request is running.
        /// </summary>
        public bool IsNikePlusRunning
        {
            get { return mbIsNikePlusRunning; }
            set { Set<bool>(() => IsNikePlusRunning, ref mbIsNikePlusRunning, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether Sign-in WebView must be shown.
        /// </summary>
        public bool ShowSignIn
        {
            get { return mbShowSignIn; }
            set { Set<bool>(() => ShowSignIn, ref mbShowSignIn, value); }
        }

        /// <summary>
        /// Gets or sets the application version.
        /// </summary>
        public string AppVersion
        {
            get { return msAppVersion; }
            set { Set<string>(() => AppVersion, ref msAppVersion, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is running request.
        /// </summary>
        public bool IsRunningRequest
        {
            get { return mbIsRunningRequest; }
            set { Set<bool>(() => IsRunningRequest, ref mbIsRunningRequest, value); }
        }

        #endregion Properties

        #region Commands

        /// <summary>
        /// Gets the command to execute: Sign-in Microsoft Health.
        /// </summary>
        public ICommand SignInMSHealthCommand { get; private set; }

        /// <summary>
        /// Gets the command to execute: Sign-out Microsoft Health.
        /// </summary>
        public ICommand SignOutMSHealthCommand { get; private set; }

        /// <summary>
        /// Gets the command to execute: NavigationCompleted event.
        /// </summary>
        public ICommand NavigationCompletedCommand { get; private set; }

        /// <summary>
        /// Gets the command to execute: Validate Nike+ Credentials.
        /// </summary>
        public ICommand ValidateNikePlusCredentialCommand { get; private set; }

        /// <summary>
        /// Gets the command to execute: Clear Nike+ Credentials.
        /// </summary>
        public ICommand ClearNikePlusCredentialCommand { get; private set; }

        #endregion Commands

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsViewModel"/> class.
        /// </summary>
        /// <param name="dialogService">Dialog service instance.</param>
        /// <param name="navigationService">Navigation service instance.</param>
        /// <param name="msHealthClient">Microsoft Health service instance.</param>
        /// <param name="nikePlusClient">Nike+ service instance.</param>
        public SettingsViewModel(IDialogService dialogService, INavigationService navigationService, IMSHealthClient msHealthClient, INikePlusClient nikePlusClient)
        {
            // Initialize services
            moDialogService = dialogService;
            moNavigationService = navigationService;
            moMSHealthClient = msHealthClient;
            moNikePlusClient = nikePlusClient;
            // Initialize commands
            SignInMSHealthCommand = new RelayCommand(SignInMSHealth, () => true);
            SignOutMSHealthCommand = new RelayCommand(SignOutMSHealth, () => true);
            NavigationCompletedCommand = new RelayCommand<object>(NavigationCompleted, (args) => true);
            ValidateNikePlusCredentialCommand = new RelayCommand(ValidateNikePlusCredential,
                () => !string.IsNullOrEmpty(NikePlusUser) && !string.IsNullOrEmpty(NikePlusPassword));
            ClearNikePlusCredentialCommand = new RelayCommand(ClearNikePlusCredential,
                () => !string.IsNullOrEmpty(NikePlusUser) && !string.IsNullOrEmpty(NikePlusPassword));
            // Get AppVersion
            Package loPackage = Package.Current;
            PackageId loPackageId = loPackage.Id;
            PackageVersion loPackageVersion = loPackageId.Version;
            AppVersion = string.Format("v{0}.{1}.{2}.{3}",
                                       loPackageVersion.Major,
                                       loPackageVersion.Minor,
                                       loPackageVersion.Build,
                                       loPackageVersion.Revision);
            // Handle Back button requests
            SystemNavigationManager.GetForCurrentView().BackRequested += (s, e) =>
            {
                e.Handled = true;
                IsRunningRequest = false;
                IsMSHealthRunning = false;
                if (ShowSignIn)
                {
                    ShowSignIn = false;
                }
                else
                {
                    moNavigationService.GoBack();
                }
            };
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Invokes Sign-in to Microsoft Health service.
        /// </summary>
        private void SignInMSHealth()
        {
            IsRunningRequest = true;
            IsMSHealthRunning = true;
            msRunningService = SERVICE_MSHEALTH;
            Uri loSignInUri = moMSHealthClient.SignInUri;
            ShowSignIn = true;
            Messenger.Default.Send<Uri>(loSignInUri);
        }

        /// <summary>
        /// Invokes Sign-out from Microsoft Health service.
        /// </summary>
        private void SignOutMSHealth()
        {
            IsRunningRequest = true;
            IsMSHealthRunning = true;
            msRunningService = SERVICE_MSHEALTH;
            Uri loSignOutUri = moMSHealthClient.SignOutUri;
            ShowSignIn = true;
            Messenger.Default.Send<Uri>(loSignOutUri);
        }

        /// <summary>
        /// Handles NavigationCompleted event from WebView.
        /// </summary>
        /// <param name="args">Arguments for event.</param>
        private async void NavigationCompleted(object args)
        {
            // Validate EventArgs
            WebViewNavigationCompletedEventArgs loArgs = args as WebViewNavigationCompletedEventArgs;
            if (loArgs != null &&
                IsRunningRequest)
            {
                try
                {
                    switch (msRunningService)
                    {
                        case SERVICE_MSHEALTH:
                            // Handle Microsoft Health request
                            MSHealthNavigationResult loResult = await moMSHealthClient.HandleNavigationCompleted(loArgs);
                            switch (loResult)
                            {
                                case MSHealthNavigationResult.None:
                                    break;

                                case MSHealthNavigationResult.SignIn:
                                    // Signed-in, so, read profile and update values/settings
                                    MSHealthProfile = await moMSHealthClient.ReadProfile();
                                    IsMSHealthSignedIn = moMSHealthClient.IsSignedIn;
                                    Settings.MSHealthToken = moMSHealthClient.Token;
                                    ShowSignIn = false;
                                    IsRunningRequest = false;
                                    IsMSHealthRunning = false;
                                    break;

                                case MSHealthNavigationResult.SignOut:
                                    // Signed-out, so, reset values/settings
                                    MSHealthProfile = null;
                                    IsMSHealthSignedIn = false;
                                    Settings.MSHealthToken = null;
                                    ShowSignIn = false;
                                    IsRunningRequest = false;
                                    IsMSHealthRunning = false;
                                    break;

                                default:
                                    // Must not happen, so, reset values
                                    MSHealthProfile = null;
                                    IsMSHealthSignedIn = false;
                                    ShowSignIn = false;
                                    IsRunningRequest = false;
                                    IsMSHealthRunning = false;
                                    break;
                            }
                            break;

                        case SERVICE_RUNKEEPER:
                            break;

                        case SERVICE_NIKEPLUS:
                            break;

                        case SERVICE_FACEBOOK:
                            break;

                        default:
                            break;
                    }
                }
                catch (Exception loException)
                {
                    // Handle exceptions (just for debugging purposes). TODO: Delete this code
                    if (System.Diagnostics.Debugger.IsAttached)
                    {
                        System.Diagnostics.Debug.WriteLine(loException.StackTrace);
                        System.Diagnostics.Debugger.Break();
                    } // Handle exceptions (just for debugging purposes)

                    // Handle failed request
                    switch (msRunningService)
                    {
                        case SERVICE_MSHEALTH:
                            // Reset Microsoft Health values
                            MSHealthProfile = null;
                            IsMSHealthSignedIn = false;
                            IsMSHealthRunning = false;
                            break;

                        case SERVICE_RUNKEEPER:
                            break;

                        case SERVICE_NIKEPLUS:
                            break;

                        case SERVICE_FACEBOOK:
                            break;

                        default:
                            break;
                    }
                    // Reset general values
                    ShowSignIn = false;
                    IsRunningRequest = false;
                    msRunningService = null;
                    // Show error message
                    await moDialogService.ShowError(Resources.Strings.MessageContentErrorOperation,
                                                    Resources.Strings.MessageTitleError,
                                                    Resources.Strings.MessageButtonOK,
                                                    null);
                }
            }
        }

        /// <summary>
        /// Validates Nike+ credentials (sign-in test).
        /// </summary>
        private async void ValidateNikePlusCredential()
        {
            if (!string.IsNullOrEmpty(NikePlusUser) &&
                !string.IsNullOrEmpty(NikePlusPassword))
            {
                IsRunningRequest = true;
                IsNikePlusRunning = true;
                msRunningService = SERVICE_NIKEPLUS;
                // Check pattern
                if (System.Text.RegularExpressions.Regex.IsMatch(NikePlusPassword, "[\"&`'<>]"))
                {
                    await moDialogService.ShowMessage(Resources.Strings.MessageContentNikePlusPasswordPattern,
                                                      Resources.Strings.MessageTitleNikePlus,
                                                      Resources.Strings.MessageButtonOK,
                                                      Resources.Strings.MessageButtonMoreDetails,
                                                      async (result) =>
                                                      {
                                                          if (!result)
                                                              await Windows.System.Launcher.LaunchUriAsync(new Uri(NikePlusClient.URL_PASSWORD_PATTERN));
                                                      });
                }
                else
                {
#if WINDOWS_UWP
                    // Persist Nike+ Credentials
                    Settings.NikePlusCredential = new Windows.Security.Credentials.PasswordCredential()
                    {
                        UserName = NikePlusUser,
                        Password = NikePlusPassword,
                    };
#endif
                    try
                    {
                        // Test sign-in
                        moNikePlusClient.SetCredentials(NikePlusUser, NikePlusPassword);
                        if (await moNikePlusClient.SignIn())
                        {
                            await moDialogService.ShowMessage(Resources.Strings.MessageContentNikePlusValidateSuccess,
                                                              Resources.Strings.MessageTitleNikePlus,
                                                              Resources.Strings.MessageButtonOK,
                                                              null);
                        }
                        else
                        {
                            await moDialogService.ShowMessage(Resources.Strings.MessageContentNikePlusValidateFail,
                                                              Resources.Strings.MessageTitleNikePlus,
                                                              Resources.Strings.MessageButtonOK,
                                                              null);
                        }
                    }
                    catch //(Exception)
                    {
                        await moDialogService.ShowMessage(Resources.Strings.MessageContentNikePlusValidateFail,
                                                          Resources.Strings.MessageTitleNikePlus,
                                                          Resources.Strings.MessageButtonOK,
                                                          null);
                    }
                }
            }
            else
            {

            }
            IsRunningRequest = false;
            IsNikePlusRunning = false;
            msRunningService = null;

        }

        /// <summary>
        /// Clears persisted Nike+ credentials.
        /// </summary>
        private void ClearNikePlusCredential()
        {
            NikePlusUser = string.Empty;
            NikePlusPassword = string.Empty;
            Settings.NikePlusCredential = null;
        }

        #endregion Methods

        #region INavigable implementation

        /// <summary>
        /// Handler for <see cref="Page.OnNavigatedTo(Windows.UI.Xaml.Navigation.NavigationEventArgs)" />.
        /// </summary>
        /// <param name="parameter"><see cref="Windows.UI.Xaml.Navigation.NavigationEventArgs.Parameter" />.</param>
        public async void Activate(object parameter)
        {
            // Set back button visible (for Windows app)
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            // Handle SelectedDistanceUnit
            this.SelectedDistanceUnit = null;
            if (!string.IsNullOrEmpty(Settings.MSHealthFilterDistance))
            {
                this.SelectedDistanceUnit = (from loUnit in DistanceUnits
                                             where loUnit.Key == Settings.MSHealthFilterDistance
                                             select loUnit).FirstOrDefault();
            }
            // Check Microsoft Health refresh token
            if (Settings.MSHealthToken != null &&
                !string.IsNullOrEmpty(Settings.MSHealthToken.RefreshToken))
            {
                try
                {
                    // Microsoft Health refresh token is available, so, check validity
                    IsRunningRequest = true;
                    IsMSHealthRunning = true;
                    if (await moMSHealthClient.ValidateToken(Settings.MSHealthToken))
                    {
                        // Microsoft Health refresh token is valid, so, read profile
                        MSHealthProfile = await moMSHealthClient.ReadProfile();
                        Settings.MSHealthToken = moMSHealthClient.Token;
                        IsMSHealthSignedIn = true;
                    }
                    else
                    {
                        // Microsoft Health refresh token is not valid, so, set as signed-out
                        IsMSHealthSignedIn = false;
                        MSHealthProfile = null;
                    }
                }
                catch { IsMSHealthSignedIn = false; MSHealthProfile = null; }
                finally { IsRunningRequest = false; IsMSHealthRunning = false; }
            }
            else
            {
                // Microsoft Health refresh token is not available, so, set as signed-out
                IsMSHealthSignedIn = false;
                MSHealthProfile = null;
            }
            // Nike+ Credential
            if (Settings.NikePlusCredential != null)
            {
                NikePlusUser = Settings.NikePlusCredential.UserName;
                NikePlusPassword = Settings.NikePlusCredential.Password;
            }
        }

        /// <summary>
        /// Handler for <see cref="Windows.UI.Xaml.Controls.Page.OnNavigatedFrom(Windows.UI.Xaml.Navigation.NavigationEventArgs)" />.
        /// </summary>
        /// <param name="parameter"><see cref="Windows.UI.Xaml.Navigation.NavigationEventArgs.Parameter" />.</param>
        public void Deactivate(object parameter)
        {
            // Persist Nike+ Credentials
            if (!string.IsNullOrEmpty(NikePlusUser) &&
                !string.IsNullOrEmpty(NikePlusPassword))
            {
                // Check pattern
                if (!System.Text.RegularExpressions.Regex.IsMatch(NikePlusPassword, "[\"&`'<>]"))
                {
#if WINDOWS_UWP
                    Settings.NikePlusCredential = new Windows.Security.Credentials.PasswordCredential()
                    {
                        UserName = NikePlusUser,
                        Password = NikePlusPassword,
                    };
#endif
                    moNikePlusClient.SetCredentials(NikePlusUser, NikePlusPassword);
                }
            }
        }

        #endregion INavigable implementation

    }

}