/*
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
using System.Web;
using System.Numerics;
using PrimeAPI.Models;

namespace PrimeAPI.BusinessLogic
{
    public class PrimeBusiness
    {
        public List<Number> GetNumbers(int actorId)
        {
            List<Number> numbers = new List<Number>();

            for (int i = 0; i < 100; i++)
            {
                numbers[] = GetNumberToTest(i, actorId);
            }

            return numbers;
        }

        private Number GetNumberToTest(int i, int actorId)
        {
            throw new NotImplementedException();
        }
    }
}