﻿using MappingBetweenLayers.Models;

namespace MappingBetweenLayers.Services.External.Models.Responses
{
    public class GetExternalDataResponse : IGetExternalDataResponse
    {
        public string DataPoint1 { get; set; }

        public string DataPoint2 { get; set; }

        public string DataPoint3 { get; set; }
    }
}
