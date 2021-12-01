﻿using LibraryService.Models.DTOs;
using System;
using System.Collections.Generic;

namespace LibraryService.DTOs.Requests
{
    public class AQLReqDTO
    {
        public string Description { get; set; }
        public int RatingMajor { get; set; }
        public int RatingMinor { get; set; }
        public Guid? ZoneTypeId { get; set; }

        public List<QCRageDTO> QCRages { get; set; }
    }
}
