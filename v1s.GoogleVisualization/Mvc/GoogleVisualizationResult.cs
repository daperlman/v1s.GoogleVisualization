﻿/*  Copyright 2010 Panterlo AB, Jens Nylander, jens@panterlo.com
 *  http://www.panterlo.com | +46 70 421 20 50
 *   
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.

 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.

 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web;

namespace v1s.GoogleVisualization
{
    public class GoogleVisualizationResult : ActionResult
    {
        public GoogleVisualizationResponse GoogleVisualizationResponse { get; set; }


        public GoogleVisualizationResult(GoogleVisualizationResponse googleVisualizationResponse)
        {
            GoogleVisualizationResponse = googleVisualizationResponse;
        }


        public override void ExecuteResult(ControllerContext context)
        {
             if (context == null)
                throw new ArgumentNullException("context");

             HttpResponseBase response = context.HttpContext.Response;
             response.ContentType = "text/plain";

             response.Write(GoogleVisualizationHandler.GetGoogleVisualizationResponse(GoogleVisualizationResponse));
        }
    }
}
