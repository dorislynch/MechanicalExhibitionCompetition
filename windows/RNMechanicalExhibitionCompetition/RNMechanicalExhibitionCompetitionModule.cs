using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Mechanical.Exhibition.Competition.RNMechanicalExhibitionCompetition
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNMechanicalExhibitionCompetitionModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNMechanicalExhibitionCompetitionModule"/>.
        /// </summary>
        internal RNMechanicalExhibitionCompetitionModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNMechanicalExhibitionCompetition";
            }
        }
    }
}
