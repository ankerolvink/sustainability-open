﻿/// Copyright 2012-2013 Delft University of Technology, BEMNext Lab and contributors
/// 
///    Licensed under the Apache License, Version 2.0 (the "License");
///    you may not use this file except in compliance with the License.
///    You may obtain a copy of the License at
/// 
///        http://www.apache.org/licenses/LICENSE-2.0
/// 
///    Unless required by applicable law or agreed to in writing, software
///    distributed under the License is distributed on an "AS IS" BASIS,
///    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
///    See the License for the specific language governing permissions and
///    limitations under the License.
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SustainabilityOpen.Framework
{
    /// <summary>
    /// Analysis entity
    /// </summary>
    public class SOAnalysis : SOBase
    {
        // Properties
        private List<SODesigner> m_Designers;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of the analysis</param>
        public SOAnalysis(string name) : base(name)
        {
            this.m_Designers = new List<SODesigner>();
        }

        /// <summary>
        /// Clears the attached designers from this analysis
        /// </summary>
        public void ClearDesigners()
        {
            this.m_Designers.Clear();
        }

        /// <summary>
        /// Attaches a designer to this analysis
        /// </summary>
        /// <param name="designer"></param>
        public void AddDesigner(SODesigner designer)
        {
            this.m_Designers.Add(designer);
        }

        /// <summary>
        /// Runs the analysis. Override this method to make the analysis do some work.
        /// </summary>
        public virtual void RunAnalysis()
        {
        }

        /// <summary>
        /// Returns the attached designers
        /// </summary>
        public SODesigner[] Designers
        {
            get { return this.m_Designers.ToArray(); }
        }
    }
}
