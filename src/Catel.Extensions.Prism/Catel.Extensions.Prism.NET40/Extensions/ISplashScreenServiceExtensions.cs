﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISplashScreenServiceExtensions.cs" company="">
//   
// </copyright>
// <summary>
//   The splash screen service extensions.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Catel
{
    using System;

    using MVVM;
    using MVVM.Services;

    /// <summary>
    ///     The splash screen service extensions.
    /// </summary>
    public static class ISplashScreenServiceExtensions
    {
        #region Public Methods and Operators
        /// <summary>
        /// The commit asyc.
        /// </summary>
        /// <param name="this">
        /// The splash screen service.
        /// </param>
        /// <param name="viewModel">
        /// The view model.
        /// </param>
        /// <param name="regionName">
        /// The region name.
        /// </param>
        /// <param name="completedCallback">
        /// The completed callback.
        /// </param>
        /// <typeparam name="TViewModel">
        /// The view model type.
        /// </typeparam>
        public static void CommitAsyc<TViewModel>(this ISplashScreenService @this, TViewModel viewModel, string regionName, Action completedCallback = null) where TViewModel : IProgressNotifyableViewModel
        {
            viewModel.GetService<IUIVisualizerService>().Activate(viewModel, regionName);
            @this.CommitAsync(viewModel: viewModel, show: false, completedCallback: completedCallback);
        }

        /// <summary>
        /// The commit asyc.
        /// </summary>
        /// <param name="this">
        /// The splash screen service.
        /// </param>
        /// <param name="viewModel">
        /// The view model.
        /// </param>
        /// <param name="parentViewModel">
        /// The parent view model.
        /// </param>
        /// <param name="regionName">
        /// The region name.
        /// </param>
        /// <param name="completedCallback">
        /// The completed callback.
        /// </param>
        /// <typeparam name="TViewModel">
        /// The view model type.
        /// </typeparam>
        public static void CommitAsyc<TViewModel>(this ISplashScreenService @this, TViewModel viewModel, IViewModel parentViewModel, string regionName, Action completedCallback = null)
            where TViewModel : IProgressNotifyableViewModel
        {
            viewModel.GetService<IUIVisualizerService>().Activate(viewModel, parentViewModel, regionName);
            @this.CommitAsync(viewModel: viewModel, show: false, completedCallback: completedCallback);
        }

        #endregion
    }
}