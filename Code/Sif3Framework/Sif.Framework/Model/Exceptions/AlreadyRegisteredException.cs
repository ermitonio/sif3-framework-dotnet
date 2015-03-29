﻿/*
 * Copyright 2015 Systemic Pty Ltd
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Runtime.Serialization;

namespace Sif.Framework.Model.Exceptions
{

    /// <summary>
    /// This exception represents the situation where a Consumer or Provider has already been registered with the
    /// Environment Provider.
    /// </summary>
    [Serializable]
    class AlreadyRegisteredException : BaseException
    {

        /// <summary>
        /// <see cref="Sif.Framework.Model.Exceptions.BaseException()"/>
        /// </summary>
        public AlreadyRegisteredException()
            : base("Consumer or Provider has already been registered with the Environment Provider.")
        {

        }

        /// <summary>
        /// <see cref="Sif.Framework.Model.Exceptions.BaseException(System.String)"/>
        /// </summary>
        public AlreadyRegisteredException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// <see cref="Sif.Framework.Model.Exceptions.BaseException(System.String, System.Exception)"/>
        /// </summary>
        public AlreadyRegisteredException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

        /// <summary>
        /// <see cref="Sif.Framework.Model.Exceptions.BaseException(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)"/>
        /// </summary>
        protected AlreadyRegisteredException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }

    }

}
