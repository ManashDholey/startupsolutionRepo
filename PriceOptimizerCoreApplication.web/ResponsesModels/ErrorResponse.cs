﻿using System.Collections.Generic;

namespace PriceOptimizerCoreApplication.web.ResponsesModels
{
    public class ErrorResponse
    {
        public ErrorResponse() { }

        public ErrorResponse(ErrorModel error)
        {
            Errors.Add(error);
        }

        public List<ErrorModel> Errors { get; set; } = new List<ErrorModel>();


    }
}
