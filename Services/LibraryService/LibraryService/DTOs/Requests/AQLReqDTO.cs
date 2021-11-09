﻿using System;

namespace LibraryService.DTOs.Requests
{
    public class AQLReqDTO
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int SeqNo { get; set; }
        public string LotSize { get; set; }
        public Guid? ZoneTypeId { get; set; }
    }
}
