﻿/*
* Program to provide API for distributed Prime searching
* Copyright (C) 2015. Nicolas A. Collins
*
* This program is free software; you can redistribute it and/or
* modify it under the terms of the GNU General Public License
* as published by the Free Software Foundation; either version 2
* of the License, or (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program; if not, write to the Free Software
* Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301, USA.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PrimeAPI.BusinessLogic;
using PrimeAPI.Models;


namespace PrimeAPI.Controllers
{
    public class PrimeController : ApiController
    {
        public PrimeBusiness PrimeBusiness = new PrimeBusiness();
        // GET api/prime/42
        public List<Number> Get(int actorId)
        {
            return PrimeBusiness.GetNumbers(actorId);
        }

        // POST api/prime
        public string Post([FromBody]List<Number> numbers)
        {
            PrimeBusiness.UpdateNumbers(numbers);

            return "success";
        }
	}
}