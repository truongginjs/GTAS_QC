﻿using System;

namespace LibraryService.DTOs.Responses
{
    public class SiteResDTO
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
