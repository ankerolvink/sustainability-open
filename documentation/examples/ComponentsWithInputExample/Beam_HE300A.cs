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

// This file implements a steel HE300A beam

// Note the inclusion of the framework in the reference
using SustainabilityOpen.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// The namespace can be whatever you want it to be
namespace ComponentsWithInputExample
{
    /// <summary>
    /// Class overrides the SOPhysicalObject class
    /// </summary>
    public class Beam_HE300A : SOPhysicalObject
    {
        /// <summary>
        /// Constructor
        /// Note the name of the physical object you will need to pass to the base class.
        /// </summary>
        public Beam_HE300A()
            : base("HE300A")
        {
            // Adding a material quantity to the beam of 2 m3 of the material steel.
            this.AddMaterialQuantity(new SOMaterial("steel"), 2, "m3");
        }

    }
}
