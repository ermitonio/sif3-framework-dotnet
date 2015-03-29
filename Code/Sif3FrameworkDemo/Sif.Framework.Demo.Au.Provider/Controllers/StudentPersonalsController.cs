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

using Sif.Framework.Controller;
using Sif.Framework.Demo.Au.Provider.Models;
using Sif.Framework.Demo.Au.Provider.Service;
using System;
using System.Net.Http;
using System.Web.Http;

namespace Sif.Framework.Demo.Au.Provider.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    public class StudentPersonalsController : GenericController<StudentPersonal, Guid>
    {

        /// <summary>
        /// 
        /// </summary>
        public StudentPersonalsController()
            : base(new StudentPersonalService())
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [Route("api/StudentPersonals/StudentPersonal")]
        public virtual HttpResponseMessage Post(StudentPersonal item)
        {
            return base.Post(item);
        }

    }

}
