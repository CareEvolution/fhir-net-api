﻿/* 
 * Copyright (c) 2018, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */


namespace Hl7.Fhir.ElementModel
{
    public class TypedElementSettings
    {
        public enum TypeErrorMode
        {
            Report,
            Ignore,
            Passthrough
        }

        public TypeErrorMode ErrorMode;

        public TypedElementSettings Clone() =>
            new TypedElementSettings
            {
                ErrorMode = ErrorMode
            };
    }
}